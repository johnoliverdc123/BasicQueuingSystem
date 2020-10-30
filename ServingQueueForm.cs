using System;
using System.Collections;
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
    public partial class ServingQueueForm : Form
    {
        CashierClass cashier;
        public ServingQueueForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
        }

        private void ServingQueueForm_Load(object sender, EventArgs e)
        {
            CashierClass.CashierQueue.Contains(CashierClass.getNumberInQueue);
        }
    }
}
