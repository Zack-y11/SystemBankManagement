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
    
    public partial class TransactionForm : Form
    {
        private TransactionsServices _transactionServices;
        public TransactionForm()
        {
            InitializeComponent();
            _transactionServices = new TransactionsServices();
            LoadDataTransactions();
        }
        public void LoadDataTransactions()
        {
            transactionDataGridView.DataSource = _transactionServices.GetTransacctions();
        }
    }
}
