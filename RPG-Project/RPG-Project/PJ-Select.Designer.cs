namespace RPG_Project
{
    partial class PJ_Select
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PJ_Select));
            this.btn_crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pic_personaje = new System.Windows.Forms.PictureBox();
            this.iDataSet1 = new RPG_Project.IDataSet1();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterTableAdapter = new RPG_Project.IDataSet1TableAdapters.CharacterTableAdapter();
            this.tableAdapterManager = new RPG_Project.IDataSet1TableAdapters.TableAdapterManager();
            this.typeTableAdapter = new RPG_Project.IDataSet1TableAdapters.TypeTableAdapter();
            this.typeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new RPG_Project.IDataSet1TableAdapters.ItemsTableAdapter();
            this.typeBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.combo_tipo = new System.Windows.Forms.ComboBox();
            this.typeBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._RPG_ProjectDataSet = new RPG_Project._RPG_ProjectDataSet();
            this.typeTableAdapter2 = new RPG_Project._RPG_ProjectDataSetTableAdapters.TypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._RPG_ProjectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.LightCoral;
            this.btn_crear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_crear.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear.ForeColor = System.Drawing.Color.Beige;
            this.btn_crear.Location = new System.Drawing.Point(12, 247);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(240, 47);
            this.btn_crear.TabIndex = 3;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del personaje";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.Firebrick;
            this.txt_nombre.ForeColor = System.Drawing.Color.Gold;
            this.txt_nombre.Location = new System.Drawing.Point(12, 51);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ShortcutsEnabled = false;
            this.txt_nombre.Size = new System.Drawing.Size(149, 20);
            this.txt_nombre.TabIndex = 0;
            // 
            // pic_personaje
            // 
            this.pic_personaje.Image = global::RPG_Project.Properties.Resources.Warrior;
            this.pic_personaje.Location = new System.Drawing.Point(12, 117);
            this.pic_personaje.Name = "pic_personaje";
            this.pic_personaje.Size = new System.Drawing.Size(240, 124);
            this.pic_personaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_personaje.TabIndex = 6;
            this.pic_personaje.TabStop = false;
            // 
            // iDataSet1
            // 
            this.iDataSet1.DataSetName = "IDataSet1";
            this.iDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataMember = "Character";
            this.characterBindingSource.DataSource = this.iDataSet1;
            // 
            // characterTableAdapter
            // 
            this.characterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AproxLevelTableAdapter = null;
            this.tableAdapterManager.AttackCharacterTableAdapter = null;
            this.tableAdapterManager.AttackTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Block_GMTableAdapter = null;
            this.tableAdapterManager.Block_UserTableAdapter = null;
            this.tableAdapterManager.CharacterTableAdapter = this.characterTableAdapter;
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
            // typeBindingSource
            // 
            this.typeBindingSource.DataMember = "Type";
            this.typeBindingSource.DataSource = this.iDataSet1;
            // 
            // typeBindingSource1
            // 
            this.typeBindingSource1.DataMember = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo de personaje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 24F);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(141, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Detalles";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightCoral;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Beige;
            this.button2.Location = new System.Drawing.Point(167, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.iDataSet1;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // typeBindingSource2
            // 
            this.typeBindingSource2.DataMember = "Type";
            this.typeBindingSource2.DataSource = this.iDataSet1;
            // 
            // combo_tipo
            // 
            this.combo_tipo.BackColor = System.Drawing.Color.Firebrick;
            this.combo_tipo.DataSource = this.typeBindingSource3;
            this.combo_tipo.DisplayMember = "type_name";
            this.combo_tipo.ForeColor = System.Drawing.Color.Gold;
            this.combo_tipo.FormattingEnabled = true;
            this.combo_tipo.Location = new System.Drawing.Point(12, 90);
            this.combo_tipo.Name = "combo_tipo";
            this.combo_tipo.Size = new System.Drawing.Size(149, 21);
            this.combo_tipo.TabIndex = 1;
            this.combo_tipo.ValueMember = "id_type";
            this.combo_tipo.SelectedIndexChanged += new System.EventHandler(this.combo_tipo_SelectedIndexChanged);
            // 
            // typeBindingSource3
            // 
            this.typeBindingSource3.DataMember = "Type";
            this.typeBindingSource3.DataSource = this._RPG_ProjectDataSet;
            // 
            // _RPG_ProjectDataSet
            // 
            this._RPG_ProjectDataSet.DataSetName = "_RPG_ProjectDataSet";
            this._RPG_ProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typeTableAdapter2
            // 
            this.typeTableAdapter2.ClearBeforeFill = true;
            // 
            // PJ_Select
            // 
            this.AcceptButton = this.btn_crear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(265, 303);
            this.Controls.Add(this.combo_tipo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pic_personaje);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_crear);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(281, 342);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(281, 342);
            this.Name = "PJ_Select";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selección de Personaje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PJ_Select_FormClosing);
            this.Load += new System.EventHandler(this.PJ_Select_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_personaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._RPG_ProjectDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pic_personaje;
        private IDataSet1 iDataSet1;
        private System.Windows.Forms.BindingSource characterBindingSource;
        private IDataSet1TableAdapters.CharacterTableAdapter characterTableAdapter;
        private IDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private IDataSet1TableAdapters.TypeTableAdapter typeTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource typeBindingSource1;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private IDataSet1TableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.BindingSource typeBindingSource2;
        private System.Windows.Forms.ComboBox combo_tipo;
        private _RPG_ProjectDataSet _RPG_ProjectDataSet;
        private System.Windows.Forms.BindingSource typeBindingSource3;
        private _RPG_ProjectDataSetTableAdapters.TypeTableAdapter typeTableAdapter2;

    }
}