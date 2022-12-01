namespace LB5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliverytimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofpairsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_FWDataSet = new LB5.DB_FWDataSet();
            this.factoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factoryTableAdapter = new LB5.DB_FWDataSetTableAdapters.FactoryTableAdapter();
            this.shopTableAdapter = new LB5.DB_FWDataSetTableAdapters.ShopTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.factorynameDataGridViewTextBoxColumn,
            this.sizesDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.deliverytimeDataGridViewTextBoxColumn,
            this.numberofpairsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.shopBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.Width = 125;
            // 
            // factorynameDataGridViewTextBoxColumn
            // 
            this.factorynameDataGridViewTextBoxColumn.DataPropertyName = "Factory_name";
            this.factorynameDataGridViewTextBoxColumn.HeaderText = "Factory_name";
            this.factorynameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.factorynameDataGridViewTextBoxColumn.Name = "factorynameDataGridViewTextBoxColumn";
            this.factorynameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sizesDataGridViewTextBoxColumn
            // 
            this.sizesDataGridViewTextBoxColumn.DataPropertyName = "Sizes";
            this.sizesDataGridViewTextBoxColumn.HeaderText = "Sizes";
            this.sizesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizesDataGridViewTextBoxColumn.Name = "sizesDataGridViewTextBoxColumn";
            this.sizesDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliverytimeDataGridViewTextBoxColumn
            // 
            this.deliverytimeDataGridViewTextBoxColumn.DataPropertyName = "Delivery_time";
            this.deliverytimeDataGridViewTextBoxColumn.HeaderText = "Delivery_time";
            this.deliverytimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliverytimeDataGridViewTextBoxColumn.Name = "deliverytimeDataGridViewTextBoxColumn";
            this.deliverytimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberofpairsDataGridViewTextBoxColumn
            // 
            this.numberofpairsDataGridViewTextBoxColumn.DataPropertyName = "Number_of_pairs";
            this.numberofpairsDataGridViewTextBoxColumn.HeaderText = "Number_of_pairs";
            this.numberofpairsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberofpairsDataGridViewTextBoxColumn.Name = "numberofpairsDataGridViewTextBoxColumn";
            this.numberofpairsDataGridViewTextBoxColumn.Width = 125;
            // 
            // shopBindingSource
            // 
            this.shopBindingSource.DataMember = "Shop";
            this.shopBindingSource.DataSource = this.dB_FWDataSet;
            // 
            // dB_FWDataSet
            // 
            this.dB_FWDataSet.DataSetName = "DB_FWDataSet";
            this.dB_FWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factoryBindingSource
            // 
            this.factoryBindingSource.DataMember = "Factory";
            this.factoryBindingSource.DataSource = this.dB_FWDataSet;
            // 
            // factoryTableAdapter
            // 
            this.factoryTableAdapter.ClearBeforeFill = true;
            // 
            // shopTableAdapter
            // 
            this.shopTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 489);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_FWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DB_FWDataSet dB_FWDataSet;
        private System.Windows.Forms.BindingSource factoryBindingSource;
        private DB_FWDataSetTableAdapters.FactoryTableAdapter factoryTableAdapter;
        private System.Windows.Forms.BindingSource shopBindingSource;
        private DB_FWDataSetTableAdapters.ShopTableAdapter shopTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliverytimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofpairsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}

