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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuangsTradingApp
{
    public partial class MainWindow : Window
    {
        private List<Stock> stockList = new List<Stock>
        {
            new Stock { StockName = "IBM", Number = 200, MaxPrice = 4.5, MinPrice = 3.2 },
            new Stock { StockName = "Citi", Number = 120, MaxPrice = 35, MinPrice = 28 },
            new Stock { StockName = "JPMorgan", Number = 570, MaxPrice = 15, MinPrice = 8}
        };

        public MainWindow()
        {
            InitializeComponent();

            DisplaySelectedStock();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            string stockName = this.NewStockTextBox.Text;
            int numStock = int.Parse(this.NewStockNumber.Text);
            double minPrice = double.Parse(this.NewMinPrice.Text);
            double maxPrice = double.Parse(this.NewMaxPrice.Text);

            Stock newStock = new Stock(stockName, numStock, minPrice, maxPrice);

            this.StockListBox.Items.Add(newStock);
            this.ResetForm();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.ResetForm();
        }

        private void ResetForm()
        {
            this.NewStockTextBox.Text = string.Empty;
            this.NewStockNumber.Text = "0";
            this.NewMinPrice.Text = "0.0";
            this.NewMaxPrice.Text = "0.0";
        }

        private void StockListbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.DisplaySelectedStock();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            this.StockListBox.Items.Remove(this.StockListBox.SelectedItem);
            this.DisplaySelectedStock();
        }

        private void DisplaySelectedStock()
        {
            Stock selectedStock = this.StockListBox.SelectedItem as Stock;
            if (selectedStock == null)
            {
                this.DescriptionTextBlock.Text = string.Empty;
                this.StatusBarTextBlock.Text = "(No stock selected)";
            }
            else
            {
                this.DescriptionTextBlock.Text = selectedStock.Details;
                this.StatusBarTextBlock.Text = selectedStock.ToString();
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Stock selectedStock = this.StockListBox.SelectedItem as Stock;

            if (selectedStock != null)
            {
                EditStockWindow win = new EditStockWindow(selectedStock);

                win.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                win.Owner = this;

                bool? result = win.ShowDialog();

                if (result.HasValue && result == true)
                {
                    this.StockListBox.Items.Refresh();
                    this.DisplaySelectedStock();
                }

            }
        }

        private void TradeButton_Click(object sender, RoutedEventArgs e)
        {
            Stock selectedStock = this.StockListBox.SelectedItem as Stock;

            if (selectedStock != null)
            {
                TradeWindow win = new TradeWindow(selectedStock);

                win.WindowStartupLocation = WindowStartupLocation.CenterOwner;
                win.Owner = this;

                bool? result = win.ShowDialog();

                if (result.HasValue && result == true)
                {
                    this.StockListBox.Items.Refresh();
                    this.DisplaySelectedStock();
                }

            }
        }
    }
}
