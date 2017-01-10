namespace RPG_Project.Mantenedores
{
    partial class Mantenedor_Monstruos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Monstruos));
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.monsterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monsterTableAdapter = new RPG_Project.IDataSet1TableAdapters.MonsterTableAdapter();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.grillaMonster = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_damage = new System.Windows.Forms.NumericUpDown();
            this.num_lvl = new System.Windows.Forms.NumericUpDown();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMonster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_damage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // iDataSet1
            // 
            this.iDataSet1.DataSetName = "IDataSet1";
            this.iDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monsterBindingSource
            // 
            this.monsterBindingSource.DataMember = "Monster";
            this.monsterBindingSource.DataSource = this.iDataSet1;
            // 
            // monsterTableAdapter
            // 
            this.monsterTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MonsterTableAdapter = this.monsterTableAdapter;
            this.tableAdapterManager.NpcAttackTableAdapter = null;
            this.tableAdapterManager.NPCTableAdapter = null;
            this.tableAdapterManager.PvPTableAdapter = null;
            this.tableAdapterManager.StateTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RPG_Project.IDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // grillaMonster
            // 
            this.grillaMonster.AllowUserToAddRows = false;
            this.grillaMonster.AllowUserToDeleteRows = false;
            this.grillaMonster.AutoGenerateColumns = false;
            this.grillaMonster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaMonster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaMonster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMonster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.grillaMonster.DataSource = this.monsterBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaMonster.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaMonster.Location = new System.Drawing.Point(12, 195);
            this.grillaMonster.Name = "grillaMonster";
            this.grillaMonster.ReadOnly = true;
            this.grillaMonster.Size = new System.Drawing.Size(600, 174);
            this.grillaMonster.TabIndex = 0;
            this.grillaMonster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaMonster_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_monster";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_monster";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "monster_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "monster_power";
            this.dataGridViewTextBoxColumn3.HeaderText = "Daño";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "monster_level";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Firebrick;
            this.txt_nombre.ForeColor = System.Drawing.Color.Gold;
            this.txt_nombre.Location = new System.Drawing.Point(212, 12);
            this.txt_nombre.MaxLength = 50;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ShortcutsEnabled = false;
            this.txt_nombre.Size = new System.Drawing.Size(143, 20);
            this.txt_nombre.TabIndex = 2;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Daño:";
            // 
            // num_damage
            // 
            this.num_damage.BackColor = System.Drawing.Color.Firebrick;
            this.num_damage.ForeColor = System.Drawing.Color.Gold;
            this.num_damage.Location = new System.Drawing.Point(308, 38);
            this.num_damage.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.num_damage.Name = "num_damage";
            this.num_damage.Size = new System.Drawing.Size(47, 20);
            this.num_damage.TabIndex = 6;
            // 
            // num_lvl
            // 
            this.num_lvl.BackColor = System.Drawing.Color.Firebrick;
            this.num_lvl.ForeColor = System.Drawing.Color.Gold;
            this.num_lvl.Location = new System.Drawing.Point(213, 38);
            this.num_lvl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_lvl.Name = "num_lvl";
            this.num_lvl.Size = new System.Drawing.Size(47, 20);
            this.num_lvl.TabIndex = 7;
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ingreso.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_ingreso.ForeColor = System.Drawing.Color.Beige;
            this.btn_ingreso.Location = new System.Drawing.Point(108, 166);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(151, 23);
            this.btn_ingreso.TabIndex = 8;
            this.btn_ingreso.Text = "Ingresar / Actualizar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpiar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_limpiar.ForeColor = System.Drawing.Color.Beige;
            this.btn_limpiar.Location = new System.Drawing.Point(12, 166);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(90, 23);
            this.btn_limpiar.TabIndex = 9;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Beige;
            this.btn_eliminar.Location = new System.Drawing.Point(265, 166);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 23);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.Monstruos;
            this.pictureBox1.Location = new System.Drawing.Point(361, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RPG_Project.Properties.Resources.jolteon;
            this.pictureBox2.Location = new System.Drawing.Point(12, -44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 233);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // Mantenedor_Monstruos
            // 
            this.AcceptButton = this.btn_ingreso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btn_limpiar;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.num_lvl);
            this.Controls.Add(this.num_damage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grillaMonster);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 420);
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Mantenedor_Monstruos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor de Monstruos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantenedor_Monstruos_FormClosing);
            this.Load += new System.EventHandler(this.Mantenedor_Monstruos_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mantenedor_Monstruos_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monsterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMonster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_damage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IDataSet1 iDataSet1;
        private System.Windows.Forms.BindingSource monsterBindingSource;
        private IDataSet1TableAdapters.MonsterTableAdapter monsterTableAdapter;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView grillaMonster;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_damage;
        private System.Windows.Forms.NumericUpDown num_lvl;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}