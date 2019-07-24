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
    /// Interaction logic for AddTim.xaml
    /// </summary>
    public partial class AddTim : Window
    {
        public AddTim()
        {
            InitializeComponent();
            this.DataContext = new TimViewModel(this);
        }
        
        public AddTim(vwTim editTim)
        {
            InitializeComponent();
            this.DataContext = new TimViewModel(this, editTim);
        }
    }
}
