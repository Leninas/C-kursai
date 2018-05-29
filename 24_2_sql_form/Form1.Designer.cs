namespace _24_2_sql_form
{
    partial class Form1
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surenameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            this.studentsDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surenameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.resetToolStrip = new System.Windows.Forms.ToolStrip();
            this.resetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kCSDataSet = new _24_2_sql_form.KCSDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsTableAdapter = new _24_2_sql_form.KCSDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new _24_2_sql_form.KCSDataSetTableAdapters.TableAdapterManager();
            this.student_addressTableAdapter = new _24_2_sql_form.KCSDataSetTableAdapters.Student_addressTableAdapter();
            this.student_addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            surenameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).BeginInit();
            this.resetToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentsDataGridView
            // 
            this.studentsDataGridView.AutoGenerateColumns = false;
            this.studentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.studentsDataGridView.DataSource = this.studentsBindingSource;
            this.studentsDataGridView.Location = new System.Drawing.Point(12, 64);
            this.studentsDataGridView.Name = "studentsDataGridView";
            this.studentsDataGridView.RowTemplate.Height = 24;
            this.studentsDataGridView.Size = new System.Drawing.Size(545, 363);
            this.studentsDataGridView.TabIndex = 0;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(579, 67);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(662, 64);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(579, 95);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(662, 92);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // surenameLabel
            // 
            surenameLabel.AutoSize = true;
            surenameLabel.Location = new System.Drawing.Point(579, 123);
            surenameLabel.Name = "surenameLabel";
            surenameLabel.Size = new System.Drawing.Size(77, 17);
            surenameLabel.TabIndex = 5;
            surenameLabel.Text = "Surename:";
            // 
            // surenameTextBox
            // 
            this.surenameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Surename", true));
            this.surenameTextBox.Location = new System.Drawing.Point(662, 120);
            this.surenameTextBox.Name = "surenameTextBox";
            this.surenameTextBox.Size = new System.Drawing.Size(100, 22);
            this.surenameTextBox.TabIndex = 6;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(579, 151);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(53, 17);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(662, 148);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.phoneTextBox.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(579, 179);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(46, 17);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(662, 176);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 10;
            // 
            // resetToolStrip
            // 
            this.resetToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.resetToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripButton});
            this.resetToolStrip.Location = new System.Drawing.Point(0, 0);
            this.resetToolStrip.Name = "resetToolStrip";
            this.resetToolStrip.Size = new System.Drawing.Size(1056, 27);
            this.resetToolStrip.TabIndex = 11;
            this.resetToolStrip.Text = "resetToolStrip";
            // 
            // resetToolStripButton
            // 
            this.resetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.resetToolStripButton.Name = "resetToolStripButton";
            this.resetToolStripButton.Size = new System.Drawing.Size(49, 24);
            this.resetToolStripButton.Text = "Reset";
            this.resetToolStripButton.Click += new System.EventHandler(this.resetToolStripButton_Click);
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.kCSDataSet;
            // 
            // kCSDataSet
            // 
            this.kCSDataSet.DataSetName = "KCSDataSet";
            this.kCSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surename";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surename";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Student_addressTableAdapter = this.student_addressTableAdapter;
            this.tableAdapterManager.Student_marksTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.UpdateOrder = _24_2_sql_form.KCSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // student_addressTableAdapter
            // 
            this.student_addressTableAdapter.ClearBeforeFill = true;
            // 
            // student_addressBindingSource
            // 
            this.student_addressBindingSource.DataMember = "Student_address";
            this.student_addressBindingSource.DataSource = this.kCSDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.resetToolStrip);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surenameLabel);
            this.Controls.Add(this.surenameTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.studentsDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataGridView)).EndInit();
            this.resetToolStrip.ResumeLayout(false);
            this.resetToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kCSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KCSDataSet kCSDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private KCSDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private KCSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private KCSDataSetTableAdapters.Student_addressTableAdapter student_addressTableAdapter;
        private System.Windows.Forms.BindingSource student_addressBindingSource;
        private System.Windows.Forms.DataGridView studentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surenameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ToolStrip resetToolStrip;
        private System.Windows.Forms.ToolStripButton resetToolStripButton;
    }
}

