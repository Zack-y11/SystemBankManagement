﻿using BusinessLayer.Services;
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
        public AccountForm()
        {
            InitializeComponent();
            _accountService = new AccountService();
            LoadDataAccounts();
            
        }

        public void LoadDataAccounts()
        {
            cuentasDataGridView.DataSource = _accountService.GetAccounts();
        }
    }
}
