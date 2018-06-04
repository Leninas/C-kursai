namespace v1__Islaikymo_indeksavimas
{
    partial class FormVKI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vKIDataSet = new v1__Islaikymo_indeksavimas.VKIDataSet();
            this.vKITableAdapter = new v1__Islaikymo_indeksavimas.VKIDataSetTableAdapters.VKITableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.dataNuoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataIkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indeksasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataNuoDataGridViewTextBoxColumn,
            this.dataIkiDataGridViewTextBoxColumn,
            this.indeksasDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vKIBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(642, 480);
            this.dataGridView1.TabIndex = 0;
            // 
            // vKIBindingSource
            // 
            this.vKIBindingSource.DataMember = "VKI";
            this.vKIBindingSource.DataSource = this.vKIDataSet;
            // 
            // vKIDataSet
            // 
            this.vKIDataSet.DataSetName = "VKIDataSet";
            this.vKIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vKITableAdapter
            // 
            this.vKITableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vartotojų kainų indeksų dydžiai, taikomi priteisto materialinio išlaikymo indeksa" +
    "vimui: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataNuoDataGridViewTextBoxColumn
            // 
            this.dataNuoDataGridViewTextBoxColumn.DataPropertyName = "DataNuo";
            this.dataNuoDataGridViewTextBoxColumn.HeaderText = "Indeksas taikomas nuo";
            this.dataNuoDataGridViewTextBoxColumn.Name = "dataNuoDataGridViewTextBoxColumn";
            this.dataNuoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataIkiDataGridViewTextBoxColumn
            // 
            this.dataIkiDataGridViewTextBoxColumn.DataPropertyName = "DataIki";
            this.dataIkiDataGridViewTextBoxColumn.HeaderText = "Indeksas taikomas iki";
            this.dataIkiDataGridViewTextBoxColumn.Name = "dataIkiDataGridViewTextBoxColumn";
            this.dataIkiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // indeksasDataGridViewTextBoxColumn
            // 
            this.indeksasDataGridViewTextBoxColumn.DataPropertyName = "Indeksas";
            this.indeksasDataGridViewTextBoxColumn.HeaderText = "Indekso dydis";
            this.indeksasDataGridViewTextBoxColumn.Name = "indeksasDataGridViewTextBoxColumn";
            this.indeksasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormVKI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormVKI";
            this.Text = "FormVKI";
            this.Load += new System.EventHandler(this.FormVKI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vKIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VKIDataSet vKIDataSet;
        private System.Windows.Forms.BindingSource vKIBindingSource;
        private VKIDataSetTableAdapters.VKITableAdapter vKITableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNuoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataIkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeksasDataGridViewTextBoxColumn;
    }
}