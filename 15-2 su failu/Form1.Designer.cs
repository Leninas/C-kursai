namespace _15_2_su_failu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atidarytiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iseitiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.iseitiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atidarytiToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // atidarytiToolStripMenuItem
            // 
            this.atidarytiToolStripMenuItem.Name = "atidarytiToolStripMenuItem";
            this.atidarytiToolStripMenuItem.Size = new System.Drawing.Size(141, 26);
            this.atidarytiToolStripMenuItem.Text = "Atidaryti";
            this.atidarytiToolStripMenuItem.Click += new System.EventHandler(this.atidarytiToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // iseitiToolStripMenuItem
            // 
            this.iseitiToolStripMenuItem.Name = "iseitiToolStripMenuItem";
            this.iseitiToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.iseitiToolStripMenuItem.Text = "Iseiti";
            this.iseitiToolStripMenuItem.Click += new System.EventHandler(this.iseitiToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(371, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Auto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atidarytiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iseitiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
    }
}

