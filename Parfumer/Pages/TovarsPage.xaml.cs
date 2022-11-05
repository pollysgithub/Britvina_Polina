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

namespace Parfumer.Pages
{
    /// <summary>
    /// Логика взаимодействия для TovarsPage.xaml
    /// </summary>
    public partial class TovarsPage : Page
    {
        public TovarsPage()
        {
            InitializeComponent();
            ComboType.SelectedItem = 0;
            var currentTours = ShopParfumEntities.GetContext().Tovars.ToList();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
