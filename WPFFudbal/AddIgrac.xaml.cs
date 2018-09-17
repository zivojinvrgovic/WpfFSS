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
using WPFFudbal.ViewModels;
using WPFFudbal.ServiceReference1;

namespace WPFFudbal
{
    /// <summary>
    /// Interaction logic for AddIgrac.xaml
    /// </summary>
    public partial class AddIgrac : Window
    {
        public AddIgrac()
        {
            InitializeComponent();
            this.DataContext = new AddIgracViewModel(this);
        }
        public AddIgrac(vwIgrac igracEdit)
        {
            InitializeComponent();
            this.DataContext = new AddIgracViewModel(this,igracEdit);
        }
    }
}
