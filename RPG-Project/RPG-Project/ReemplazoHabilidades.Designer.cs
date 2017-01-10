namespace RPG_Project
{
    partial class ReemplazoHabilidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReemplazoHabilidades));
            this.checkAta1 = new System.Windows.Forms.CheckBox();
            this.checkAta4 = new System.Windows.Forms.CheckBox();
            this.checkAta3 = new System.Windows.Forms.CheckBox();
            this.checkAta2 = new System.Windows.Forms.CheckBox();
            this.btn_seleccion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkAta1
            // 
            this.checkAta1.AutoSize = true;
            this.checkAta1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAta1.Location = new System.Drawing.Point(12, 12);
            this.checkAta1.Name = "checkAta1";
            this.checkAta1.Size = new System.Drawing.Size(104, 28);
            this.checkAta1.TabIndex = 0;
            this.checkAta1.Text = "Ataque 1";
            this.checkAta1.UseVisualStyleBackColor = true;
            // 
            // checkAta4
            // 
            this.checkAta4.AutoSize = true;
            this.checkAta4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAta4.Location = new System.Drawing.Point(12, 114);
            this.checkAta4.Name = "checkAta4";
            this.checkAta4.Size = new System.Drawing.Size(104, 28);
            this.checkAta4.TabIndex = 1;
            this.checkAta4.Text = "Ataque 4";
            this.checkAta4.UseVisualStyleBackColor = true;
            // 
            // checkAta3
            // 
            this.checkAta3.AutoSize = true;
            this.checkAta3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAta3.Location = new System.Drawing.Point(12, 80);
            this.checkAta3.Name = "checkAta3";
            this.checkAta3.Size = new System.Drawing.Size(104, 28);
            this.checkAta3.TabIndex = 2;
            this.checkAta3.Text = "Ataque 3";
            this.checkAta3.UseVisualStyleBackColor = true;
            // 
            // checkAta2
            // 
            this.checkAta2.AutoSize = true;
            this.checkAta2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkAta2.Location = new System.Drawing.Point(12, 46);
            this.checkAta2.Name = "checkAta2";
            this.checkAta2.Size = new System.Drawing.Size(104, 28);
            this.checkAta2.TabIndex = 3;
            this.checkAta2.Text = "Ataque 2";
            this.checkAta2.UseVisualStyleBackColor = true;
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.BackColor = System.Drawing.Color.LightCoral;
            this.btn_seleccion.ForeColor = System.Drawing.Color.Beige;
            this.btn_seleccion.Location = new System.Drawing.Point(12, 225);
            this.btn_seleccion.Name = "btn_seleccion";
            this.btn_seleccion.Size = new System.Drawing.Size(480, 23);
            this.btn_seleccion.TabIndex = 4;
            this.btn_seleccion.Text = "Seleccionar / Reemplazar";
            this.btn_seleccion.UseVisualStyleBackColor = false;
            this.btn_seleccion.Click += new System.EventHandler(this.btn_seleccion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.Reemplazo;
            this.pictureBox1.Location = new System.Drawing.Point(215, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Beige;
            this.button1.Location = new System.Drawing.Point(12, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "¿?";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReemplazoHabilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_seleccion);
            this.Controls.Add(this.checkAta2);
            this.Controls.Add(this.checkAta3);
            this.Controls.Add(this.checkAta4);
            this.Controls.Add(this.checkAta1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 300);
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "ReemplazoHabilidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReemplazoHabilidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReemplazoHabilidades_FormClosing);
            this.Load += new System.EventHandler(this.ReemplazoHabilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkAta1;
        private System.Windows.Forms.CheckBox checkAta4;
        private System.Windows.Forms.CheckBox checkAta3;
        private System.Windows.Forms.CheckBox checkAta2;
        private System.Windows.Forms.Button btn_seleccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}