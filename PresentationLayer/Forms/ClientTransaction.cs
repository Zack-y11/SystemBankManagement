using BusinessLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms
{
    public partial class ClientTransaction : Form
    {
        private TransactionsServices _transactionServices;
        public ClientTransaction()
        {
            InitializeComponent();
            _transactionServices = new TransactionsServices();

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            transactionDataGridView.DataSource = _transactionServices.GetTransacctions();
            LoadDatabyAccount();
        }
        private void LoadDatabyAccount()
        {
            transactionDataGridView.DataSource = _transactionServices.GetTransacctionsById(accountTextBox.Text);
        }
    }
}
