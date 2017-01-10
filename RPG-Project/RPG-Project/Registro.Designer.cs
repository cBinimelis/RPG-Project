namespace RPG_Project
{
    partial class Registro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_comprobar = new System.Windows.Forms.TextBox();
            this.btn_registro = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 30F);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO";
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.Firebrick;
            this.txt_username.ForeColor = System.Drawing.Color.Gold;
            this.txt_username.Location = new System.Drawing.Point(76, 64);
            this.txt_username.Name = "txt_username";
            this.txt_username.ShortcutsEnabled = false;
            this.txt_username.Size = new System.Drawing.Size(155, 20);
            this.txt_username.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_username, "Ingrese el nombre de usuario que desea");
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.Firebrick;
            this.txt_pass.ForeColor = System.Drawing.Color.Gold;
            this.txt_pass.Location = new System.Drawing.Point(76, 90);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '♦';
            this.txt_pass.ShortcutsEnabled = false;
            this.txt_pass.Size = new System.Drawing.Size(155, 20);
            this.txt_pass.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txt_pass, "Ingrese la contraseña que desea utilizar");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comprobar";
            this.toolTip1.SetToolTip(this.label3, "Ingrese nuevamente su contraseña ");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña";
            // 
            // txt_comprobar
            // 
            this.txt_comprobar.BackColor = System.Drawing.Color.Firebrick;
            this.txt_comprobar.ForeColor = System.Drawing.Color.Gold;
            this.txt_comprobar.Location = new System.Drawing.Point(76, 116);
            this.txt_comprobar.Name = "txt_comprobar";
            this.txt_comprobar.PasswordChar = '♦';
            this.txt_comprobar.ShortcutsEnabled = false;
            this.txt_comprobar.Size = new System.Drawing.Size(155, 20);
            this.txt_comprobar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txt_comprobar, "Repita su contraseña");
            // 
            // btn_registro
            // 
            this.btn_registro.BackColor = System.Drawing.Color.LightCoral;
            this.btn_registro.ForeColor = System.Drawing.Color.Beige;
            this.btn_registro.Location = new System.Drawing.Point(12, 142);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(219, 26);
            this.btn_registro.TabIndex = 3;
            this.btn_registro.Text = "Registrarse";
            this.toolTip1.SetToolTip(this.btn_registro, "¡¡Comenzar!!");
            this.btn_registro.UseVisualStyleBackColor = false;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // Registro
            // 
            this.AcceptButton = this.btn_registro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(243, 180);
            this.Controls.Add(this.btn_registro);
            this.Controls.Add(this.txt_comprobar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(259, 219);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(259, 219);
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_comprobar;
        private System.Windows.Forms.Button btn_registro;
    }
}