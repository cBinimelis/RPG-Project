namespace RPG_Project
{
    partial class Batalla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batalla));
            this.pb_lifeNPC = new System.Windows.Forms.ProgressBar();
            this.pb_life = new System.Windows.Forms.ProgressBar();
            this.pb_stamina = new System.Windows.Forms.ProgressBar();
            this.btn_ataque1 = new System.Windows.Forms.Button();
            this.btn_surrender = new System.Windows.Forms.Button();
            this.btn_ataque2 = new System.Windows.Forms.Button();
            this.btn_ataque3 = new System.Windows.Forms.Button();
            this.btn_ataque4 = new System.Windows.Forms.Button();
            this.pic_NPC = new System.Windows.Forms.PictureBox();
            this.pic_personaje = new System.Windows.Forms.PictureBox();
            this.lbl_lvlM = new System.Windows.Forms.Label();
            this.lbl_nivel = new System.Windows.Forms.Label();
            this.lbl_habilidades = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_NPC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_stamina = new System.Windows.Forms.Label();
            this.lbl_life = new System.Windows.Forms.Label();
            this.lbl_vidaNPC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_NPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personaje)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_lifeNPC
            // 
            this.pb_lifeNPC.Location = new System.Drawing.Point(24, 12);
            this.pb_lifeNPC.Maximum = 200;
            this.pb_lifeNPC.Name = "pb_lifeNPC";
            this.pb_lifeNPC.Size = new System.Drawing.Size(275, 37);
            this.pb_lifeNPC.TabIndex = 2;
            this.pb_lifeNPC.Value = 200;
            // 
            // pb_life
            // 
            this.pb_life.Location = new System.Drawing.Point(223, 137);
            this.pb_life.Maximum = 250;
            this.pb_life.Name = "pb_life";
            this.pb_life.Size = new System.Drawing.Size(190, 28);
            this.pb_life.TabIndex = 3;
            this.pb_life.Value = 100;
            // 
            // pb_stamina
            // 
            this.pb_stamina.Location = new System.Drawing.Point(223, 171);
            this.pb_stamina.Name = "pb_stamina";
            this.pb_stamina.Size = new System.Drawing.Size(190, 15);
            this.pb_stamina.TabIndex = 4;
            this.pb_stamina.Value = 50;
            // 
            // btn_ataque1
            // 
            this.btn_ataque1.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque1.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque1.Location = new System.Drawing.Point(223, 192);
            this.btn_ataque1.Name = "btn_ataque1";
            this.btn_ataque1.Size = new System.Drawing.Size(130, 25);
            this.btn_ataque1.TabIndex = 6;
            this.btn_ataque1.Text = "button1";
            this.btn_ataque1.UseVisualStyleBackColor = false;
            this.btn_ataque1.Click += new System.EventHandler(this.btn_ataque1_Click);
            // 
            // btn_surrender
            // 
            this.btn_surrender.BackColor = System.Drawing.Color.LightCoral;
            this.btn_surrender.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_surrender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_surrender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_surrender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_surrender.ForeColor = System.Drawing.Color.Beige;
            this.btn_surrender.Location = new System.Drawing.Point(202, 77);
            this.btn_surrender.Name = "btn_surrender";
            this.btn_surrender.Size = new System.Drawing.Size(96, 23);
            this.btn_surrender.TabIndex = 10;
            this.btn_surrender.Text = "Rendirse";
            this.btn_surrender.UseVisualStyleBackColor = false;
            this.btn_surrender.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_ataque2
            // 
            this.btn_ataque2.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque2.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque2.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque2.Location = new System.Drawing.Point(362, 192);
            this.btn_ataque2.Name = "btn_ataque2";
            this.btn_ataque2.Size = new System.Drawing.Size(130, 25);
            this.btn_ataque2.TabIndex = 13;
            this.btn_ataque2.Text = "button2";
            this.btn_ataque2.UseVisualStyleBackColor = false;
            this.btn_ataque2.Click += new System.EventHandler(this.btn_ataque2_Click);
            // 
            // btn_ataque3
            // 
            this.btn_ataque3.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque3.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque3.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque3.Location = new System.Drawing.Point(223, 223);
            this.btn_ataque3.Name = "btn_ataque3";
            this.btn_ataque3.Size = new System.Drawing.Size(130, 25);
            this.btn_ataque3.TabIndex = 14;
            this.btn_ataque3.Text = "button3";
            this.btn_ataque3.UseVisualStyleBackColor = false;
            this.btn_ataque3.Click += new System.EventHandler(this.btn_ataque3_Click);
            // 
            // btn_ataque4
            // 
            this.btn_ataque4.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ataque4.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_ataque4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btn_ataque4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_ataque4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ataque4.ForeColor = System.Drawing.Color.Beige;
            this.btn_ataque4.Location = new System.Drawing.Point(362, 224);
            this.btn_ataque4.Name = "btn_ataque4";
            this.btn_ataque4.Size = new System.Drawing.Size(130, 25);
            this.btn_ataque4.TabIndex = 15;
            this.btn_ataque4.Text = "button4";
            this.btn_ataque4.UseVisualStyleBackColor = false;
            this.btn_ataque4.Click += new System.EventHandler(this.btn_ataque4_Click);
            // 
            // pic_NPC
            // 
            this.pic_NPC.BackColor = System.Drawing.Color.Transparent;
            this.pic_NPC.Image = global::RPG_Project.Properties.Resources.Tengo_Dinero_y_Tu_No;
            this.pic_NPC.Location = new System.Drawing.Point(305, -9);
            this.pic_NPC.Name = "pic_NPC";
            this.pic_NPC.Size = new System.Drawing.Size(198, 140);
            this.pic_NPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_NPC.TabIndex = 1;
            this.pic_NPC.TabStop = false;
            // 
            // pic_personaje
            // 
            this.pic_personaje.BackColor = System.Drawing.Color.Transparent;
            this.pic_personaje.Image = global::RPG_Project.Properties.Resources.Archer;
            this.pic_personaje.Location = new System.Drawing.Point(12, 137);
            this.pic_personaje.Name = "pic_personaje";
            this.pic_personaje.Size = new System.Drawing.Size(205, 112);
            this.pic_personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personaje.TabIndex = 0;
            this.pic_personaje.TabStop = false;
            // 
            // lbl_lvlM
            // 
            this.lbl_lvlM.AutoSize = true;
            this.lbl_lvlM.BackColor = System.Drawing.Color.Transparent;
            this.lbl_lvlM.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lvlM.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_lvlM.Location = new System.Drawing.Point(47, 80);
            this.lbl_lvlM.Name = "lbl_lvlM";
            this.lbl_lvlM.Size = new System.Drawing.Size(24, 20);
            this.lbl_lvlM.TabIndex = 39;
            this.lbl_lvlM.Text = "01";
            // 
            // lbl_nivel
            // 
            this.lbl_nivel.AutoSize = true;
            this.lbl_nivel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nivel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nivel.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_nivel.Location = new System.Drawing.Point(468, 167);
            this.lbl_nivel.Name = "lbl_nivel";
            this.lbl_nivel.Size = new System.Drawing.Size(24, 20);
            this.lbl_nivel.TabIndex = 38;
            this.lbl_nivel.Text = "01";
            // 
            // lbl_habilidades
            // 
            this.lbl_habilidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbl_habilidades.AutoSize = true;
            this.lbl_habilidades.BackColor = System.Drawing.Color.Transparent;
            this.lbl_habilidades.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_habilidades.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_habilidades.Location = new System.Drawing.Point(14, 118);
            this.lbl_habilidades.Name = "lbl_habilidades";
            this.lbl_habilidades.Size = new System.Drawing.Size(92, 15);
            this.lbl_habilidades.TabIndex = 37;
            this.lbl_habilidades.Text = "habilidades";
            this.lbl_habilidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Nv:";
            // 
            // lbl_NPC
            // 
            this.lbl_NPC.AutoSize = true;
            this.lbl_NPC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NPC.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NPC.ForeColor = System.Drawing.Color.Gold;
            this.lbl_NPC.Location = new System.Drawing.Point(12, 52);
            this.lbl_NPC.Name = "lbl_NPC";
            this.lbl_NPC.Size = new System.Drawing.Size(59, 26);
            this.lbl_NPC.TabIndex = 35;
            this.lbl_NPC.Text = "Skull";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(468, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nv:";
            // 
            // lbl_stamina
            // 
            this.lbl_stamina.AutoSize = true;
            this.lbl_stamina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stamina.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stamina.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_stamina.Location = new System.Drawing.Point(419, 170);
            this.lbl_stamina.Name = "lbl_stamina";
            this.lbl_stamina.Size = new System.Drawing.Size(27, 17);
            this.lbl_stamina.TabIndex = 40;
            this.lbl_stamina.Text = "100";
            // 
            // lbl_life
            // 
            this.lbl_life.AutoSize = true;
            this.lbl_life.BackColor = System.Drawing.Color.Transparent;
            this.lbl_life.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_life.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_life.Location = new System.Drawing.Point(419, 137);
            this.lbl_life.Name = "lbl_life";
            this.lbl_life.Size = new System.Drawing.Size(29, 17);
            this.lbl_life.TabIndex = 41;
            this.lbl_life.Text = "250";
            // 
            // lbl_vidaNPC
            // 
            this.lbl_vidaNPC.AutoSize = true;
            this.lbl_vidaNPC.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vidaNPC.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vidaNPC.ForeColor = System.Drawing.Color.LightGreen;
            this.lbl_vidaNPC.Location = new System.Drawing.Point(269, 52);
            this.lbl_vidaNPC.Name = "lbl_vidaNPC";
            this.lbl_vidaNPC.Size = new System.Drawing.Size(29, 17);
            this.lbl_vidaNPC.TabIndex = 42;
            this.lbl_vidaNPC.Text = "250";
            // 
            // Batalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::RPG_Project.Properties.Resources.BattleBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.lbl_vidaNPC);
            this.Controls.Add(this.lbl_life);
            this.Controls.Add(this.lbl_stamina);
            this.Controls.Add(this.lbl_lvlM);
            this.Controls.Add(this.lbl_nivel);
            this.Controls.Add(this.lbl_habilidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_NPC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ataque4);
            this.Controls.Add(this.btn_ataque3);
            this.Controls.Add(this.btn_ataque2);
            this.Controls.Add(this.btn_surrender);
            this.Controls.Add(this.btn_ataque1);
            this.Controls.Add(this.pb_stamina);
            this.Controls.Add(this.pb_life);
            this.Controls.Add(this.pb_lifeNPC);
            this.Controls.Add(this.pic_NPC);
            this.Controls.Add(this.pic_personaje);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "Batalla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalla";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Batalla_FormClosing);
            this.Load += new System.EventHandler(this.Batalla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_NPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_personaje;
        private System.Windows.Forms.PictureBox pic_NPC;
        private System.Windows.Forms.ProgressBar pb_lifeNPC;
        private System.Windows.Forms.ProgressBar pb_life;
        private System.Windows.Forms.ProgressBar pb_stamina;
        private System.Windows.Forms.Button btn_ataque1;
        private System.Windows.Forms.Button btn_surrender;
        private System.Windows.Forms.Button btn_ataque2;
        private System.Windows.Forms.Button btn_ataque3;
        private System.Windows.Forms.Button btn_ataque4;
        private System.Windows.Forms.Label lbl_lvlM;
        private System.Windows.Forms.Label lbl_nivel;
        private System.Windows.Forms.Label lbl_habilidades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_NPC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_stamina;
        private System.Windows.Forms.Label lbl_life;
        private System.Windows.Forms.Label lbl_vidaNPC;
    }
}