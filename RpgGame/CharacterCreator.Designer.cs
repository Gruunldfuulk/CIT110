namespace RpgGame
{
    partial class Frm_CharacterCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CharacterCreator));
            this.Lbl_Name = new System.Windows.Forms.Label();
            this.Txt_CharacterName = new System.Windows.Forms.TextBox();
            this.Gbox_Gender = new System.Windows.Forms.GroupBox();
            this.Rdo_GenderFemale = new System.Windows.Forms.RadioButton();
            this.Rdo_GenderMale = new System.Windows.Forms.RadioButton();
            this.Cbo_CharacerClass = new System.Windows.Forms.ComboBox();
            this.Lbl_CharacerClass = new System.Windows.Forms.Label();
            this.Btn_SaveCharacter = new System.Windows.Forms.Button();
            this.Gbox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Name
            // 
            this.Lbl_Name.AutoSize = true;
            this.Lbl_Name.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Name.Location = new System.Drawing.Point(13, 13);
            this.Lbl_Name.Name = "Lbl_Name";
            this.Lbl_Name.Size = new System.Drawing.Size(39, 13);
            this.Lbl_Name.TabIndex = 0;
            this.Lbl_Name.Text = "Name";
            // 
            // Txt_CharacterName
            // 
            this.Txt_CharacterName.Location = new System.Drawing.Point(55, 13);
            this.Txt_CharacterName.Name = "Txt_CharacterName";
            this.Txt_CharacterName.Size = new System.Drawing.Size(100, 20);
            this.Txt_CharacterName.TabIndex = 1;
            // 
            // Gbox_Gender
            // 
            this.Gbox_Gender.BackColor = System.Drawing.Color.Firebrick;
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderFemale);
            this.Gbox_Gender.Controls.Add(this.Rdo_GenderMale);
            this.Gbox_Gender.Location = new System.Drawing.Point(16, 51);
            this.Gbox_Gender.Name = "Gbox_Gender";
            this.Gbox_Gender.Size = new System.Drawing.Size(200, 44);
            this.Gbox_Gender.TabIndex = 2;
            this.Gbox_Gender.TabStop = false;
            this.Gbox_Gender.Text = "Gender";
            // 
            // Rdo_GenderFemale
            // 
            this.Rdo_GenderFemale.AutoSize = true;
            this.Rdo_GenderFemale.Location = new System.Drawing.Point(61, 21);
            this.Rdo_GenderFemale.Name = "Rdo_GenderFemale";
            this.Rdo_GenderFemale.Size = new System.Drawing.Size(59, 17);
            this.Rdo_GenderFemale.TabIndex = 1;
            this.Rdo_GenderFemale.TabStop = true;
            this.Rdo_GenderFemale.Text = "Female";
            this.Rdo_GenderFemale.UseVisualStyleBackColor = true;
            // 
            // Rdo_GenderMale
            // 
            this.Rdo_GenderMale.AutoSize = true;
            this.Rdo_GenderMale.Location = new System.Drawing.Point(6, 19);
            this.Rdo_GenderMale.Name = "Rdo_GenderMale";
            this.Rdo_GenderMale.Size = new System.Drawing.Size(48, 17);
            this.Rdo_GenderMale.TabIndex = 0;
            this.Rdo_GenderMale.TabStop = true;
            this.Rdo_GenderMale.Text = "Male";
            this.Rdo_GenderMale.UseVisualStyleBackColor = true;
            // 
            // Cbo_CharacerClass
            // 
            this.Cbo_CharacerClass.FormattingEnabled = true;
            this.Cbo_CharacerClass.Items.AddRange(new object[] {
            "Fighter",
            "Rogue",
            "Cleric",
            "Wizard"});
            this.Cbo_CharacerClass.Location = new System.Drawing.Point(55, 124);
            this.Cbo_CharacerClass.Name = "Cbo_CharacerClass";
            this.Cbo_CharacerClass.Size = new System.Drawing.Size(121, 21);
            this.Cbo_CharacerClass.TabIndex = 3;
            // 
            // Lbl_CharacerClass
            // 
            this.Lbl_CharacerClass.AutoSize = true;
            this.Lbl_CharacerClass.BackColor = System.Drawing.Color.Firebrick;
            this.Lbl_CharacerClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CharacerClass.Location = new System.Drawing.Point(13, 131);
            this.Lbl_CharacerClass.Name = "Lbl_CharacerClass";
            this.Lbl_CharacerClass.Size = new System.Drawing.Size(37, 13);
            this.Lbl_CharacerClass.TabIndex = 4;
            this.Lbl_CharacerClass.Text = "Class";
            // 
            // Btn_SaveCharacter
            // 
            this.Btn_SaveCharacter.BackColor = System.Drawing.Color.Firebrick;
            this.Btn_SaveCharacter.Location = new System.Drawing.Point(15, 180);
            this.Btn_SaveCharacter.Name = "Btn_SaveCharacter";
            this.Btn_SaveCharacter.Size = new System.Drawing.Size(140, 50);
            this.Btn_SaveCharacter.TabIndex = 5;
            this.Btn_SaveCharacter.Text = "Save";
            this.Btn_SaveCharacter.UseVisualStyleBackColor = false;
            this.Btn_SaveCharacter.Click += new System.EventHandler(this.Btn_SaveCharacter_Click);
            // 
            // Frm_CharacterCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(279, 276);
            this.Controls.Add(this.Btn_SaveCharacter);
            this.Controls.Add(this.Lbl_CharacerClass);
            this.Controls.Add(this.Cbo_CharacerClass);
            this.Controls.Add(this.Gbox_Gender);
            this.Controls.Add(this.Txt_CharacterName);
            this.Controls.Add(this.Lbl_Name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(220, 50);
            this.MaximumSize = new System.Drawing.Size(295, 315);
            this.MinimumSize = new System.Drawing.Size(295, 315);
            this.Name = "Frm_CharacterCreator";
            this.ShowIcon = false;
            this.Text = "Create You Character";
            this.Gbox_Gender.ResumeLayout(false);
            this.Gbox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Txt_CharacterName;
        private System.Windows.Forms.GroupBox Gbox_Gender;
        private System.Windows.Forms.RadioButton Rdo_GenderFemale;
        private System.Windows.Forms.RadioButton Rdo_GenderMale;
        private System.Windows.Forms.ComboBox Cbo_CharacerClass;
        private System.Windows.Forms.Label Lbl_CharacerClass;
        private System.Windows.Forms.Button Btn_SaveCharacter;
    }
}