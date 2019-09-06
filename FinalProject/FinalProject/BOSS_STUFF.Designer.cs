namespace FinalProject
{
    partial class BOSS_STUFF
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
            this.stuffsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stuffname = new System.Windows.Forms.Label();
            this.stuffprice = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.QuantityTXT = new System.Windows.Forms.TextBox();
            this.PriceTXT = new System.Windows.Forms.TextBox();
            this.NameTXT = new System.Windows.Forms.TextBox();
            this.stuffsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuffsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.category = new System.Windows.Forms.Label();
            this.CategoryTXT = new System.Windows.Forms.TextBox();
            this.btn_ADD = new System.Windows.Forms.Button();
            this.btn_DELETE = new System.Windows.Forms.Button();
            this.btn_EDIT = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.database1DataSet = new FinalProject.Database1DataSet();
            this.stuffsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.stuffsTableAdapter = new FinalProject.Database1DataSetTableAdapters.stuffsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // stuffsBindingSource
            // 
            this.stuffsBindingSource.DataMember = "stuffs";
            // 
            // stuffname
            // 
            this.stuffname.AutoSize = true;
            this.stuffname.Location = new System.Drawing.Point(649, 55);
            this.stuffname.Name = "stuffname";
            this.stuffname.Size = new System.Drawing.Size(107, 18);
            this.stuffname.TabIndex = 1;
            this.stuffname.Text = "Stuff Name:";
            this.stuffname.Click += new System.EventHandler(this.Label1_Click);
            // 
            // stuffprice
            // 
            this.stuffprice.AutoSize = true;
            this.stuffprice.Location = new System.Drawing.Point(649, 138);
            this.stuffprice.Name = "stuffprice";
            this.stuffprice.Size = new System.Drawing.Size(62, 18);
            this.stuffprice.TabIndex = 2;
            this.stuffprice.Text = "Price:";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Location = new System.Drawing.Point(649, 208);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(80, 18);
            this.Quantity.TabIndex = 3;
            this.Quantity.Text = "Quantity";
            // 
            // QuantityTXT
            // 
            this.QuantityTXT.Location = new System.Drawing.Point(765, 198);
            this.QuantityTXT.Name = "QuantityTXT";
            this.QuantityTXT.Size = new System.Drawing.Size(100, 28);
            this.QuantityTXT.TabIndex = 4;
            // 
            // PriceTXT
            // 
            this.PriceTXT.Location = new System.Drawing.Point(765, 128);
            this.PriceTXT.Name = "PriceTXT";
            this.PriceTXT.Size = new System.Drawing.Size(100, 28);
            this.PriceTXT.TabIndex = 5;
            // 
            // NameTXT
            // 
            this.NameTXT.Location = new System.Drawing.Point(765, 52);
            this.NameTXT.Name = "NameTXT";
            this.NameTXT.Size = new System.Drawing.Size(100, 28);
            this.NameTXT.TabIndex = 6;
            // 
            // stuffsBindingSource1
            // 
            this.stuffsBindingSource1.DataMember = "stuffs";
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
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.stuffsBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(556, 157);
            this.dataGridView1.TabIndex = 7;
            // 
            // stuffsBindingSource2
            // 
            this.stuffsBindingSource2.DataMember = "stuffs";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Location = new System.Drawing.Point(649, 284);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(80, 18);
            this.category.TabIndex = 8;
            this.category.Text = "Category";
            // 
            // CategoryTXT
            // 
            this.CategoryTXT.Location = new System.Drawing.Point(765, 274);
            this.CategoryTXT.Name = "CategoryTXT";
            this.CategoryTXT.Size = new System.Drawing.Size(100, 28);
            this.CategoryTXT.TabIndex = 9;
            // 
            // btn_ADD
            // 
            this.btn_ADD.Location = new System.Drawing.Point(62, 328);
            this.btn_ADD.Name = "btn_ADD";
            this.btn_ADD.Size = new System.Drawing.Size(75, 23);
            this.btn_ADD.TabIndex = 10;
            this.btn_ADD.Text = "Add";
            this.btn_ADD.UseVisualStyleBackColor = true;
            this.btn_ADD.Click += new System.EventHandler(this.Btn_ADD_Click);
            // 
            // btn_DELETE
            // 
            this.btn_DELETE.Location = new System.Drawing.Point(365, 328);
            this.btn_DELETE.Name = "btn_DELETE";
            this.btn_DELETE.Size = new System.Drawing.Size(75, 23);
            this.btn_DELETE.TabIndex = 11;
            this.btn_DELETE.Text = "Delete";
            this.btn_DELETE.UseVisualStyleBackColor = true;
            this.btn_DELETE.Click += new System.EventHandler(this.Btn_DELETE_Click);
            // 
            // btn_EDIT
            // 
            this.btn_EDIT.Location = new System.Drawing.Point(212, 328);
            this.btn_EDIT.Name = "btn_EDIT";
            this.btn_EDIT.Size = new System.Drawing.Size(75, 23);
            this.btn_EDIT.TabIndex = 12;
            this.btn_EDIT.Text = "Edit";
            this.btn_EDIT.UseVisualStyleBackColor = true;
            this.btn_EDIT.Click += new System.EventHandler(this.Btn_EDIT_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(704, 364);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(104, 43);
            this.btn_back.TabIndex = 13;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stuffsBindingSource3
            // 
            this.stuffsBindingSource3.DataMember = "stuffs";
            this.stuffsBindingSource3.DataSource = this.database1DataSet;
            // 
            // stuffsTableAdapter
            // 
            this.stuffsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "stuff_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "stuff_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "stuff_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "stuff_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn3.HeaderText = "price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "category";
            this.dataGridViewTextBoxColumn5.HeaderText = "category";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // BOSS_STUFF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_EDIT);
            this.Controls.Add(this.btn_DELETE);
            this.Controls.Add(this.btn_ADD);
            this.Controls.Add(this.CategoryTXT);
            this.Controls.Add(this.category);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameTXT);
            this.Controls.Add(this.PriceTXT);
            this.Controls.Add(this.QuantityTXT);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.stuffprice);
            this.Controls.Add(this.stuffname);
            this.Name = "BOSS_STUFF";
            this.Text = "BOSS_STUFF";
            this.Load += new System.EventHandler(this.BOSS_STUFF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stuffsBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.BindingSource stuffsBindingSource;
       
        private System.Windows.Forms.Label stuffname;
        private System.Windows.Forms.Label stuffprice;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox QuantityTXT;
        private System.Windows.Forms.TextBox PriceTXT;
        private System.Windows.Forms.TextBox NameTXT;
        
        private System.Windows.Forms.BindingSource stuffsBindingSource1;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        
        private System.Windows.Forms.BindingSource stuffsBindingSource2;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn stuffidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.TextBox CategoryTXT;
        private System.Windows.Forms.Button btn_ADD;
        private System.Windows.Forms.Button btn_DELETE;
        private System.Windows.Forms.Button btn_EDIT;
        private System.Windows.Forms.Button btn_back;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource stuffsBindingSource3;
        private Database1DataSetTableAdapters.stuffsTableAdapter stuffsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}