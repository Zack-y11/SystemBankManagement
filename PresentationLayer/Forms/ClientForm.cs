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
    public partial class ClientForm : Form
    {
        private ClientService _clientService;
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
    }
}
