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
    public partial class EditStockWindow : Window
    {
        private Stock stockToEdit;

        public EditStockWindow(Stock stockToEdit)
        {
            InitializeComponent();

            this.stockToEdit = stockToEdit;
            this.NewStockTextBox.Text = stockToEdit.StockName;
            this.NewStockNumber.Text = stockToEdit.Number.ToString();
            this.NewMinPrice.Text = stockToEdit.MinPrice.ToString();
            this.NewMaxPrice.Text = stockToEdit.MaxPrice.ToString();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.stockToEdit.StockName = this.NewStockTextBox.Text;
            this.stockToEdit.Number = int.Parse(this.NewStockNumber.Text);
            this.stockToEdit.MinPrice = double.Parse(this.NewMinPrice.Text);
            this.stockToEdit.MaxPrice = double.Parse(this.NewMaxPrice.Text);

            this.DialogResult = true;
            this.Close();
        }
    }
}
