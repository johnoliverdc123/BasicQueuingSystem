﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingSystem
{
    public partial class QueuingForm : Form
    {
        CashierClass cashier;
        private int x;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
           
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {
            CashierWindowQueueForm cf = new CashierWindowQueueForm();
            cf.Show();

        }
    }
}
