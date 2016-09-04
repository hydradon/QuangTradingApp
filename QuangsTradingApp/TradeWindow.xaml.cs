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
    public partial class TradeWindow : Window
    {
        private Stock stockToTrade;

        public TradeWindow(Stock stockToTrade)
        {
            InitializeComponent();

            this.stockToTrade = stockToTrade;
            this.NewStockTextBox.Text = stockToTrade.StockName;
            this.NewStockNumber.Text = stockToTrade.Number.ToString();
            this.NewMinPrice.Text = stockToTrade.MinPrice.ToString();
            this.NewMaxPrice.Text = stockToTrade.MaxPrice.ToString();
        }

        private void BuySell_Click(object sender, RoutedEventArgs e)
        {
            Button buySell = e.Source as Button;
            string tradeType = buySell.Content.ToString();
            int numTrade = int.Parse(this.NumbTradeTextBox.Text);

            if (tradeType == "Sell" && numTrade > this.stockToTrade.Number)
            {
                MessageBox.Show("Insufficient stock", "Trade error");
            }
            else
            {
                ConfirmWindow confWin = new ConfirmWindow(this.stockToTrade, tradeType, numTrade);

                confWin.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                confWin.Owner = this;

                bool? result = confWin.ShowDialog();
                if (result.HasValue && result == true)
                {
                    this.DialogResult = true;
                    this.Close();
                }
            }          
        }
    }
}
