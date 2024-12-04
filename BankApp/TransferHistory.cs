using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApp
{
    public partial class TransferHistory : Form
    {
        private List<Transfer> transfersList;

        public TransferHistory()
        {
            InitializeComponent();
            transfersList = new List<Transfer>();
            Transfer t = new Transfer(1, "12345678901", "9876543210987", 1000, DateTime.Now);
            transfersList.Add(t);
            t = new Transfer(2, "12345678901", "9876543210987", 1000, DateTime.Now);
            transfersList.Add(t);
            t = new Transfer(3, "12345678901", "9876543210987", 1000, DateTime.Now);
            transfersList.Add(t);
            t = new Transfer(4, "12345678901", "9876543210987", 1000, DateTime.Now);
            transfersList.Add(t);
            TransferHistorySource.DataSource = transfersList;
            TransferHistoryDataGrid.AutoGenerateColumns = true;
            TransferHistoryDataGrid.DataSource = TransferHistorySource;
        }
    }
}
