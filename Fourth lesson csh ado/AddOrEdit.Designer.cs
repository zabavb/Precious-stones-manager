namespace Fourth_lesson_csh_ado
{
    partial class AddOrEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelName = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.checkBoxTransparent = new System.Windows.Forms.CheckBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.radioButtonPrecious = new System.Windows.Forms.RadioButton();
            this.radioButtonSemiPrecious = new System.Windows.Forms.RadioButton();
            this.radioButtonHomemade = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelName.Location = new System.Drawing.Point(26, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 21);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(101, 203);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(93, 43);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxName.Location = new System.Drawing.Point(132, 29);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(326, 28);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(294, 203);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 43);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelColor.Location = new System.Drawing.Point(26, 74);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(54, 21);
            this.labelColor.TabIndex = 4;
            this.labelColor.Text = "Color:";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(147, 71);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(140, 29);
            this.comboBoxColor.TabIndex = 5;
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            // 
            // checkBoxTransparent
            // 
            this.checkBoxTransparent.AutoSize = true;
            this.checkBoxTransparent.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.checkBoxTransparent.Location = new System.Drawing.Point(323, 73);
            this.checkBoxTransparent.Name = "checkBoxTransparent";
            this.checkBoxTransparent.Size = new System.Drawing.Size(122, 25);
            this.checkBoxTransparent.TabIndex = 7;
            this.checkBoxTransparent.Text = "Transparent";
            this.checkBoxTransparent.UseVisualStyleBackColor = true;
            this.checkBoxTransparent.CheckedChanged += new System.EventHandler(this.checkBoxTransparent_CheckedChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.textBoxDescription.Location = new System.Drawing.Point(132, 152);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(326, 28);
            this.textBoxDescription.TabIndex = 8;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelDescription.Location = new System.Drawing.Point(26, 155);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 21);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description:";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.labelType.Location = new System.Drawing.Point(26, 116);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(52, 21);
            this.labelType.TabIndex = 10;
            this.labelType.Text = "Type:";
            // 
            // radioButtonPrecious
            // 
            this.radioButtonPrecious.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPrecious.AutoSize = true;
            this.radioButtonPrecious.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonPrecious.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrecious.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.radioButtonPrecious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonPrecious.Location = new System.Drawing.Point(132, 111);
            this.radioButtonPrecious.Name = "radioButtonPrecious";
            this.radioButtonPrecious.Size = new System.Drawing.Size(82, 31);
            this.radioButtonPrecious.TabIndex = 11;
            this.radioButtonPrecious.TabStop = true;
            this.radioButtonPrecious.Text = "Precious";
            this.radioButtonPrecious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonPrecious.UseVisualStyleBackColor = false;
            this.radioButtonPrecious.CheckedChanged += new System.EventHandler(this.radioButtonPrecious_CheckedChanged);
            // 
            // radioButtonSemiPrecious
            // 
            this.radioButtonSemiPrecious.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSemiPrecious.AutoSize = true;
            this.radioButtonSemiPrecious.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonSemiPrecious.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSemiPrecious.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.radioButtonSemiPrecious.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonSemiPrecious.Location = new System.Drawing.Point(225, 111);
            this.radioButtonSemiPrecious.Name = "radioButtonSemiPrecious";
            this.radioButtonSemiPrecious.Size = new System.Drawing.Size(118, 31);
            this.radioButtonSemiPrecious.TabIndex = 12;
            this.radioButtonSemiPrecious.TabStop = true;
            this.radioButtonSemiPrecious.Text = "SemiPrecious";
            this.radioButtonSemiPrecious.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonSemiPrecious.UseVisualStyleBackColor = false;
            this.radioButtonSemiPrecious.CheckedChanged += new System.EventHandler(this.radioButtonSemiPrecious_CheckedChanged);
            // 
            // radioButtonHomemade
            // 
            this.radioButtonHomemade.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonHomemade.AutoSize = true;
            this.radioButtonHomemade.BackColor = System.Drawing.SystemColors.Control;
            this.radioButtonHomemade.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHomemade.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.radioButtonHomemade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonHomemade.Location = new System.Drawing.Point(354, 111);
            this.radioButtonHomemade.Name = "radioButtonHomemade";
            this.radioButtonHomemade.Size = new System.Drawing.Size(104, 31);
            this.radioButtonHomemade.TabIndex = 13;
            this.radioButtonHomemade.TabStop = true;
            this.radioButtonHomemade.Text = "Homemade";
            this.radioButtonHomemade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButtonHomemade.UseVisualStyleBackColor = false;
            this.radioButtonHomemade.CheckedChanged += new System.EventHandler(this.radioButtonHomemade_CheckedChanged);
            // 
            // AddOrEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 258);
            this.Controls.Add(this.radioButtonHomemade);
            this.Controls.Add(this.radioButtonSemiPrecious);
            this.Controls.Add(this.radioButtonPrecious);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.checkBoxTransparent);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelName);
            this.Name = "AddOrEdit";
            this.Text = "AddOrEdit";
            this.Load += new System.EventHandler(this.AddOrEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.CheckBox checkBoxTransparent;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.RadioButton radioButtonPrecious;
        private System.Windows.Forms.RadioButton radioButtonSemiPrecious;
        private System.Windows.Forms.RadioButton radioButtonHomemade;
    }
}