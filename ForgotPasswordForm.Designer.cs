namespace ACT_8_BACKEND
{
    partial class ForgotPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSecQ = new System.Windows.Forms.Label();
            this.txtSecAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Username :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(168, 80);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(330, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(296, 113);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 37);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSecQ
            // 
            this.lblSecQ.AutoSize = true;
            this.lblSecQ.Location = new System.Drawing.Point(162, 134);
            this.lblSecQ.Name = "lblSecQ";
            this.lblSecQ.Size = new System.Drawing.Size(0, 16);
            this.lblSecQ.TabIndex = 3;
            // 
            // txtSecAnswer
            // 
            this.txtSecAnswer.Location = new System.Drawing.Point(168, 189);
            this.txtSecAnswer.Name = "txtSecAnswer";
            this.txtSecAnswer.Size = new System.Drawing.Size(330, 22);
            this.txtSecAnswer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(22, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password :";
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(168, 256);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(330, 22);
            this.txtNewPass.TabIndex = 6;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(271, 295);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(116, 23);
            this.btnResetPass.TabIndex = 7;
            this.btnResetPass.Text = "Reset Password";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btnResetPass_Click);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(546, 418);
            this.Controls.Add(this.btnResetPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSecAnswer);
            this.Controls.Add(this.lblSecQ);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPasswordForm";
            this.Text = "ForgotPasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSecQ;
        private System.Windows.Forms.TextBox txtSecAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnResetPass;
    }
}