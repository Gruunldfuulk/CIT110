namespace RpgGame
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.Lbl_GameTitle = new System.Windows.Forms.Label();
            this.Btn_CreateCharacter = new System.Windows.Forms.Button();
            this.Btn_LoadGame = new System.Windows.Forms.Button();
            this.Btn_Credits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_GameTitle
            // 
            this.Lbl_GameTitle.AutoSize = true;
            this.Lbl_GameTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lbl_GameTitle.Font = new System.Drawing.Font("Gabriola", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GameTitle.Location = new System.Drawing.Point(1, 9);
            this.Lbl_GameTitle.Name = "Lbl_GameTitle";
            this.Lbl_GameTitle.Size = new System.Drawing.Size(112, 54);
            this.Lbl_GameTitle.TabIndex = 0;
            this.Lbl_GameTitle.Text = "Dungeon";
            // 
            // Btn_CreateCharacter
            // 
            this.Btn_CreateCharacter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Btn_CreateCharacter.Location = new System.Drawing.Point(3, 94);
            this.Btn_CreateCharacter.Name = "Btn_CreateCharacter";
            this.Btn_CreateCharacter.Size = new System.Drawing.Size(75, 30);
            this.Btn_CreateCharacter.TabIndex = 1;
            this.Btn_CreateCharacter.Text = "New Game";
            this.Btn_CreateCharacter.UseVisualStyleBackColor = false;
            this.Btn_CreateCharacter.Click += new System.EventHandler(this.Btn_CreateCharacter_Click);
            // 
            // Btn_LoadGame
            // 
            this.Btn_LoadGame.BackColor = System.Drawing.Color.Turquoise;
            this.Btn_LoadGame.Location = new System.Drawing.Point(242, 431);
            this.Btn_LoadGame.Name = "Btn_LoadGame";
            this.Btn_LoadGame.Size = new System.Drawing.Size(11, 12);
            this.Btn_LoadGame.TabIndex = 2;
            this.Btn_LoadGame.Text = "Load Game";
            this.Btn_LoadGame.UseVisualStyleBackColor = false;
            this.Btn_LoadGame.Click += new System.EventHandler(this.Btn_LoadGame_Click);
            // 
            // Btn_Credits
            // 
            this.Btn_Credits.Location = new System.Drawing.Point(3, 146);
            this.Btn_Credits.Name = "Btn_Credits";
            this.Btn_Credits.Size = new System.Drawing.Size(75, 25);
            this.Btn_Credits.TabIndex = 4;
            this.Btn_Credits.Text = "Credits";
            this.Btn_Credits.UseVisualStyleBackColor = true;
            this.Btn_Credits.Click += new System.EventHandler(this.Btn_Credits_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(254, 446);
            this.Controls.Add(this.Btn_Credits);
            this.Controls.Add(this.Btn_LoadGame);
            this.Controls.Add(this.Btn_CreateCharacter);
            this.Controls.Add(this.Lbl_GameTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(270, 485);
            this.MinimumSize = new System.Drawing.Size(270, 485);
            this.Name = "Frm_Menu";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.Frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_GameTitle;
        private System.Windows.Forms.Button Btn_CreateCharacter;
        private System.Windows.Forms.Button Btn_LoadGame;
        private System.Windows.Forms.Button Btn_Credits;
    }
}

