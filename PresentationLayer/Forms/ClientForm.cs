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
    public partial class ClientForm : Form
    {
        private ClientService _clientService;
        bool isEditing = false;
        public ClientForm()
        {
            InitializeComponent();
            _clientService = new ClientService();
            LoadDataClients();
        }

        public void LoadDataClients()
        {
            clientsDataGridView.DataSource = _clientService.GetClients();
        }

        private void addClientButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                string name = txtName.Text;
                string dui = txtDui.Text;
                string phoneNumber = txtPhoneClient.Text;
                string address = txtAddress.Text;
                string passwordClient = txtPassword.Text;
                int id = int.Parse(clientsDataGridView.CurrentRow.Cells[0].Value.ToString());

                Client client = new Client();
                client.Name = name;
                client.Dui = dui;
                client.PhoneNumber = phoneNumber;
                client.Address = address;
                client.Id = id;
                client.Password = passwordClient;


                ClientValidation clientValidation = new ClientValidation();
                ValidationResult result = clientValidation.Validate(client);

                if (!result.IsValid)
                {
                    DisplayValidationErrors(result);
                }
                else
                {
                    _clientService.AddClient(client);
                    LoadDataClients();
                    ClearTextBoxes();
                }

                isEditing = false;
            }
            else
            {
                string name = txtName.Text;
                string dui = txtDui.Text;
                string phoneNumber = txtPhoneClient.Text;
                string address = txtAddress.Text;
                string passwordClient = txtPassword.Text;

                Client client = new Client();
                client.Name = name;
                client.Dui = dui;
                client.PhoneNumber = phoneNumber;
                client.Address = address;
                client.Password = passwordClient;

                ClientValidation clientValidation = new ClientValidation();
                ValidationResult result = clientValidation.Validate(client);

                if(!result.IsValid)
                {
                    DisplayValidationErrors(result);
                }
                else
                {
                    _clientService.AddClient(client);
                    LoadDataClients();
                    ClearTextBoxes();
                }
            }
        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count > 0)
            {
                txtName.Text = clientsDataGridView.CurrentRow.Cells[1].Value.ToString();
                txtDui.Text = clientsDataGridView.CurrentRow.Cells[2].Value.ToString();
                txtPhoneClient.Text = clientsDataGridView.CurrentRow.Cells[3].Value.ToString();
                txtAddress.Text = clientsDataGridView.CurrentRow.Cells[4].Value.ToString();
                txtPassword.Text = clientsDataGridView.CurrentRow.Cells[5].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fila para poder editar");
            }
        }

        private void btnDeteleClient_Click(object sender, EventArgs e)
        {
            if (clientsDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe seleccionar una fila para eliminar\", \"Cuidado\", MessageBoxButtons.OK, MessageBoxIcon.Warning");
            }
            else
            {
                var confirm = new DialogResult();
                confirm = MessageBox.Show("¿Estás seguro de que deseas eliminar este cliente?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    int id = int.Parse(clientsDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _clientService.DeleteClient(id);
                    LoadDataClients();
                }
            }
        }

        private void DisplayValidationErrors(ValidationResult result)
        {
            errorClient.Clear();

            foreach (var error in result.Errors)
            {
                switch (error.PropertyName)
                {
                    case nameof(Client.Name):
                        errorClient.SetError(txtName, error.ErrorMessage);
                        break;
                    case nameof(Client.Dui):
                        errorClient.SetError(txtDui, error.ErrorMessage);
                        break;
                    case nameof(Client.PhoneNumber):
                        errorClient.SetError(txtPhoneClient, error.ErrorMessage);
                        break;
                    case nameof(Client.Address):
                        errorClient.SetError(txtAddress, error.ErrorMessage);
                        break;
                    case nameof(Client.Password):
                        errorClient.SetError(txtPassword, error.ErrorMessage);
                        break;
                }
            }
        }
        //limpiar textbox
        private void ClearTextBoxes()
        {
            txtName.Text = "";
            txtDui.Text = "";
            txtPhoneClient.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
        }
    }
}
