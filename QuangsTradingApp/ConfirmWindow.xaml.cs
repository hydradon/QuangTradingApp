using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuangsTradingApp
{
    public partial class ConfirmWindow : Window
    {
        string msg = null;
        double total = 0.0;
        Stock stockToTrade = null;
        string tradeType = null;
        int numTrade = 0;

        public ConfirmWindow(Stock stockToTrade, string tradeType, int numTrade)
        {
            InitializeComponent();
            this.stockToTrade = stockToTrade;
            this.tradeType = tradeType;
            this.numTrade = numTrade;

            this.total = (tradeType == "Buy") ? stockToTrade.MaxPrice * (double)numTrade : stockToTrade.MinPrice * (double)numTrade;

            this.msg = $"Confirm {tradeType}ing {numTrade} of {stockToTrade.StockName} at {this.total} ?";
            this.ConfirmMessage.Text = this.msg;
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            this.stockToTrade.Number = (this.tradeType == "Sell") ? this.stockToTrade.Number - this.numTrade : this.stockToTrade.Number + this.numTrade;

            this.DialogResult = true;
            this.Close();
        }
    }
}
