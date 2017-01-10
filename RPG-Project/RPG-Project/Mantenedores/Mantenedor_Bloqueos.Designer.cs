namespace RPG_Project.Mantenedores
{
    partial class Mantenedor_Bloqueos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Bloqueos));
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.blocksNBansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blocksNBansTableAdapter = new RPG_Project.IDataSet1TableAdapters.BlocksNBansTableAdapter();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vBlocksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vBlocksTableAdapter = new RPG_Project.IDataSet1TableAdapters.vBlocksTableAdapter();
            this.grillaBloqueos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_bloqueo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user1TableAdapter = new RPG_Project.IDataSet1TableAdapters.User1TableAdapter();
            this.gameMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameMasterTableAdapter = new RPG_Project.IDataSet1TableAdapters.gameMasterTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksNBansBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBlocksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBloqueos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMasterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDataSet1
            // 
            this.iDataSet1.DataSetName = "IDataSet1";
            this.iDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blocksNBansBindingSource
            // 
            this.blocksNBansBindingSource.DataMember = "BlocksNBans";
            this.blocksNBansBindingSource.DataSource = this.iDataSet1;
            // 
            // blocksNBansTableAdapter
            // 
            this.blocksNBansTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AproxLevelTableAdapter = null;
            this.tableAdapterManager.AttackCharacterTableAdapter = null;
            this.tableAdapterManager.AttackTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BlocksNBansTableAdapter = this.blocksNBansTableAdapter;
            this.tableAdapterManager.CharacterTableAdapter = null;
            this.tableAdapterManager.Enemy_AttacksTableAdapter = null;
            this.tableAdapterManager.gameMasterTableAdapter = null;
            this.tableAdapterManager.ItemCharacterTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.LogsTableAdapter = null;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.Bloqueos;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(441, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // vBlocksBindingSource
            // 
            this.vBlocksBindingSource.DataMember = "vBlocks";
            this.vBlocksBindingSource.DataSource = this.iDataSet1;
            // 
            // vBlocksTableAdapter
            // 
            this.vBlocksTableAdapter.ClearBeforeFill = true;
            // 
            // grillaBloqueos
            // 
            this.grillaBloqueos.AllowUserToAddRows = false;
            this.grillaBloqueos.AllowUserToDeleteRows = false;
            this.grillaBloqueos.AutoGenerateColumns = false;
            this.grillaBloqueos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaBloqueos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaBloqueos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBloqueos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.grillaBloqueos.DataSource = this.vBlocksBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaBloqueos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaBloqueos.Location = new System.Drawing.Point(12, 314);
            this.grillaBloqueos.Name = "grillaBloqueos";
            this.grillaBloqueos.ReadOnly = true;
            this.grillaBloqueos.Size = new System.Drawing.Size(443, 220);
            this.grillaBloqueos.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_block";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_block";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Motivo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Motivo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fecha de Bloqueo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha de Bloqueo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Usuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_gameM";
            this.dataGridViewTextBoxColumn6.HeaderText = "id_gameM";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Game Master";
            this.dataGridViewTextBoxColumn7.HeaderText = "Game Master";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dt_bloqueo
            // 
            this.dt_bloqueo.CalendarForeColor = System.Drawing.Color.LightCoral;
            this.dt_bloqueo.CalendarMonthBackground = System.Drawing.Color.Firebrick;
            this.dt_bloqueo.CustomFormat = "DD-MM-YYYY";
            this.dt_bloqueo.Location = new System.Drawing.Point(255, 256);
            this.dt_bloqueo.Name = "dt_bloqueo";
            this.dt_bloqueo.Size = new System.Drawing.Size(200, 20);
            this.dt_bloqueo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.BackColor = System.Drawing.Color.Firebrick;
            this.txt_motivo.ForeColor = System.Drawing.Color.Gold;
            this.txt_motivo.Location = new System.Drawing.Point(60, 256);
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.Size = new System.Drawing.Size(124, 20);
            this.txt_motivo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Motivo:";
            // 
            // user1BindingSource
            // 
            this.user1BindingSource.DataMember = "User1";
            this.user1BindingSource.DataSource = this.iDataSet1;
            // 
            // user1TableAdapter
            // 
            this.user1TableAdapter.ClearBeforeFill = true;
            // 
            // gameMasterBindingSource
            // 
            this.gameMasterBindingSource.DataMember = "gameMaster";
            this.gameMasterBindingSource.DataSource = this.iDataSet1;
            // 
            // gameMasterTableAdapter
            // 
            this.gameMasterTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "GMaster:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario:";
            // 
            // Mantenedor_Bloqueos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(469, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_bloqueo);
            this.Controls.Add(this.grillaBloqueos);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mantenedor_Bloqueos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Bloqueos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantenedor_Bloqueos_FormClosing);
            this.Load += new System.EventHandler(this.Mantenedor_Bloqueos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blocksNBansBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBlocksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBloqueos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMasterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IDataSet1 iDataSet1;
        private System.Windows.Forms.BindingSource blocksNBansBindingSource;
        private IDataSet1TableAdapters.BlocksNBansTableAdapter blocksNBansTableAdapter;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource vBlocksBindingSource;
        private IDataSet1TableAdapters.vBlocksTableAdapter vBlocksTableAdapter;
        private System.Windows.Forms.DataGridView grillaBloqueos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DateTimePicker dt_bloqueo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource user1BindingSource;
        private IDataSet1TableAdapters.User1TableAdapter user1TableAdapter;
        private System.Windows.Forms.BindingSource gameMasterBindingSource;
        private IDataSet1TableAdapters.gameMasterTableAdapter gameMasterTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}