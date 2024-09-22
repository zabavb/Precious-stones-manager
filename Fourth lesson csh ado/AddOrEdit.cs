using Fourth_lesson_csh_ado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Fourth_lesson_csh_ado
{
    public partial class AddOrEdit : Form
    {
        public Stone _Stone = new Stone();

        const string Path = "Stones.xml";
        XDocument Doc = XDocument.Load(Path);

        public AddOrEdit()
        {
            InitializeComponent();
            comboBoxColor.Items.AddRange(new string[] { "Red", "Green", "Blue" });
        }

        private void AddOrEdit_Load(object sender, EventArgs e)
        {
            if (!Extension.IsAdd)
            {
                var where = Doc.Element("Stones").Elements("Stone").Where(item => Convert.ToInt32(item.Attribute("ID")?.Value) == Extension.SelectedItemID);
                where.Select(item => new
                {
                    ID = item.Attribute("ID")?.Value,
                    Name = item.Element("Name")?.Value,
                    Color = item.Element("Color")?.Value,
                    IsTransparent = item.Element("Color").Attribute("IsTransparent")?.Value,
                    Type = item.Element("Type")?.Value,
                    Description = item.Attribute("Description")?.Value
                }).ToList().ForEach(item =>
                    {
                        textBoxName.Text = item.Name;
                        if (item.Color == "Red")
                            comboBoxColor.SelectedIndex = 0;
                        if (item.Color == "Green")
                            comboBoxColor.SelectedIndex = 1;
                        if (item.Color == "Blue")
                            comboBoxColor.SelectedIndex = 2;
                        checkBoxTransparent.Checked = item.IsTransparent == "Yes" ? true : false;
                        if (item.Type == "Precious")
                            radioButtonPrecious.Checked = true;
                        if (item.Type == "SemiPrecious")
                            radioButtonSemiPrecious.Checked = true;
                        if (item.Type == "Homemade")
                            radioButtonHomemade.Checked = true;

                        textBoxDescription.Text = item.Description;
                    });
            }
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length <= 20)
                _Stone._Name = textBoxName.Text;
            else
                MessageBox.Show("To many characters in name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem.ToString() == "Red")
                _Stone._Color = Color.Red;
            if (comboBoxColor.SelectedItem.ToString() == "Green")
                _Stone._Color = Color.Green;
            if (comboBoxColor.SelectedItem.ToString() == "Blue")
                _Stone._Color = Color.Blue;
        }
        private void checkBoxTransparent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTransparent.Checked)
                _Stone.IsTransparent = true;
            else
                _Stone.IsTransparent = false;
        }

        private void radioButtonPrecious_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPrecious.Checked)
                _Stone.Type = EnumType.Precious;
        }
        private void radioButtonSemiPrecious_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSemiPrecious.Checked)
                _Stone.Type = EnumType.SemiPrecious;
        }
        private void radioButtonHomemade_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHomemade.Checked)
                _Stone.Type = EnumType.Homemade;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDescription.Text.Length <= 300)
                _Stone.Description = textBoxDescription.Text;
            else
                MessageBox.Show("To many characters in description", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) || comboBoxColor.SelectedIndex == -1 || String.IsNullOrEmpty(textBoxDescription.Text))
                MessageBox.Show("Not all fields filled correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (radioButtonPrecious.Checked || radioButtonSemiPrecious.Checked || radioButtonHomemade.Checked)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Type had not checked", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}