namespace FinalProject
{
    partial class BOSS_PET
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.GenderTXT = new System.Windows.Forms.TextBox();
            this.database1DataSet = new FinalProject.Database1DataSet();
            this.AgeTXT = new System.Windows.Forms.TextBox();
            this.BreedTXT = new System.Windows.Forms.TextBox();
            this.SpeciesTXT = new System.Windows.Forms.TextBox();
            this.NameTXT = new System.Windows.Forms.TextBox();
            this.PriceTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.StockTXT = new System.Windows.Forms.TextBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.petsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.petidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petspeciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petbreedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.petsTableAdapter = new FinalProject.Database1DataSetTableAdapters.petsTableAdapter();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new FinalProject.Database1DataSetTableAdapters.TableAdapterManager();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_serialize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "BOSS PET";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(96, 400);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 46);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(535, 401);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 45);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(317, 400);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(74, 46);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "EDIT";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.Btn_edit_Click);
            // 
            // GenderTXT
            // 
            this.GenderTXT.Location = new System.Drawing.Point(884, 400);
            this.GenderTXT.Name = "GenderTXT";
            this.GenderTXT.Size = new System.Drawing.Size(175, 28);
            this.GenderTXT.TabIndex = 6;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AgeTXT
            // 
            this.AgeTXT.Location = new System.Drawing.Point(884, 345);
            this.AgeTXT.Name = "AgeTXT";
            this.AgeTXT.Size = new System.Drawing.Size(175, 28);
            this.AgeTXT.TabIndex = 7;
            // 
            // BreedTXT
            // 
            this.BreedTXT.Location = new System.Drawing.Point(884, 285);
            this.BreedTXT.Name = "BreedTXT";
            this.BreedTXT.Size = new System.Drawing.Size(175, 28);
            this.BreedTXT.TabIndex = 8;
            // 
            // SpeciesTXT
            // 
            this.SpeciesTXT.Location = new System.Drawing.Point(884, 213);
            this.SpeciesTXT.Name = "SpeciesTXT";
            this.SpeciesTXT.Size = new System.Drawing.Size(175, 28);
            this.SpeciesTXT.TabIndex = 9;
            // 
            // NameTXT
            // 
            this.NameTXT.Location = new System.Drawing.Point(884, 106);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(175, 28);
            this.NameTXT.TabIndex = 10;
            // 
            // PriceTXT
            // 
            this.PriceTXT.Location = new System.Drawing.Point(884, 162);
            this.PriceTXT.Name = "PriceTXT";
            this.PriceTXT.Size = new System.Drawing.Size(175, 28);
            this.PriceTXT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(804, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(795, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(795, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "age:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(795, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Breed:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(795, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Species";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(795, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(795, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(795, 523);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Picture";
            // 
            // StockTXT
            // 
            this.StockTXT.Location = new System.Drawing.Point(884, 460);
            this.StockTXT.Name = "StockTXT";
            this.StockTXT.Size = new System.Drawing.Size(175, 28);
            this.StockTXT.TabIndex = 22;
            // 
            // btn_upload
            // 
            this.btn_upload.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "picture", true));
            this.btn_upload.Location = new System.Drawing.Point(950, 518);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 23;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.Btn_upload_Click);
            // 
            // petsBindingSource
            // 
            this.petsBindingSource.DataMember = "pets";
            this.petsBindingSource.DataSource = this.database1DataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.petidDataGridViewTextBoxColumn,
            this.petnameDataGridViewTextBoxColumn,
            this.petpriceDataGridViewTextBoxColumn,
            this.petspeciesDataGridViewTextBoxColumn,
            this.petbreedDataGridViewTextBoxColumn,
            this.petageDataGridViewTextBoxColumn,
            this.petgenderDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.petsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(639, 229);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick_1);
            // 
            // petidDataGridViewTextBoxColumn
            // 
            this.petidDataGridViewTextBoxColumn.DataPropertyName = "pet_id";
            this.petidDataGridViewTextBoxColumn.HeaderText = "pet_id";
            this.petidDataGridViewTextBoxColumn.Name = "petidDataGridViewTextBoxColumn";
            this.petidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // petnameDataGridViewTextBoxColumn
            // 
            this.petnameDataGridViewTextBoxColumn.DataPropertyName = "pet_name";
            this.petnameDataGridViewTextBoxColumn.HeaderText = "pet_name";
            this.petnameDataGridViewTextBoxColumn.Name = "petnameDataGridViewTextBoxColumn";
            // 
            // petpriceDataGridViewTextBoxColumn
            // 
            this.petpriceDataGridViewTextBoxColumn.DataPropertyName = "pet_price";
            this.petpriceDataGridViewTextBoxColumn.HeaderText = "pet_price";
            this.petpriceDataGridViewTextBoxColumn.Name = "petpriceDataGridViewTextBoxColumn";
            // 
            // petspeciesDataGridViewTextBoxColumn
            // 
            this.petspeciesDataGridViewTextBoxColumn.DataPropertyName = "pet_species";
            this.petspeciesDataGridViewTextBoxColumn.HeaderText = "pet_species";
            this.petspeciesDataGridViewTextBoxColumn.Name = "petspeciesDataGridViewTextBoxColumn";
            // 
            // petbreedDataGridViewTextBoxColumn
            // 
            this.petbreedDataGridViewTextBoxColumn.DataPropertyName = "pet_breed";
            this.petbreedDataGridViewTextBoxColumn.HeaderText = "pet_breed";
            this.petbreedDataGridViewTextBoxColumn.Name = "petbreedDataGridViewTextBoxColumn";
            // 
            // petageDataGridViewTextBoxColumn
            // 
            this.petageDataGridViewTextBoxColumn.DataPropertyName = "pet_age";
            this.petageDataGridViewTextBoxColumn.HeaderText = "pet_age";
            this.petageDataGridViewTextBoxColumn.Name = "petageDataGridViewTextBoxColumn";
            // 
            // petgenderDataGridViewTextBoxColumn
            // 
            this.petgenderDataGridViewTextBoxColumn.DataPropertyName = "pet_gender";
            this.petgenderDataGridViewTextBoxColumn.HeaderText = "pet_gender";
            this.petgenderDataGridViewTextBoxColumn.Name = "petgenderDataGridViewTextBoxColumn";
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "picture";
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            // 
            // petsTableAdapter
            // 
            this.petsTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.petsTableAdapter = this.petsTableAdapter;
            this.tableAdapterManager.stuffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(696, 588);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(254, 50);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_serialize
            // 
            this.btn_serialize.Location = new System.Drawing.Point(315, 534);
            this.btn_serialize.Name = "btn_serialize";
            this.btn_serialize.Size = new System.Drawing.Size(124, 45);
            this.btn_serialize.TabIndex = 28;
            this.btn_serialize.Text = "Serialize";
            this.btn_serialize.UseVisualStyleBackColor = true;
            this.btn_serialize.Click += new System.EventHandler(this.Btn_serialize_Click);
            // 
            // BOSS_PET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 664);
            this.Controls.Add(this.btn_serialize);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.StockTXT);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PriceTXT);
            this.Controls.Add(this.NameTXT);
            this.Controls.Add(this.SpeciesTXT);
            this.Controls.Add(this.BreedTXT);
            this.Controls.Add(this.AgeTXT);
            this.Controls.Add(this.GenderTXT);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Name = "BOSS_PET";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.BOSS_PET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox GenderTXT;
        private System.Windows.Forms.TextBox AgeTXT;
        private System.Windows.Forms.TextBox BreedTXT;
        private System.Windows.Forms.TextBox SpeciesTXT;
        private System.Windows.Forms.TextBox NameTXT;
        private System.Windows.Forms.TextBox PriceTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox StockTXT;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource petsBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSetTableAdapters.petsTableAdapter petsTableAdapter;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn petidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petspeciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petbreedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_serialize;
    }
}