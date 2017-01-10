namespace RPG_Project
{
    partial class Posada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Posada));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_curar = new System.Windows.Forms.Button();
            this.btn_descanso = new System.Windows.Forms.Button();
            this.btn_restauraTodo = new System.Windows.Forms.Button();
            this.lbl_gold = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_stamina = new System.Windows.Forms.ProgressBar();
            this.pb_life = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.Posada;
            this.pictureBox1.Location = new System.Drawing.Point(138, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_curar
            // 
            this.btn_curar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_curar.ForeColor = System.Drawing.Color.Beige;
            this.btn_curar.Location = new System.Drawing.Point(12, 208);
            this.btn_curar.Name = "btn_curar";
            this.btn_curar.Size = new System.Drawing.Size(120, 20);
            this.btn_curar.TabIndex = 1;
            this.btn_curar.Text = "Curar $50";
            this.btn_curar.UseVisualStyleBackColor = false;
            this.btn_curar.Click += new System.EventHandler(this.btn_curar_Click);
            // 
            // btn_descanso
            // 
            this.btn_descanso.BackColor = System.Drawing.Color.LightCoral;
            this.btn_descanso.ForeColor = System.Drawing.Color.Beige;
            this.btn_descanso.Location = new System.Drawing.Point(12, 125);
            this.btn_descanso.Name = "btn_descanso";
            this.btn_descanso.Size = new System.Drawing.Size(120, 20);
            this.btn_descanso.TabIndex = 2;
            this.btn_descanso.Text = "Descansar $50";
            this.btn_descanso.UseVisualStyleBackColor = false;
            this.btn_descanso.Click += new System.EventHandler(this.btn_descanso_Click);
            // 
            // btn_restauraTodo
            // 
            this.btn_restauraTodo.BackColor = System.Drawing.Color.LightCoral;
            this.btn_restauraTodo.ForeColor = System.Drawing.Color.Beige;
            this.btn_restauraTodo.Location = new System.Drawing.Point(12, 59);
            this.btn_restauraTodo.Name = "btn_restauraTodo";
            this.btn_restauraTodo.Size = new System.Drawing.Size(120, 40);
            this.btn_restauraTodo.TabIndex = 3;
            this.btn_restauraTodo.Text = "Restaurar todo $150";
            this.btn_restauraTodo.UseVisualStyleBackColor = false;
            this.btn_restauraTodo.Click += new System.EventHandler(this.btn_restauraTodo_Click);
            // 
            // lbl_gold
            // 
            this.lbl_gold.AutoSize = true;
            this.lbl_gold.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gold.Font = new System.Drawing.Font("Impact", 20F);
            this.lbl_gold.ForeColor = System.Drawing.Color.Gold;
            this.lbl_gold.Location = new System.Drawing.Point(65, 19);
            this.lbl_gold.Name = "lbl_gold";
            this.lbl_gold.Size = new System.Drawing.Size(57, 34);
            this.lbl_gold.TabIndex = 23;
            this.lbl_gold.Text = "000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Impact", 15F);
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(48, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "x";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::RPG_Project.Properties.Resources.Retro_Coin_icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Impact", 12F);
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(9, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Vida";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Impact", 12F);
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Energía";
            // 
            // pb_stamina
            // 
            this.pb_stamina.Location = new System.Drawing.Point(12, 152);
            this.pb_stamina.Name = "pb_stamina";
            this.pb_stamina.Size = new System.Drawing.Size(120, 16);
            this.pb_stamina.TabIndex = 25;
            this.pb_stamina.Value = 26;
            // 
            // pb_life
            // 
            this.pb_life.Location = new System.Drawing.Point(13, 234);
            this.pb_life.Maximum = 250;
            this.pb_life.Name = "pb_life";
            this.pb_life.Size = new System.Drawing.Size(479, 15);
            this.pb_life.TabIndex = 24;
            this.pb_life.Value = 250;
            // 
            // Posada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_stamina);
            this.Controls.Add(this.pb_life);
            this.Controls.Add(this.lbl_gold);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_restauraTodo);
            this.Controls.Add(this.btn_descanso);
            this.Controls.Add(this.btn_curar);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "Posada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posada";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Posada_FormClosing);
            this.Load += new System.EventHandler(this.Posada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_curar;
        private System.Windows.Forms.Button btn_descanso;
        private System.Windows.Forms.Button btn_restauraTodo;
        private System.Windows.Forms.Label lbl_gold;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_stamina;
        private System.Windows.Forms.ProgressBar pb_life;
    }
}