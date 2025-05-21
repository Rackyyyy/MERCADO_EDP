namespace ACT_8_BACKEND
{
    partial class ArchivedOrdersForm
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
            this.dataGridViewArchived = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchived)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArchived
            // 
            this.dataGridViewArchived.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArchived.Location = new System.Drawing.Point(152, 63);
            this.dataGridViewArchived.Name = "dataGridViewArchived";
            this.dataGridViewArchived.RowHeadersWidth = 51;
            this.dataGridViewArchived.RowTemplate.Height = 24;
            this.dataGridViewArchived.Size = new System.Drawing.Size(492, 265);
            this.dataGridViewArchived.TabIndex = 0;
            this.dataGridViewArchived.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewArchived_CellContentClick);
            // 
            // ArchivedOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewArchived);
            this.Name = "ArchivedOrdersForm";
            this.Text = "ArchivedOrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchived)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArchived;
    }
}