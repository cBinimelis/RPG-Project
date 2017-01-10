namespace RPG_Project.Mantenedores
{
    partial class Mantenedor_Bloqueos_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Bloqueos_User));
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dt_bloqueo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_motivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user1TableAdapter = new RPG_Project.IDataSet1TableAdapters.User1TableAdapter();
            this.gameMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameMasterTableAdapter = new RPG_Project.IDataSet1TableAdapters.gameMasterTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.block_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.block_UserTableAdapter = new RPG_Project.IDataSet1TableAdapters.Block_UserTableAdapter();
            this.vBlocks_UserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vBlocks_UserTableAdapter = new RPG_Project.IDataSet1TableAdapters.vBlocks_UserTableAdapter();
            this.grillaBloqueos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.user1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.combo_user = new System.Windows.Forms.ComboBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_ingreso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBlocks_UserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBloqueos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDataSet1
            // 
            this.iDataSet1.DataSetName = "IDataSet1";
            this.iDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AproxLevelTableAdapter = null;
            this.tableAdapterManager.AttackCharacterTableAdapter = null;
            this.tableAdapterManager.AttackTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Block_GMTableAdapter = null;
            this.tableAdapterManager.Block_UserTableAdapter = null;
            this.tableAdapterManager.CharacterTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.Bloqueos;
            this.pictureBox1.Location = new System.Drawing.Point(316, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(296, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dt_bloqueo
            // 
            this.dt_bloqueo.CalendarForeColor = System.Drawing.Color.LightCoral;
            this.dt_bloqueo.CalendarMonthBackground = System.Drawing.Color.Firebrick;
            this.dt_bloqueo.CustomFormat = "DD-MM-YYYY";
            this.dt_bloqueo.Location = new System.Drawing.Point(92, 38);
            this.dt_bloqueo.MaxDate = new System.DateTime(2016, 6, 6, 22, 31, 15, 0);
            this.dt_bloqueo.Name = "dt_bloqueo";
            this.dt_bloqueo.Size = new System.Drawing.Size(200, 20);
            this.dt_bloqueo.TabIndex = 1;
            this.dt_bloqueo.Value = new System.DateTime(2016, 6, 6, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha:";
            // 
            // txt_motivo
            // 
            this.txt_motivo.BackColor = System.Drawing.Color.Firebrick;
            this.txt_motivo.ForeColor = System.Drawing.Color.Gold;
            this.txt_motivo.Location = new System.Drawing.Point(92, 12);
            this.txt_motivo.MaxLength = 50;
            this.txt_motivo.Name = "txt_motivo";
            this.txt_motivo.ShortcutsEnabled = false;
            this.txt_motivo.Size = new System.Drawing.Size(200, 20);
            this.txt_motivo.TabIndex = 0;
            this.txt_motivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_motivo_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 15);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario:";
            // 
            // block_UserBindingSource
            // 
            this.block_UserBindingSource.DataMember = "Block_User";
            this.block_UserBindingSource.DataSource = this.iDataSet1;
            // 
            // block_UserTableAdapter
            // 
            this.block_UserTableAdapter.ClearBeforeFill = true;
            // 
            // vBlocks_UserBindingSource
            // 
            this.vBlocks_UserBindingSource.DataMember = "vBlocks_User";
            this.vBlocks_UserBindingSource.DataSource = this.iDataSet1;
            // 
            // vBlocks_UserTableAdapter
            // 
            this.vBlocks_UserTableAdapter.ClearBeforeFill = true;
            // 
            // grillaBloqueos
            // 
            this.grillaBloqueos.AllowUserToAddRows = false;
            this.grillaBloqueos.AllowUserToDeleteRows = false;
            this.grillaBloqueos.AutoGenerateColumns = false;
            this.grillaBloqueos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grillaBloqueos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaBloqueos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.grillaBloqueos.DataSource = this.vBlocks_UserBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaBloqueos.DefaultCellStyle = dataGridViewCellStyle1;
            this.grillaBloqueos.Location = new System.Drawing.Point(12, 188);
            this.grillaBloqueos.Name = "grillaBloqueos";
            this.grillaBloqueos.ReadOnly = true;
            this.grillaBloqueos.Size = new System.Drawing.Size(600, 181);
            this.grillaBloqueos.TabIndex = 9;
            this.grillaBloqueos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaBloqueos_CellClick);
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
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // user1BindingSource1
            // 
            this.user1BindingSource1.DataMember = "User1";
            this.user1BindingSource1.DataSource = this.iDataSet1;
            // 
            // user1BindingSource2
            // 
            this.user1BindingSource2.DataMember = "User1";
            this.user1BindingSource2.DataSource = this.iDataSet1;
            // 
            // combo_user
            // 
            this.combo_user.BackColor = System.Drawing.Color.Firebrick;
            this.combo_user.DataSource = this.user1BindingSource2;
            this.combo_user.DisplayMember = "user_name";
            this.combo_user.ForeColor = System.Drawing.Color.Gold;
            this.combo_user.FormattingEnabled = true;
            this.combo_user.Location = new System.Drawing.Point(92, 64);
            this.combo_user.Name = "combo_user";
            this.combo_user.Size = new System.Drawing.Size(200, 21);
            this.combo_user.TabIndex = 2;
            this.combo_user.ValueMember = "id_user";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpiar.ForeColor = System.Drawing.Color.Beige;
            this.btn_limpiar.Location = new System.Drawing.Point(12, 159);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(69, 23);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Beige;
            this.btn_eliminar.Location = new System.Drawing.Point(250, 159);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(60, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ingreso.ForeColor = System.Drawing.Color.Beige;
            this.btn_ingreso.Location = new System.Drawing.Point(87, 159);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(157, 23);
            this.btn_ingreso.TabIndex = 4;
            this.btn_ingreso.Text = "Ingresar / Actualizar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // Mantenedor_Bloqueos_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.combo_user);
            this.Controls.Add(this.grillaBloqueos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_motivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_bloqueo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 420);
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Mantenedor_Bloqueos_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Bloqueos de Usuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantenedor_Bloqueos_FormClosing);
            this.Load += new System.EventHandler(this.Mantenedor_Bloqueos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.block_UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vBlocks_UserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaBloqueos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IDataSet1 iDataSet1;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dt_bloqueo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_motivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource user1BindingSource;
        private IDataSet1TableAdapters.User1TableAdapter user1TableAdapter;
        private System.Windows.Forms.BindingSource gameMasterBindingSource;
        private IDataSet1TableAdapters.gameMasterTableAdapter gameMasterTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource block_UserBindingSource;
        private IDataSet1TableAdapters.Block_UserTableAdapter block_UserTableAdapter;
        private System.Windows.Forms.BindingSource vBlocks_UserBindingSource;
        private IDataSet1TableAdapters.vBlocks_UserTableAdapter vBlocks_UserTableAdapter;
        private System.Windows.Forms.DataGridView grillaBloqueos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource user1BindingSource1;
        private System.Windows.Forms.BindingSource user1BindingSource2;
        private System.Windows.Forms.ComboBox combo_user;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_ingreso;
    }
}