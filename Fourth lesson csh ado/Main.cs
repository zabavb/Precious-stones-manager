using Fourth_lesson_csh_ado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Fourth_lesson_csh_ado
{
    public partial class Main : Form
    {
        const string Path = "Stones.xml";
        XDocument Doc = XDocument.Load(Path);

        public Main()
        {
            InitializeComponent();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            comboBoxColors.SelectedIndex = 0;
        }

        public void SelectedItem()
        {
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            Extension.SelectedItemID = Convert.ToInt32(selectedRow.Cells["ID"].Value);
        }
        public int NewID()
        {
            return Doc.Element("Stones").Elements("Stone").Max(item => Convert.ToInt32(item.Attribute("ID")?.Value)) + 1;
        }

        private void InitializeDataGridView(Color color)
        {
            if (color == Color.Red)
                comboBoxColors.SelectedText = "Red";
            if (color == Color.Green)
                comboBoxColors.SelectedText = "Green";
            if (color == Color.Blue)
                comboBoxColors.SelectedText = "Blue";

            var whereSelect = Doc.Element("Stones").Elements("Stone")
                .Where(item => item.Element("Color")?.Value == color.Name)
                    .Select(item => new
                    {
                        ID = item.Attribute("ID")?.Value,
                        Name = item.Element("Name")?.Value,
                        Color = item.Element("Color")?.Value,
                        IsTransparent = item.Element("Color").Attribute("IsTransparent")?.Value,
                        Type = item.Element("Type")?.Value,
                        Description = item.Attribute("Description")?.Value
                    });

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Color");
            dataTable.Columns.Add("Transparent");
            dataTable.Columns.Add("Type");
            dataTable.Columns.Add("Description");

            foreach (var item in whereSelect)
                dataTable.Rows.Add(item.ID, item.Name, item.Color, item.IsTransparent, item.Type, item.Description);

            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns["ID"].Visible = false;
        }

        private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColors.SelectedIndex == 0)
                InitializeDataGridView(Color.Red);
            else if (comboBoxColors.SelectedIndex == 1)
                InitializeDataGridView(Color.Green);
            else if (comboBoxColors.SelectedIndex == 2)
                InitializeDataGridView(Color.Blue);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddOrEdit addForm = new AddOrEdit();
            Extension.IsAdd = true;
            DialogResult dialogResult = addForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

                XElement newStone = new XElement("Stone");

                XAttribute newId = new XAttribute("ID", NewID());
                XElement newName = new XElement("Name", addForm._Stone._Name);
                XElement newColor = new XElement("Color", addForm._Stone._Color.Name);
                XAttribute newIsTransparent = new XAttribute("IsTransparent", addForm._Stone.IsTransparent ? "Yes" : "No");
                XElement newType = new XElement("Type", addForm._Stone.Type.ToString());
                XAttribute newDescription = new XAttribute("Description", addForm._Stone.Description);

                newColor.Add(newIsTransparent);
                newStone.Add(newId, newName, newColor, newType, newDescription);

                Doc.Root.Add(newStone);
                Doc.Save(Path);

                InitializeDataGridView(addForm._Stone._Color);
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SelectedItem();

                AddOrEdit editForm = new AddOrEdit();
                Extension.IsAdd = false;

                DialogResult dialogResult = editForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    var where = Doc.Element("Stones").Elements("Stone").FirstOrDefault(item => Convert.ToInt32(item.Attribute("ID")?.Value) == Extension.SelectedItemID);

                    where.Element("Name").SetValue(editForm._Stone._Name);
                    where.Element("Color").SetValue(editForm._Stone._Color.Name);
                    where.Element("Color").Attribute("IsTransparent").SetValue(editForm._Stone.IsTransparent);
                    where.Element("Type").SetValue(editForm._Stone.Type);
                    where.Attribute("Description").SetValue(editForm._Stone.Description);

                    InitializeDataGridView(editForm._Stone._Color);

                    Doc.Save(Path);
                }
            }
            else
                MessageBox.Show("Please choose stone (one) to edit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                SelectedItem();

                var toDelete = Doc.Element("Stones").Elements("Stone").FirstOrDefault(item => Convert.ToInt32(item.Attribute("ID")?.Value) == Extension.SelectedItemID);
                toDelete.Remove();

                Doc.Save(Path);

                Color color = (toDelete.Element("Color")?.Value == "Red") ? Color.Red : (toDelete.Element("Color")?.Value == "Green") ? Color.Green : (toDelete.Element("Color")?.Value == "Blue" ? Color.Blue : new Color());
                InitializeDataGridView(color);
            }
            else
                MessageBox.Show("Please choose stone (one) to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}