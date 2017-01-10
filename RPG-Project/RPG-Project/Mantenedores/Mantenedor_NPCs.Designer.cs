namespace RPG_Project.Mantenedores
{
    partial class Mantenedor_NPCs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_NPCs));
            this.num_lvl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaNPC = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.num_damage = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nPCTableAdapter = new RPG_Project.IDataSet1TableAdapters.NPCTableAdapter();
            this.iDataSet11 = new RPG_Project.IDataSet1();
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nPCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nPCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // num_lvl
            // 
            this.num_lvl.BackColor = System.Drawing.Color.Firebrick;
            this.num_lvl.ForeColor = System.Drawing.Color.Gold;
            this.num_lvl.Location = new System.Drawing.Point(218, 38);
            this.num_lvl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_lvl.Name = "num_lvl";
            this.num_lvl.Size = new System.Drawing.Size(47, 20);
            this.num_lvl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(181, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nivel";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Firebrick;
            this.txt_nombre.ForeColor = System.Drawing.Color.Gold;
            this.txt_nombre.Location = new System.Drawing.Point(218, 12);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ShortcutsEnabled = false;
            this.txt_nombre.Size = new System.Drawing.Size(143, 20);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre";
            // 
            // grillaNPC
            // 
            this.grillaNPC.AllowUserToAddRows = false;
            this.grillaNPC.AllowUserToDeleteRows = false;
            this.grillaNPC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaNPC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaNPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaNPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaNPC.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaNPC.Location = new System.Drawing.Point(12, 197);
            this.grillaNPC.Name = "grillaNPC";
            this.grillaNPC.ReadOnly = true;
            this.grillaNPC.Size = new System.Drawing.Size(600, 172);
            this.grillaNPC.TabIndex = 18;
            this.grillaNPC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaNPC_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_npc";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_npc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "npc_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "npc_level";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "npc_power";
            this.dataGridViewTextBoxColumn4.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Beige;
            this.btn_eliminar.Location = new System.Drawing.Point(271, 168);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 23);
            this.btn_eliminar.TabIndex = 5;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_limpiar.ForeColor = System.Drawing.Color.Beige;
            this.btn_limpiar.Location = new System.Drawing.Point(12, 168);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 23);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ingreso.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ingreso.ForeColor = System.Drawing.Color.Beige;
            this.btn_ingreso.Location = new System.Drawing.Point(108, 168);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(157, 23);
            this.btn_ingreso.TabIndex = 4;
            this.btn_ingreso.Text = "Ingresar / Actualizar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // num_damage
            // 
            this.num_damage.BackColor = System.Drawing.Color.Firebrick;
            this.num_damage.ForeColor = System.Drawing.Color.Gold;
            this.num_damage.Location = new System.Drawing.Point(314, 38);
            this.num_damage.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.num_damage.Name = "num_damage";
            this.num_damage.Size = new System.Drawing.Size(47, 20);
            this.num_damage.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Daño";
            // 
            // nPCTableAdapter
            // 
            this.nPCTableAdapter.ClearBeforeFill = true;
            // 
            // iDataSet11
            // 
            this.iDataSet11.DataSetName = "IDataSet1";
            this.iDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.Enemy_AttacksTableAdapter = null;
            this.tableAdapterManager.gameMasterTableAdapter = null;
            this.tableAdapterManager.ItemCharacterTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = null;
            this.tableAdapterManager.Logs_GMTableAdapter = null;
            this.tableAdapterManager.Logs_UserTableAdapter = null;
            this.tableAdapterManager.MonsterAttackTableAdapter = null;
            this.tableAdapterManager.MonsterTableAdapter = null;
            this.tableAdapterManager.NpcAttackTableAdapter = null;
            this.tableAdapterManager.NPCTableAdapter = this.nPCTableAdapter;
            this.tableAdapterManager.PvPTableAdapter = null;
            this.tableAdapterManager.StateTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RPG_Project.IDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.NPCs;
            this.pictureBox1.Location = new System.Drawing.Point(367, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RPG_Project.Properties.Resources.zombies;
            this.pictureBox2.Location = new System.Drawing.Point(1, -15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(426, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // nPCBindingSource1
            // 
            this.nPCBindingSource1.DataMember = "NPC";
            // 
            // nPCBindingSource
            // 
            this.nPCBindingSource.DataMember = "NPC";
            // 
            // Mantenedor_NPCs
            // 
            this.AcceptButton = this.btn_ingreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btn_limpiar;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.num_damage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grillaNPC);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.num_lvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 420);
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Mantenedor_NPCs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de NPC\'s";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantenedor_NPCs_FormClosing);
            this.Load += new System.EventHandler(this.Mantenedor_NPCs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaNPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown num_lvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaNPC;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.NumericUpDown num_damage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource nPCBindingSource1;
        private System.Windows.Forms.BindingSource nPCBindingSource;
        private IDataSet1TableAdapters.NPCTableAdapter nPCTableAdapter;
        private IDataSet1 iDataSet11;
        private IDataSet1 iDataSet1;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}