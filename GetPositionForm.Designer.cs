namespace ACT_8_BACKEND
{
    partial class GetPositionForm
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
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnGetPosition = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(249, 93);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(100, 22);
            this.txtEmpID.TabIndex = 0;
            // 
            // btnGetPosition
            // 
            this.btnGetPosition.Location = new System.Drawing.Point(249, 140);
            this.btnGetPosition.Name = "btnGetPosition";
            this.btnGetPosition.Size = new System.Drawing.Size(100, 41);
            this.btnGetPosition.TabIndex = 1;
            this.btnGetPosition.Text = "Get Position";
            this.btnGetPosition.UseVisualStyleBackColor = true;
            this.btnGetPosition.Click += new System.EventHandler(this.btnGetPosition_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(249, 211);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 2;
            this.lblPosition.Text = "Position";
            // 
            // GetPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnGetPosition);
            this.Controls.Add(this.txtEmpID);
            this.Name = "GetPositionForm";
            this.Text = "GetPositionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Button btnGetPosition;
        private System.Windows.Forms.Label lblPosition;
    }
}