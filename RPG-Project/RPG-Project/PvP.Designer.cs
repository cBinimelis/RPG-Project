namespace RPG_Project
{
    partial class PvP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PvP));
            this.lbl_nvlE = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pb_staminaE = new System.Windows.Forms.ProgressBar();
            this.pb_lifeE = new System.Windows.Forms.ProgressBar();
            this.pic_enemigo = new System.Windows.Forms.PictureBox();
            this.lbl_userE = new System.Windows.Forms.Label();
            this.btn_ggIZI = new System.Windows.Forms.Button();
            this.pic_personaje = new System.Windows.Forms.PictureBox();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_life = new System.Windows.Forms.Label();
            this.lbl_stamina = new System.Windows.Forms.Label();
            this.lbl_staminaE = new System.Windows.Forms.Label();
            this.lbl_lifeE = new System.Windows.Forms.Label();
            this.lbl_habilidades = new System.Windows.Forms.Label();
            this.btn_ataque4 = new System.Windows.Forms.Button();
            this.btn_ataque3 = new System.Windows.Forms.Button();
            this.btn_ataque2 = new System.Windows.Forms.Button();
            this.btn_ataque1 = new System.Windows.Forms.Button();
            this.pb_stamina = new System.Windows.Forms.ProgressBar();
            this.pb_life = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pic_enemigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personaje)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nvlE
            // 
            this.lbl_nvlE.AutoSize = true;
            this.lbl_nvlE.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nvlE.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nvlE.Location = new System.Drawing.Point(470, 40);
            this.lbl_nvlE.Name = "lbl_nvlE";
            this.lbl_nvlE.Size = new System.Drawing.Size(24, 20);
            this.lbl_nvlE.TabIndex = 40;
            this.lbl_nvlE.Text = "01";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(468, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(24, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Nv:";
            // 
            // pb_staminaE
            // 
            this.pb_staminaE.Location = new System.Drawing.Point(223, 38);
            this.pb_staminaE.Name = "pb_staminaE";
            this.pb_staminaE.Size = new System.Drawing.Size(190, 10);
            this.pb_staminaE.TabIndex = 34;
            this.pb_staminaE.Value = 50;
            // 
            // pb_lifeE
            // 
            this.pb_lifeE.Location = new System.Drawing.Point(223, 12);
            this.pb_lifeE.Maximum = 250;
            this.pb_lifeE.Name = "pb_lifeE";
            this.pb_lifeE.Size = new System.Drawing.Size(190, 20);
            this.pb_lifeE.TabIndex = 33;
            this.pb_lifeE.Value = 100;
            // 
            // pic_enemigo
            // 
            this.pic_enemigo.Image = global::RPG_Project.Properties.Resources.Archer;
            this.pic_enemigo.Location = new System.Drawing.Point(12, 12);
            this.pic_enemigo.Name = "pic_enemigo";
            this.pic_enemigo.Size = new System.Drawing.Size(205, 112);
            this.pic_enemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_enemigo.TabIndex = 32;
            this.pic_enemigo.TabStop = false;
            // 
            // lbl_userE
            // 
            this.lbl_userE.AutoSize = true;
            this.lbl_userE.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_userE.Font = new System.Drawing.Font("Impact", 15F);
            this.lbl_userE.ForeColor = System.Drawing.Color.Gold;
            this.lbl_userE.Location = new System.Drawing.Point(218, 51);
            this.lbl_userE.Name = "lbl_userE";
            this.lbl_userE.Size = new System.Drawing.Size(75, 25);
            this.lbl_userE.TabIndex = 41;
            this.lbl_userE.Text = "Player 1";
            // 
            // btn_ggIZI
            // 
            this.btn_ggIZI.BackColor = System.Drawing.Color.Firebrick;
            this.btn_ggIZI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ggIZI.Font = new System.Drawing.Font("Impact", 8F);
            this.btn_ggIZI.ForeColor = System.Drawing.Color.Gold;
            this.btn_ggIZI.Location = new System.Drawing.Point(35, 126);
            this.btn_ggIZI.Name = "btn_ggIZI";
            this.btn_ggIZI.Size = new System.Drawing.Size(138, 26);
            this.btn_ggIZI.TabIndex = 42;
            this.btn_ggIZI.Text = "ABANDONAR";
            this.btn_ggIZI.UseVisualStyleBackColor = false;
            this.btn_ggIZI.Click += new System.EventHandler(this.btn_ggIZI_Click);
            // 
            // pic_personaje
            // 
            this.pic_personaje.Image = global::RPG_Project.Properties.Resources.Mage;
            this.pic_personaje.Location = new System.Drawing.Point(287, 137);
            this.pic_personaje.Name = "pic_personaje";
            this.pic_personaje.Size = new System.Drawing.Size(205, 112);
            this.pic_personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personaje.TabIndex = 43;
            this.pic_personaje.TabStop = false;
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_user.Font = new System.Drawing.Font("Impact", 15F);
            this.lbl_user.ForeColor = System.Drawing.Color.Gold;
            this.lbl_user.Location = new System.Drawing.Point(218, 109);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(77, 25);
            this.lbl_user.TabIndex = 52;
            this.lbl_user.Text = "Player 2";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.Color.Gold;
            this.lbl_nivel.Location = new System.Drawing.Point(256, 170);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(24, 20);
            this.lbl_nivel.TabIndex = 51;
            this.lbl_nivel.Text = "01";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nv:";
            // 
            // lbl_life
            // 
            this.lbl_life.AutoSize = true;
            this.lbl_life.Font = new System.Drawing.Font("Impact", 9.75F);
            this.lbl_life.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_life.Location = new System.Drawing.Point(206, 151);
            this.lbl_life.Name = "lbl_life";
            this.lbl_life.Size = new System.Drawing.Size(44, 17);
            this.lbl_life.TabIndex = 53;
            this.lbl_life.Text = "label6";
            // 
            // lbl_stamina
            // 
            this.lbl_stamina.AutoSize = true;
            this.lbl_stamina.Font = new System.Drawing.Font("Impact", 9.75F);
            this.lbl_stamina.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_stamina.Location = new System.Drawing.Point(206, 173);
            this.lbl_stamina.Name = "lbl_stamina";
            this.lbl_stamina.Size = new System.Drawing.Size(44, 17);
            this.lbl_stamina.TabIndex = 54;
            this.lbl_stamina.Text = "label6";
            // 
            // lbl_staminaE
            // 
            this.lbl_staminaE.AutoSize = true;
            this.lbl_staminaE.Font = new System.Drawing.Font("Impact", 9.75F);
            this.lbl_staminaE.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_staminaE.Location = new System.Drawing.Point(419, 40);
            this.lbl_staminaE.Name = "lbl_staminaE";
            this.lbl_staminaE.Size = new System.Drawing.Size(44, 17);
            this.lbl_staminaE.TabIndex = 57;
            this.lbl_staminaE.Text = "label6";
            // 
            // lbl_lifeE
            // 
            this.lbl_lifeE.AutoSize = true;
            this.lbl_lifeE.Font = new System.Drawing.Font("Impact", 9.75F);
            this.lbl_lifeE.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_lifeE.Location = new System.Drawing.Point(419, 12);
            this.lbl_lifeE.Name = "lbl_lifeE";
            this.lbl_lifeE.Size = new System.Drawing.Size(44, 17);
            this.lbl_lifeE.TabIndex = 56;
            this.lbl_lifeE.Text = "label6";
            // 
            // lbl_habilidades
            // 
            this.lbl_habilidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_habilidades.AutoSize = true;
            this.lbl_habilidades.BackColor = System.Drawing.Color.Transparent;
            this.lbl_habilidades.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_habilidades.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_habilidades.Location = new System.Drawing.Point(220, 88);
            this.lbl_habilidades.Name = "lbl_habilidades";
            this.lbl_habilidades.Size = new System.Drawing.Size(92, 15);
            this.lbl_habilidades.TabIndex = 58;
            this.lbl_habilidades.Text = "habilidades";
            this.lbl_habilidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ataque4
            // 
            this.btn_ataque4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ataque4.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque4.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque4.Location = new System.Drawing.Point(151, 226);
            this.btn_ataque4.Name = "btn_ataque4";
            this.btn_ataque4.Size = new System.Drawing.Size(130, 23);
            this.btn_ataque4.TabIndex = 62;
            this.btn_ataque4.Text = "button4";
            this.btn_ataque4.UseVisualStyleBackColor = false;
            this.btn_ataque4.Click += new System.EventHandler(this.btn_ataque4_Click);
            // 
            // btn_ataque3
            // 
            this.btn_ataque3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ataque3.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque3.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque3.Location = new System.Drawing.Point(12, 226);
            this.btn_ataque3.Name = "btn_ataque3";
            this.btn_ataque3.Size = new System.Drawing.Size(130, 23);
            this.btn_ataque3.TabIndex = 61;
            this.btn_ataque3.Text = "button3";
            this.btn_ataque3.UseVisualStyleBackColor = false;
            this.btn_ataque3.Click += new System.EventHandler(this.btn_ataque3_Click);
            // 
            // btn_ataque2
            // 
            this.btn_ataque2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ataque2.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque2.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque2.Location = new System.Drawing.Point(151, 197);
            this.btn_ataque2.Name = "btn_ataque2";
            this.btn_ataque2.Size = new System.Drawing.Size(130, 23);
            this.btn_ataque2.TabIndex = 60;
            this.btn_ataque2.Text = "button2";
            this.btn_ataque2.UseVisualStyleBackColor = false;
            this.btn_ataque2.Click += new System.EventHandler(this.btn_ataque2_Click);
            // 
            // btn_ataque1
            // 
            this.btn_ataque1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ataque1.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque1.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque1.Location = new System.Drawing.Point(12, 197);
            this.btn_ataque1.Name = "btn_ataque1";
            this.btn_ataque1.Size = new System.Drawing.Size(130, 23);
            this.btn_ataque1.TabIndex = 59;
            this.btn_ataque1.Text = "button1";
            this.btn_ataque1.UseVisualStyleBackColor = false;
            this.btn_ataque1.Click += new System.EventHandler(this.btn_ataque1_Click);
            // 
            // pb_stamina
            // 
            this.pb_stamina.Location = new System.Drawing.Point(12, 181);
            this.pb_stamina.Name = "pb_stamina";
            this.pb_stamina.Size = new System.Drawing.Size(190, 10);
            this.pb_stamina.TabIndex = 64;
            this.pb_stamina.Value = 50;
            // 
            // pb_life
            // 
            this.pb_life.Location = new System.Drawing.Point(12, 155);
            this.pb_life.Maximum = 250;
            this.pb_life.Name = "pb_life";
            this.pb_life.Size = new System.Drawing.Size(190, 20);
            this.pb_life.TabIndex = 63;
            this.pb_life.Value = 100;
            // 
            // PvP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.pb_stamina);
            this.Controls.Add(this.pb_life);
            this.Controls.Add(this.btn_ataque4);
            this.Controls.Add(this.btn_ataque3);
            this.Controls.Add(this.btn_ataque2);
            this.Controls.Add(this.btn_ataque1);
            this.Controls.Add(this.lbl_habilidades);
            this.Controls.Add(this.lbl_staminaE);
            this.Controls.Add(this.lbl_lifeE);
            this.Controls.Add(this.lbl_stamina);
            this.Controls.Add(this.lbl_life);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic_personaje);
            this.Controls.Add(this.btn_ggIZI);
            this.Controls.Add(this.lbl_userE);
            this.Controls.Add(this.lbl_nvlE);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pb_staminaE);
            this.Controls.Add(this.pb_lifeE);
            this.Controls.Add(this.pic_enemigo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PvP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PvP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PvP_FormClosing);
            this.Load += new System.EventHandler(this.PvP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_enemigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nvlE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar pb_staminaE;
        private System.Windows.Forms.ProgressBar pb_lifeE;
        private System.Windows.Forms.PictureBox pic_enemigo;
        private System.Windows.Forms.Label lbl_userE;
        private System.Windows.Forms.Button btn_ggIZI;
        private System.Windows.Forms.PictureBox pic_personaje;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_life;
        private System.Windows.Forms.Label lbl_stamina;
        private System.Windows.Forms.Label lbl_staminaE;
        private System.Windows.Forms.Label lbl_lifeE;
        private System.Windows.Forms.Label lbl_habilidades;
        private System.Windows.Forms.Button btn_ataque4;
        private System.Windows.Forms.Button btn_ataque3;
        private System.Windows.Forms.Button btn_ataque2;
        private System.Windows.Forms.Button btn_ataque1;
        private System.Windows.Forms.ProgressBar pb_stamina;
        private System.Windows.Forms.ProgressBar pb_life;
    }
}