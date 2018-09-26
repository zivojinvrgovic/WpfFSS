using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
                
                IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList().ToList());
                
            }
        }
        public MainWindowViewModel(MainWindow mainOpen,vwIgrac igracEdit)
        {
            main = mainOpen;
            using (Service1Client wcf = new Service1Client())
            {
                IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList().ToList());
                
              
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

        
        private ObservableCollection<vwIgrac> igracList;
        public ObservableCollection<vwIgrac> IgracList
        {

            get
            {
                return igracList;
            }
            set
            {
                igracList = value;
                OnPropertyChanged("IgracList");
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
                        IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList().ToList());
                        
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

        private ICommand editIgrac;
        public ICommand EditIgrac
        {
            get
            {
                if(editIgrac == null)
                {
                    editIgrac = new RelayCommand(param => EditIgracExecute(), param => CanEditIgracExecute());
                }
                return editIgrac;
            }
        }

        private void EditIgracExecute()
        {
            try
            {
                if (Igrac != null)
                {
                    AddIgrac igr = new AddIgrac(Igrac);
                    int nac = Igrac.nacionalnost;
                 
                    igr.ShowDialog();
                    if ((igr.DataContext as AddIgracViewModel).IsUpdateIgrac == false)
                    {
                        using (Service1Client wcf = new Service1Client())
                        {
                            IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList().ToList());
                        }
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private bool CanEditIgracExecute()
        {
            if(Igrac == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private ICommand deleteIgrac;
        public ICommand DeleteIgrac
        {
            get
            {
                if (deleteIgrac == null)
                {
                    deleteIgrac = new RelayCommand(param => ExecuteDeleteIgrac(), param => CanExecuteDeleteIgrac());
                }
                return deleteIgrac;
            }
            
        }

        private void ExecuteDeleteIgrac()
        {
            try
            {
                if (Igrac != null)
                {
                    using(Service1Client wcf=new Service1Client())
                    {
                        wcf.IgracBrisanje(Igrac.ID);
                        IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList().ToList());
                    }
                }
                else
                {
                    MessageBox.Show("hello");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private bool CanExecuteDeleteIgrac()
        {
            if(Igrac == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
