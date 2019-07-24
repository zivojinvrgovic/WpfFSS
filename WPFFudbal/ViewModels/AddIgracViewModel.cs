using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WCFSERVICEFSS;
using WPFFudbal.Commands;
using WPFFudbal.ServiceReference1;

namespace WPFFudbal.ViewModels
{
    class AddIgracViewModel:ViewModelBase
    {
        AddIgrac add;

        #region Constructor

        public AddIgracViewModel(AddIgrac add)
        {
            this.add = add;
            igrac = new vwIgrac();
            using (Service1Client wcf=new Service1Client())
            {
                NacionalnostList = new ObservableCollection<vwNacionalnost>(wcf.NacionalnostList().ToList());
                TimList = new ObservableCollection<vwTim>(wcf.TimList().ToList());
            }
        }

        public AddIgracViewModel(AddIgrac add,vwIgrac igracEdit)
        {
            this.add = add;
            igrac = igracEdit;
            using(Service1Client wcf=new Service1Client())
            {
                NacionalnostList = new ObservableCollection<vwNacionalnost>(wcf.NacionalnostList().ToList());
                TimList = new ObservableCollection<vwTim>(wcf.TimList().ToList());
            }

        }
        #endregion

        #region Properties

        private vwIgrac igrac;
        public vwIgrac Igrac
        {
            get
            {
                return igrac;
            }
            set
            {
                igrac = value;
            }
        }

        private vwTim tim;
        public vwTim Tim
        {
            get
            {
                return tim;
            }
            set
            {
                tim = value;
            }
        }

        private bool isUpdateIgrac;
        public bool IsUpdateIgrac
        {
            get
            {
                return isUpdateIgrac;
            }
            set
            {
                isUpdateIgrac = value;
            }
        }

        private vwNacionalnost nacionalnost;
        public vwNacionalnost Nacionalnost
        {
            get
            {
                return nacionalnost;
            }
            set
            {
                nacionalnost = value;
            }
        }
        private ObservableCollection<vwTim> timList;
        public ObservableCollection<vwTim> TimList
        {
            get
            {
                return timList;
            }
            set
            {
                timList = value;
                         
            }
        }

        private ObservableCollection<vwNacionalnost> nacionalnostList;
        public ObservableCollection<vwNacionalnost> NacionalnostList
        {
            get
            {
                return nacionalnostList;
            }
            set
            {
                nacionalnostList = value;
            }
        }

        public bool IsUpdateUser { get; internal set; }
        #endregion

        #region Commandes

        private ICommand save;
        public ICommand Save
        {
            get
            {
                if (save == null)
                {
                    save = new RelayCommand(param => SaveExecute(), param => CanSaveExecute());

                }
                return save;
            }
        }

        private void SaveExecute()
        {
            try
            {
                using (Service1Client wcf=new Service1Client())
                {
                    Igrac.tim = Tim.ID;
                    Igrac.nacionalnost = Nacionalnost.ID;
                    wcf.IgracAdd(Igrac);
                    isUpdateIgrac = true;
                    add.Close();
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private bool CanSaveExecute()
        {
            if (String.IsNullOrEmpty(igrac.ime) || String.IsNullOrEmpty(igrac.prezime))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        //public void OnComboBoxLoad(object sender, RoutedEventArgs e)
        //{
        //    //store current selcted index in variable
        //    int tempIndex = ((ComboBox)sender).SelectedIndex;

        //    //// ... Make the your desire item selected.
        //    ((ComboBox)sender).SelectedIndex = -1;
        //    ((ComboBox)sender).SelectedIndex = tempIndex;
        //}

        //public void ComboBox_Loaded(object sender, RoutedEventArgs e)
        //{
        //    // ... A List.
        //    List<string> data = new List<string>();
        //    data.Add("Book");
        //    data.Add("Computer");
        //    data.Add("Chair");
        //    data.Add("Mug");

        //    // ... Get the ComboBox reference.
        //    var comboBox = sender as ComboBox;

        //    // ... Assign the ItemsSource to the List.
        //    comboBox.ItemsSource = data;

        //    // ... Make the first item selected.
        //    comboBox.SelectedIndex = 0;
        //}

        //public void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    // ... Get the ComboBox.
        //    var comboBox = sender as ComboBox;

        //    // ... Set SelectedItem as Window Title.
        //    string value = comboBox.SelectedItem as string;
        //    //this.Title = "Selected: " + value;
        //}
    }
}
