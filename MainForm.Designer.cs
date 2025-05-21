namespace ACT_8_BACKEND
{
    partial class MainForm
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
            this.btnOpenInsertOrderForm = new System.Windows.Forms.Button();
            this.btnOpenUpdateOrderStatus = new System.Windows.Forms.Button();
            this.btnOpenOrderTotal = new System.Windows.Forms.Button();
            this.btnViewArchivedOrders = new System.Windows.Forms.Button();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenInsertOrderForm
            // 
            this.btnOpenInsertOrderForm.Location = new System.Drawing.Point(155, 63);
            this.btnOpenInsertOrderForm.Name = "btnOpenInsertOrderForm";
            this.btnOpenInsertOrderForm.Size = new System.Drawing.Size(120, 47);
            this.btnOpenInsertOrderForm.TabIndex = 0;
            this.btnOpenInsertOrderForm.Text = "Insert Order";
            this.btnOpenInsertOrderForm.UseVisualStyleBackColor = true;
            this.btnOpenInsertOrderForm.Click += new System.EventHandler(this.btnOpenInsertOrderForm_Click);
            // 
            // btnOpenUpdateOrderStatus
            // 
            this.btnOpenUpdateOrderStatus.Location = new System.Drawing.Point(291, 63);
            this.btnOpenUpdateOrderStatus.Name = "btnOpenUpdateOrderStatus";
            this.btnOpenUpdateOrderStatus.Size = new System.Drawing.Size(142, 47);
            this.btnOpenUpdateOrderStatus.TabIndex = 1;
            this.btnOpenUpdateOrderStatus.Text = "Update Order Status ";
            this.btnOpenUpdateOrderStatus.UseVisualStyleBackColor = true;
            this.btnOpenUpdateOrderStatus.Click += new System.EventHandler(this.btnOpenUpdateOrderStatus_Click);
            // 
            // btnOpenOrderTotal
            // 
            this.btnOpenOrderTotal.Location = new System.Drawing.Point(155, 124);
            this.btnOpenOrderTotal.Name = "btnOpenOrderTotal";
            this.btnOpenOrderTotal.Size = new System.Drawing.Size(120, 47);
            this.btnOpenOrderTotal.TabIndex = 2;
            this.btnOpenOrderTotal.Text = "Order Total";
            this.btnOpenOrderTotal.UseVisualStyleBackColor = true;
            this.btnOpenOrderTotal.Click += new System.EventHandler(this.btnOpenOrderTotal_Click);
            // 
            // btnViewArchivedOrders
            // 
            this.btnViewArchivedOrders.Location = new System.Drawing.Point(291, 124);
            this.btnViewArchivedOrders.Name = "btnViewArchivedOrders";
            this.btnViewArchivedOrders.Size = new System.Drawing.Size(142, 47);
            this.btnViewArchivedOrders.TabIndex = 3;
            this.btnViewArchivedOrders.Text = "Archived Orders";
            this.btnViewArchivedOrders.UseVisualStyleBackColor = true;
            this.btnViewArchivedOrders.Click += new System.EventHandler(this.btnViewArchivedOrders_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(155, 189);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(120, 47);
            this.btnMakePayment.TabIndex = 4;
            this.btnMakePayment.Text = "Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.btnViewArchivedOrders);
            this.Controls.Add(this.btnOpenOrderTotal);
            this.Controls.Add(this.btnOpenUpdateOrderStatus);
            this.Controls.Add(this.btnOpenInsertOrderForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenInsertOrderForm;
        private System.Windows.Forms.Button btnOpenUpdateOrderStatus;
        private System.Windows.Forms.Button btnOpenOrderTotal;
        private System.Windows.Forms.Button btnViewArchivedOrders;
        private System.Windows.Forms.Button btnMakePayment;
    }
}