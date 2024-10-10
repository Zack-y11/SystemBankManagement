using BusinessLayer.Services;
using CommonLayer.Entities;
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
        bool isEditing = false;
        public AccountForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
            LoadDataAccounts();
            typeAccountComboBox.DataSource = _accountService.GetTypes();
            typeAccountComboBox.DisplayMember = "Type";
            typeAccountComboBox.ValueMember = "AccountTypeId";

            idClientComboBox.DataSource = _accountService.GetAllClients();
            idClientComboBox.DisplayMember = "Name";
            idClientComboBox.ValueMember = "ClientId";

        }
        public void LoadDataAccounts()
        {
            accountDataGridView.DataSource = _accountService.GetAccounts();
        }

        private void addAccountButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                string accountNumber = txtNumberAccount.Text;
                decimal saldo = decimal.Parse(txtSaldoAccount.Text);
                string openDateAccount = txtDateAccount.Text;
                int accountTypeId = (int)typeAccountComboBox.SelectedValue;
                int clientId = (int)idClientComboBox.SelectedValue;
                int accountId = int.Parse(accountDataGridView.CurrentRow.Cells[0].Value.ToString());

                Account account = new Account
                {
                    AccountId = accountId,
                    AccountNumber = accountNumber,
                    Saldo = saldo,
                    OpenDateAccount = openDateAccount,
                    AccountTypeId = accountTypeId,
                    ClientId = clientId
                };
                _accountService.UpdateAccount(account);
                LoadDataAccounts();
                isEditing = false;
            }
            else
            {
                int clientId = (int)idClientComboBox.SelectedValue;
                Account account = new Account
                {
                    
                    AccountNumber = txtNumberAccount.Text,
                    Saldo = decimal.Parse(txtSaldoAccount.Text),
                    OpenDateAccount = txtDateAccount.Text,
                    AccountTypeId = (int)typeAccountComboBox.SelectedValue,
                    ClientId = clientId
                };
                _accountService.AddAccount(account);
                LoadDataAccounts();
            }
        }


        private void updateAccountButton_Click(object sender, EventArgs e)
        {
            if (accountDataGridView.SelectedRows.Count > 0)
            {
                isEditing = true;
                txtNumberAccount.Text = accountDataGridView.CurrentRow.Cells[1].Value.ToString();
                txtSaldoAccount.Text = accountDataGridView.CurrentRow.Cells[2].Value.ToString();
                txtDateAccount.Text = accountDataGridView.CurrentRow.Cells[3].Value.ToString();
                int accountTypeId = (int)typeAccountComboBox.SelectedValue;
                int clientId = (int)idClientComboBox.SelectedValue;
                //typeAccountComboBox.SelectedValue = accountDataGridView.CurrentRow.Cells[4].Value;
                //idClientComboBox.SelectedValue = accountDataGridView.CurrentRow.Cells[5].Value;


            }
            else
            {
                MessageBox.Show("Selecciona una fila para editar");
            }
        }

        private void deleteAccountButton_Click(object sender, EventArgs e)
        {
            if (accountDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var delete = new DialogResult();
                delete = MessageBox.Show("¿Estás seguro de que deseas eliminar esta cuenta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    int id = int.Parse(accountDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _accountService.DeleteAccount(id);
                    LoadDataAccounts();
                }
            
            }

        }
    }
}
