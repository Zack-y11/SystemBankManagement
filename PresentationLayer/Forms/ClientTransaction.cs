using BusinessLayer.Services;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;
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
        private AccountService _accountService;
        public ClientTransaction()
        {
            InitializeComponent();
            _transactionServices = new TransactionsServices();
            _accountService = new AccountService();

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

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(accountTextBox.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación");
                    return;
                }

                string typeTransaction = "Deposit";
                decimal amount = decimal.Parse(txtAmount.Text);
                string date = transactionDatePicker.Text;
                string description = txtDescripcion.Text;
                string accountNumber = accountTextBox.Text;

                int accountId = _accountService.GetAccountId(accountNumber);
                if (accountId == 0)
                {
                    MessageBox.Show("Número de cuenta no encontrado.", "Error de Validación");
                    return;
                }

                _accountService.MakeTransaction(amount, accountNumber);

                Transaction transaction = new Transaction
                {
                    AccountId = accountId,
                    TypeTransaction = typeTransaction,
                    Amount = amount,
                    Date = date,
                    Description = description
                };

                TransactionValidation transactionValidation = new TransactionValidation();
                ValidationResult result = transactionValidation.Validate(transaction);
                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }

                _transactionServices.AddTransacction(transaction);
                LoadDatabyAccount();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error de Formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de completar correctamente los campos.", "Error");
            }
        }


        private void withdrawlButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || string.IsNullOrWhiteSpace(accountTextBox.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error de Validación");
                    return;
                }

                string typeTransaction = "Withdrawal";
                decimal amount;
                if (!decimal.TryParse(txtAmount.Text, out amount))
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error de Formato");
                    return;
                }

                string date = transactionDatePicker.Text;
                string description = txtDescripcion.Text;
                string accountNumber = accountTextBox.Text;

                int accountId = _accountService.GetAccountId(accountNumber);
                if (accountId == 0)
                {
                    MessageBox.Show("Número de cuenta no encontrado.", "Error de Validación");
                    return;
                }

                _accountService.MakeWithdrawal(amount, accountNumber);

                Transaction transaction = new Transaction
                {
                    AccountId = accountId,
                    TypeTransaction = typeTransaction,
                    Amount = amount,
                    Date = date,
                    Description = description
                };

                TransactionValidation transactionValidation = new TransactionValidation();
                ValidationResult result = transactionValidation.Validate(transaction);
                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                    return;
                }

                _transactionServices.AddTransacction(transaction);
                LoadDatabyAccount();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Error de Formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Asegúrese de completar correctamente los campos.", "Error");
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            errorClientTransaction.Clear();
            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Transaction.Amount):
                        errorClientTransaction.SetError(txtAmount, error.ErrorMessage);
                        break;
                    case nameof(Transaction.Date):
                        errorClientTransaction.SetError(transactionDatePicker, error.ErrorMessage);
                        break;
                    case nameof(Transaction.Description):
                        errorClientTransaction.SetError(txtDescripcion, error.ErrorMessage);
                        break;
                    case nameof(Transaction.AccountId):
                        errorClientTransaction.SetError(accountTextBox, error.ErrorMessage);
                        break;
                }
            }
        }
    }
}
