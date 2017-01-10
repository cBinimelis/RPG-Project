namespace RPG_Project
{
    partial class Habilidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Habilidades));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.attackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attackTableAdapter = new RPG_Project.IDataSet1TableAdapters.AttackTableAdapter();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.vAtaquesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vAtaquesTableAdapter = new RPG_Project.IDataSet1TableAdapters.vAtaquesTableAdapter();
            this.grillaAtaques = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_seleccion = new System.Windows.Forms.Button();
            this.lbl_ataque = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAtaquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAtaques)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.finn_and_jake_by_abysswolf_d6bgo83;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // iDataSet1
            // 
            this.iDataSet1.DataSetName = "IDataSet1";
            this.iDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attackBindingSource
            // 
            this.attackBindingSource.DataMember = "Attack";
            this.attackBindingSource.DataSource = this.iDataSet1;
            // 
            // attackTableAdapter
            // 
            this.attackTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AproxLevelTableAdapter = null;
            this.tableAdapterManager.AttackCharacterTableAdapter = null;
            this.tableAdapterManager.AttackTableAdapter = this.attackTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Block_GMTableAdapter = null;
            this.tableAdapterManager.Block_UserTableAdapter = null;
            this.tableAdapterManager.CharacterTableAdapter = null;
            this.tableAdapterManager.Enemy_AttacksTableAdapter = null;
            this.tableAdapterManager.gameMasterTableAdapter = null;
            this.tableAdapterManager.ItemCharacterTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.Logs_GMTableAdapter = null;
            this.tableAdapterManager.Logs_UserTableAdapter = null;
            this.tableAdapterManager.MonsterAttackTableAdapter = null;
            this.tableAdapterManager.MonsterTableAdapter = null;
            this.tableAdapterManager.NpcAttackTableAdapter = null;
            this.tableAdapterManager.NPCTableAdapter = null;
            this.tableAdapterManager.PvPTableAdapter = null;
            this.tableAdapterManager.StateTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RPG_Project.IDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // vAtaquesBindingSource
            // 
            this.vAtaquesBindingSource.DataMember = "vAtaques";
            this.vAtaquesBindingSource.DataSource = this.iDataSet1;
            // 
            // vAtaquesTableAdapter
            // 
            this.vAtaquesTableAdapter.ClearBeforeFill = true;
            // 
            // grillaAtaques
            // 
            this.grillaAtaques.AllowUserToAddRows = false;
            this.grillaAtaques.AllowUserToDeleteRows = false;
            this.grillaAtaques.AllowUserToResizeRows = false;
            this.grillaAtaques.AutoGenerateColumns = false;
            this.grillaAtaques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaAtaques.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.grillaAtaques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAtaques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.grillaAtaques.DataSource = this.vAtaquesBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaAtaques.DefaultCellStyle = dataGridViewCellStyle1;
            this.grillaAtaques.Location = new System.Drawing.Point(249, 12);
            this.grillaAtaques.MultiSelect = false;
            this.grillaAtaques.Name = "grillaAtaques";
            this.grillaAtaques.ReadOnly = true;
            this.grillaAtaques.RowHeadersVisible = false;
            this.grillaAtaques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grillaAtaques.Size = new System.Drawing.Size(243, 237);
            this.grillaAtaques.TabIndex = 1;
            this.grillaAtaques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaAtaques_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_attack";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_attack";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ataques";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ataques";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_type";
            this.dataGridViewTextBoxColumn3.HeaderText = "id_type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Coste";
            this.dataGridViewTextBoxColumn5.HeaderText = "Coste";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Daño";
            this.dataGridViewTextBoxColumn6.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btn_seleccion
            // 
            this.btn_seleccion.BackColor = System.Drawing.Color.LightCoral;
            this.btn_seleccion.ForeColor = System.Drawing.Color.Beige;
            this.btn_seleccion.Location = new System.Drawing.Point(12, 219);
            this.btn_seleccion.Name = "btn_seleccion";
            this.btn_seleccion.Size = new System.Drawing.Size(231, 30);
            this.btn_seleccion.TabIndex = 2;
            this.btn_seleccion.Text = "Seleccionar / Reemplazar";
            this.btn_seleccion.UseVisualStyleBackColor = false;
            this.btn_seleccion.Click += new System.EventHandler(this.btn_seleccion_Click);
            // 
            // lbl_ataque
            // 
            this.lbl_ataque.AutoSize = true;
            this.lbl_ataque.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_ataque.Font = new System.Drawing.Font("Impact", 16F);
            this.lbl_ataque.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_ataque.Location = new System.Drawing.Point(12, 184);
            this.lbl_ataque.Name = "lbl_ataque";
            this.lbl_ataque.Size = new System.Drawing.Size(102, 27);
            this.lbl_ataque.TabIndex = 3;
            this.lbl_ataque.Text = "Selección";
            // 
            // Habilidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(504, 261);
            this.Controls.Add(this.lbl_ataque);
            this.Controls.Add(this.btn_seleccion);
            this.Controls.Add(this.grillaAtaques);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(520, 300);
            this.MinimumSize = new System.Drawing.Size(520, 300);
            this.Name = "Habilidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habilidades";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Habilidades_FormClosing);
            this.Load += new System.EventHandler(this.Habilidades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAtaquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAtaques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private IDataSet1 iDataSet1;
        private System.Windows.Forms.BindingSource attackBindingSource;
        private IDataSet1TableAdapters.AttackTableAdapter attackTableAdapter;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vAtaquesBindingSource;
        private IDataSet1TableAdapters.vAtaquesTableAdapter vAtaquesTableAdapter;
        private System.Windows.Forms.DataGridView grillaAtaques;
        private System.Windows.Forms.Button btn_seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label lbl_ataque;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}