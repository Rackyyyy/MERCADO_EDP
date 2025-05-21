using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_8_BACKEND
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenInsertOrderForm_Click(object sender, EventArgs e)
        {
            InsertOrderForm form = new InsertOrderForm();
            form.ShowDialog();
        }

        private void btnOpenUpdateOrderStatus_Click(object sender, EventArgs e)
        {
            UpdateOrderStatusForm form = new UpdateOrderStatusForm();
            form.ShowDialog();
        }

        private void btnOpenOrderTotal_Click(object sender, EventArgs e)
        {
            OrderTotalForm form = new OrderTotalForm();
            form.ShowDialog();
        }

        private void btnViewArchivedOrders_Click(object sender, EventArgs e)
        {
            ArchivedOrdersForm form = new ArchivedOrdersForm();
            form.ShowDialog();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.ShowDialog();
        }

    }
}
