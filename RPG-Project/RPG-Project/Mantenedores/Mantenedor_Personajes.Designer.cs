namespace RPG_Project.Mantenedores
{
    partial class Mantenedor_Personajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenedor_Personajes));
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.vCharsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vCharsTableAdapter = new RPG_Project.IDataSet1TableAdapters.vCharsTableAdapter();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.typeTableAdapter = new RPG_Project.IDataSet1TableAdapters.TypeTableAdapter();
            this.grillaChars = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_vida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_vida = new System.Windows.Forms.NumericUpDown();
            this.num_exp = new System.Windows.Forms.NumericUpDown();
            this.num_energia = new System.Windows.Forms.NumericUpDown();
            this.num_dinero = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.num_lvl = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.user1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user1TableAdapter = new RPG_Project.IDataSet1TableAdapters.User1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCharsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaChars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dinero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDataSet1
            // 
            this.iDataSet1.DataSetName = "IDataSet1";
            this.iDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vCharsBindingSource
            // 
            this.vCharsBindingSource.DataMember = "vChars";
            this.vCharsBindingSource.DataSource = this.iDataSet1;
            // 
            // vCharsTableAdapter
            // 
            this.vCharsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.NPCTableAdapter = null;
            this.tableAdapterManager.PvPTableAdapter = null;
            this.tableAdapterManager.StateTableAdapter = null;
            this.tableAdapterManager.TypeTableAdapter = this.typeTableAdapter;
            this.tableAdapterManager.UpdateOrder = RPG_Project.IDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.User1TableAdapter = null;
            // 
            // typeTableAdapter
            // 
            this.typeTableAdapter.ClearBeforeFill = true;
            // 
            // grillaChars
            // 
            this.grillaChars.AllowUserToAddRows = false;
            this.grillaChars.AllowUserToDeleteRows = false;
            this.grillaChars.AutoGenerateColumns = false;
            this.grillaChars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillaChars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillaChars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaChars.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.grillaChars.DataSource = this.vCharsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grillaChars.DefaultCellStyle = dataGridViewCellStyle2;
            this.grillaChars.Location = new System.Drawing.Point(12, 146);
            this.grillaChars.Name = "grillaChars";
            this.grillaChars.ReadOnly = true;
            this.grillaChars.Size = new System.Drawing.Size(600, 223);
            this.grillaChars.TabIndex = 1;
            this.grillaChars.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaChars_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_character";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_character";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Personaje";
            this.dataGridViewTextBoxColumn2.HeaderText = "Personaje";
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vida";
            this.dataGridViewTextBoxColumn7.HeaderText = "Vida";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Energia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Energia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Experiencia";
            this.dataGridViewTextBoxColumn9.HeaderText = "Experiencia";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nivel";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nivel";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pix-Dolares";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pix-Dolares";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Firebrick;
            this.txt_name.ForeColor = System.Drawing.Color.Gold;
            this.txt_name.Location = new System.Drawing.Point(81, 12);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.ShortcutsEnabled = false;
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 3;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.iDataSet1;
            // 
            // combo_tipo
            // 
            this.combo_tipo.BackColor = System.Drawing.Color.Firebrick;
            this.combo_tipo.DataSource = this.typeBindingSource;
            this.combo_tipo.DisplayMember = "type_name";
            this.combo_tipo.ForeColor = System.Drawing.Color.Gold;
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Location = new System.Drawing.Point(81, 90);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(100, 21);
            this.combo_tipo.TabIndex = 3;
            this.combo_tipo.ValueMember = "id_type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RPG_Project.Properties.Resources.chars;
            this.pictureBox1.Location = new System.Drawing.Point(376, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txt_vida
            // 
            this.txt_vida.AutoSize = true;
            this.txt_vida.Location = new System.Drawing.Point(12, 41);
            this.txt_vida.Name = "txt_vida";
            this.txt_vida.Size = new System.Drawing.Size(31, 13);
            this.txt_vida.TabIndex = 8;
            this.txt_vida.Text = "Vida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Energía:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Experiencia:";
            // 
            // num_vida
            // 
            this.num_vida.BackColor = System.Drawing.Color.Firebrick;
            this.num_vida.ForeColor = System.Drawing.Color.Gold;
            this.num_vida.Location = new System.Drawing.Point(81, 38);
            this.num_vida.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.num_vida.Name = "num_vida";
            this.num_vida.Size = new System.Drawing.Size(100, 20);
            this.num_vida.TabIndex = 13;
            // 
            // num_exp
            // 
            this.num_exp.BackColor = System.Drawing.Color.Firebrick;
            this.num_exp.ForeColor = System.Drawing.Color.Gold;
            this.num_exp.Location = new System.Drawing.Point(270, 66);
            this.num_exp.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.num_exp.Name = "num_exp";
            this.num_exp.Size = new System.Drawing.Size(100, 20);
            this.num_exp.TabIndex = 14;
            // 
            // num_energia
            // 
            this.num_energia.BackColor = System.Drawing.Color.Firebrick;
            this.num_energia.ForeColor = System.Drawing.Color.Gold;
            this.num_energia.Location = new System.Drawing.Point(270, 13);
            this.num_energia.Name = "num_energia";
            this.num_energia.Size = new System.Drawing.Size(100, 20);
            this.num_energia.TabIndex = 15;
            this.num_energia.ValueChanged += new System.EventHandler(this.num_energia_ValueChanged);
            // 
            // num_dinero
            // 
            this.num_dinero.BackColor = System.Drawing.Color.Firebrick;
            this.num_dinero.ForeColor = System.Drawing.Color.Gold;
            this.num_dinero.Location = new System.Drawing.Point(270, 40);
            this.num_dinero.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_dinero.Name = "num_dinero";
            this.num_dinero.Size = new System.Drawing.Size(100, 20);
            this.num_dinero.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pix-Dolares:";
            // 
            // num_lvl
            // 
            this.num_lvl.BackColor = System.Drawing.Color.Firebrick;
            this.num_lvl.ForeColor = System.Drawing.Color.Gold;
            this.num_lvl.Location = new System.Drawing.Point(81, 64);
            this.num_lvl.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_lvl.Name = "num_lvl";
            this.num_lvl.Size = new System.Drawing.Size(100, 20);
            this.num_lvl.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nivel:";
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ingreso.ForeColor = System.Drawing.Color.Beige;
            this.btn_ingreso.Location = new System.Drawing.Point(98, 117);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(186, 23);
            this.btn_ingreso.TabIndex = 20;
            this.btn_ingreso.Text = "Ingresar / Actualizar";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_limpiar.ForeColor = System.Drawing.Color.Beige;
            this.btn_limpiar.Location = new System.Drawing.Point(12, 117);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(80, 23);
            this.btn_limpiar.TabIndex = 21;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_eliminar.ForeColor = System.Drawing.Color.Beige;
            this.btn_eliminar.Location = new System.Drawing.Point(290, 117);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(80, 23);
            this.btn_eliminar.TabIndex = 22;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            // Mantenedor_Personajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(624, 381);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.num_lvl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.num_dinero);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.num_energia);
            this.Controls.Add(this.num_exp);
            this.Controls.Add(this.num_vida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_vida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaChars);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(640, 420);
            this.MinimumSize = new System.Drawing.Size(640, 420);
            this.Name = "Mantenedor_Personajes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Personajes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Mantenedor_Personajes_FormClosing);
            this.Load += new System.EventHandler(this.Mantenedor_Personajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCharsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaChars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_vida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_energia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_dinero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private IDataSet1 iDataSet1;
        private System.Windows.Forms.BindingSource vCharsBindingSource;
        private IDataSet1TableAdapters.vCharsTableAdapter vCharsTableAdapter;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private IDataSet1TableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.DataGridView grillaChars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.ComboBox combo_tipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txt_vida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown num_vida;
        private System.Windows.Forms.NumericUpDown num_exp;
        private System.Windows.Forms.NumericUpDown num_energia;
        private System.Windows.Forms.NumericUpDown num_dinero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown num_lvl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.BindingSource user1BindingSource;
        private IDataSet1TableAdapters.User1TableAdapter user1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}