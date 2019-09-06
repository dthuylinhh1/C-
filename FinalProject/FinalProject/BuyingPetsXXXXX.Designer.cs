namespace FinalProject
{
    partial class BuyingPetsXXXXX
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
            System.Windows.Forms.Label pet_priceLabel;
            this.petsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new FinalProject.Database1DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buy = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.petsTableAdapter = new FinalProject.Database1DataSetTableAdapters.petsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.tableAdapterManager = new FinalProject.Database1DataSetTableAdapters.TableAdapterManager();
            this.petsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.petsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pet_priceTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            pet_priceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // petsBindingSource
            // 
            this.petsBindingSource.DataMember = "pets";
            this.petsBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "BUY YOUR PET";
            // 
            // btn_buy
            // 
            this.btn_buy.Location = new System.Drawing.Point(452, 510);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(114, 47);
            this.btn_buy.TabIndex = 2;
            this.btn_buy.Text = "BUY";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.Btn_buy_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(1025, 549);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(157, 49);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // petsTableAdapter
            // 
            this.petsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 454);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "picture:  ";
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.petsTableAdapter = this.petsTableAdapter;
            this.tableAdapterManager.stuffsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // petsBindingSource1
            // 
            this.petsBindingSource1.DataMember = "pets";
            // 
            // petsBindingSource2
            // 
            this.petsBindingSource2.DataMember = "pets";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewImageColumn1});
            this.dataGridView1.DataSource = this.petsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(561, 220);
            this.dataGridView1.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pet_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "pet_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pet_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "pet_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pet_price";
            this.dataGridViewTextBoxColumn3.HeaderText = "pet_price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "pet_species";
            this.dataGridViewTextBoxColumn4.HeaderText = "pet_species";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "pet_breed";
            this.dataGridViewTextBoxColumn5.HeaderText = "pet_breed";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "pet_age";
            this.dataGridViewTextBoxColumn6.HeaderText = "pet_age";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "pet_gender";
            this.dataGridViewTextBoxColumn7.HeaderText = "pet_gender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn8.HeaderText = "stock";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "picture";
            this.dataGridViewImageColumn1.HeaderText = "picture";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // pet_priceLabel
            // 
            pet_priceLabel.AutoSize = true;
            pet_priceLabel.Location = new System.Drawing.Point(482, 381);
            pet_priceLabel.Name = "pet_priceLabel";
            pet_priceLabel.Size = new System.Drawing.Size(98, 18);
            pet_priceLabel.TabIndex = 8;
            pet_priceLabel.Text = "pet price:";
            // 
            // pet_priceTextBox
            // 
            this.pet_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.petsBindingSource, "pet_price", true));
            this.pet_priceTextBox.Location = new System.Drawing.Point(586, 378);
            this.pet_priceTextBox.Name = "pet_priceTextBox";
            this.pet_priceTextBox.Size = new System.Drawing.Size(100, 28);
            this.pet_priceTextBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 114);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BuyingPets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(pet_priceLabel);
            this.Controls.Add(this.pet_priceTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.label1);
            this.Name = "BuyingPets";
            this.Text = "Buying_Pets";
            this.Load += new System.EventHandler(this.BuyingPets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Button btn_back;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource petsBindingSource;
        private Database1DataSetTableAdapters.petsTableAdapter petsTableAdapter;
        
        private System.Windows.Forms.BindingSource petsBindingSource1;
       
        private System.Windows.Forms.BindingSource petsBindingSource2;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn petidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petspeciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petbreedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn petgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox pet_priceTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}