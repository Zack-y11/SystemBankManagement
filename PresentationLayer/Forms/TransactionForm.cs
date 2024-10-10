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

    public partial class TransactionForm : Form
    {

        private TransactionsServices _transactionServices;
        bool isEditing = false;
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

        private void updateButton_Click(object sender, EventArgs e)
        {

            if (transactionDataGridView.CurrentRow == null)
            {
                MessageBox.Show("No hay ninguna transacción seleccionada.");
                return;
            }

            isEditing = true;

            // Asignar valores desde el DataGridView
            accountNumberTextBox.Text = transactionDataGridView.CurrentRow.Cells["AccountId"].Value.ToString();
            amountTextBox.Text = transactionDataGridView.CurrentRow.Cells["Amount"].Value.ToString();
            dateTransaction.Text = transactionDataGridView.CurrentRow.Cells["DateTransaction"].Value.ToString();
            descriptionTextBox.Text = transactionDataGridView.CurrentRow.Cells["Description"].Value.ToString();

            string transactionId = transactionDataGridView.CurrentRow.Cells["TransactionId"].Value.ToString();

            Transaction transaction = new Transaction()
            {
                AccountId = int.Parse(accountNumberTextBox.Text),
                Amount = decimal.Parse(amountTextBox.Text),
                Date = dateTransaction.Text,
                Description = descriptionTextBox.Text,
                TransactionId = int.Parse(transactionId)
            };

            try
            {
                _transactionServices.UpdateTransacction(transaction);
                LoadDataTransactions();
                MessageBox.Show("Transacción actualizada con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar la transacción: {ex.Message}");
            }
        }
        private void transactionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Asegurarse de que no es el encabezado
            {
                isEditing = true;
                accountNumberTextBox.Text = transactionDataGridView.Rows[e.RowIndex].Cells["AccountId"].Value.ToString();
                amountTextBox.Text = transactionDataGridView.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                dateTransaction.Text = transactionDataGridView.Rows[e.RowIndex].Cells["DateTransaction"].Value.ToString();
                descriptionTextBox.Text = transactionDataGridView.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (transactionDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Está seguro que desea eliminar el dato?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(transactionDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _transactionServices.DeleteTransacction(id);
                    LoadDataTransactions();
                }
            }
        }
    }
}
