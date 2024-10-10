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
    public partial class AccountForm : Form
    {
        private AccountService _accountService;
        private ClientService _clientService;
        public AccountForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
            LoadDataAccounts();
            typeAccountComboBox.DataSource = _accountService.GetTypes();
            typeAccountComboBox.DisplayMember = "Type";
            typeAccountComboBox.ValueMember = "AccountTypeId";
            _clientService = new ClientService();
            idClientComboBox.DataSource = _clientService.GetClients();
            idClientComboBox.DisplayMember = "Name";
            idClientComboBox.ValueMember = "ClientId";
        }

        public void LoadDataAccounts()
        {
            accountDataGridView.DataSource = _accountService.GetAccounts();
        }
    }
}
