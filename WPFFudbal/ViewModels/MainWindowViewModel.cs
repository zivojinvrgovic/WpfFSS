using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFFudbal.Commands;
using WPFFudbal.ServiceReference1;

namespace WPFFudbal.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        MainWindow main;

        #region Constructor
        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
            using (Service1Client wcf = new Service1Client())
            {
                IgracList = wcf.IgracList().ToList();
            }
        }
        public MainWindowViewModel(MainWindow mainOpen,vwIgrac igracEdit)
        {
            main = mainOpen;
            using (Service1Client wcf = new Service1Client())
            {
                IgracList = wcf.IgracList().ToList();
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
                OnPropertyChanged("Igrac");
            }
        }

        private List<vwIgrac> igracList;
        public List<vwIgrac> IgracList
        {

            get
            {
                return igracList;
            }
            set
            {
                igracList = value;
                OnPropertyChanged("userList");
            }
        }


        #endregion

        #region Commands
        
        //Command for adding new igrac

        private ICommand addNewIgrac;
        public ICommand AddNewIgrac
        {
            get
            {
                if (addNewIgrac == null)
                {
                    addNewIgrac = new RelayCommand(param => AddNewIgracExecute(), param => CannAddNewIgracExecute());
                }
                return addNewIgrac;
            }
           
        }

        public void AddNewIgracExecute()
        {
            try
            {
                AddIgrac add = new AddIgrac();
                add.ShowDialog();
                if((add.DataContext as AddIgracViewModel).IsUpdateIgrac == true){
                    using(Service1Client wcf=new Service1Client())
                    {
                        IgracList = wcf.IgracList().ToList();
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }
        private bool CannAddNewIgracExecute()
        {
            return true;
        }
        #endregion
    }
}
