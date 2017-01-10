namespace RPG_Project.Mantenedores
{
    partial class Mantenedor_Ataques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Ataques));
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_atName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._RPG_ProjectDataSet = new RPG_Project._RPG_ProjectDataSet();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeTableAdapter = new RPG_Project._RPG_ProjectDataSetTableAdapters.TypeTableAdapter();
            this.tableAdapterManager1 = new RPG_Project._RPG_ProjectDataSetTableAdapters.TableAdapterManager();
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.num_danio = new System.Windows.Forms.NumericUpDown();
            this.num_costo = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAtaquesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAtaques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._RPG_ProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_danio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_costo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.grillaAtaques.AutoGenerateColumns = false;
            this.grillaAtaques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaAtaques.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaAtaques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAtaques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.grillaAtaques.DataSource = this.vAtaquesBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaAtaques.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaAtaques.Location = new System.Drawing.Point(12, 186);
            this.grillaAtaques.Name = "grillaAtaques";
            this.grillaAtaques.ReadOnly = true;
            this.grillaAtaques.Size = new System.Drawing.Size(600, 183);
            this.grillaAtaques.TabIndex = 0;
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
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txt_atName
            // 
            this.txt_atName.BackColor = System.Drawing.Color.Firebrick;
            this.txt_atName.ForeColor = System.Drawing.Color.Gold;
            this.txt_atName.Location = new System.Drawing.Point(65, 18);
            this.txt_atName.MaxLength = 50;
            this.txt_atName.Name = "txt_atName";
            this.txt_atName.Size = new System.Drawing.Size(100, 20);
            this.txt_atName.TabIndex = 0;
            this.txt_atName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_atName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Daño:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Coste:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tipo:";
            // 
            // _RPG_ProjectDataSet
            // 
            this._RPG_ProjectDataSet.DataSetName = "_RPG_ProjectDataSet";
            this._RPG_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this._RPG_ProjectDataSet;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.TypeTableAdapter = this.typeTableAdapter;
            this.tableAdapterManager1.UpdateOrder = RPG_Project._RPG_ProjectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // combo_tipo
            // 
            this.combo_tipo.BackColor = System.Drawing.Color.Firebrick;
            this.combo_tipo.DataSource = this.typeBindingSource;
            this.combo_tipo.DisplayMember = "type_name";
            this.combo_tipo.ForeColor = System.Drawing.Color.Gold;
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Location = new System.Drawing.Point(254, 17);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(100, 21);
            this.combo_tipo.TabIndex = 1;
            this.combo_tipo.ValueMember = "id_type";
            // 
            // num_danio
            // 
            this.num_danio.BackColor = System.Drawing.Color.Firebrick;
            this.num_danio.ForeColor = System.Drawing.Color.Gold;
            this.num_danio.Location = new System.Drawing.Point(254, 44);
            this.num_danio.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.num_danio.Name = "num_danio";
            this.num_danio.Size = new System.Drawing.Size(100, 20);
            this.num_danio.TabIndex = 3;
            // 
            // num_costo
            // 
            this.num_costo.BackColor = System.Drawing.Color.Firebrick;
            this.num_costo.ForeColor = System.Drawing.Color.Gold;
            this.num_costo.Location = new System.Drawing.Point(65, 44);
            this.num_costo.Name = "num_costo";
            this.num_costo.Size = new System.Drawing.Size(100, 20);
            this.num_costo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.attacks;
            this.pictureBox1.Location = new System.Drawing.Point(360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Beige;
            this.btn_eliminar.Location = new System.Drawing.Point(259, 153);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(95, 23);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_limpiar.ForeColor = System.Drawing.Color.Beige;
            this.btn_limpiar.Location = new System.Drawing.Point(15, 153);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(95, 23);
            this.btn_limpiar.TabIndex = 4;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ingreso.ForeColor = System.Drawing.Color.Beige;
            this.btn_ingreso.Location = new System.Drawing.Point(116, 153);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(140, 23);
            this.btn_ingreso.TabIndex = 5;
            this.btn_ingreso.Text = "Ingresar / Actualizar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RPG_Project.Properties.Resources.attacks2;
            this.pictureBox2.Location = new System.Drawing.Point(15, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(339, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Mantenedor_Ataques
            // 
            this.AcceptButton = this.btn_ingreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btn_limpiar;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.num_costo);
            this.Controls.Add(this.num_danio);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_atName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaAtaques);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Mantenedor_Ataques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Ataques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantenedor_Ataques_FormClosing);
            this.Load += new System.EventHandler(this.Mantenedor_Ataques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vAtaquesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAtaques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._RPG_ProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_danio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_costo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IDataSet1 iDataSet1;
        private System.Windows.Forms.BindingSource attackBindingSource;
        private IDataSet1TableAdapters.AttackTableAdapter attackTableAdapter;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource vAtaquesBindingSource;
        private IDataSet1TableAdapters.vAtaquesTableAdapter vAtaquesTableAdapter;
        private System.Windows.Forms.DataGridView grillaAtaques;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_atName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private _RPG_ProjectDataSet _RPG_ProjectDataSet;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private _RPG_ProjectDataSetTableAdapters.TypeTableAdapter typeTableAdapter;
        private _RPG_ProjectDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.NumericUpDown num_danio;
        private System.Windows.Forms.NumericUpDown num_costo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}