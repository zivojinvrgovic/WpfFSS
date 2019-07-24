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
using WCFSERVICEFSS;
using WPFFudbal.ServiceReference1;
using WPFFudbal.ViewModels;

namespace WPFFudbal
{
    /// <summary>
    /// Interaction logic for AddLiga.xaml
    /// </summary>
    public partial class AddLiga : Window
    {
        public AddLiga()
        {
            InitializeComponent();
            this.DataContext = new AddLigaViewModel(this);
        }

        public AddLiga(vwLiga liga)
        {
            InitializeComponent();
            this.DataContext = new AddLigaViewModel(this, liga);
        }

        
    }
}
