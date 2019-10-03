using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WCFSERVICEFSS;
using WPFFudbal.Commands;
using WPFFudbal.ServiceReference1;

namespace WPFFudbal.ViewModels
{
    class MainWindowViewModel:ViewModelBase
    {
        MainWindow main;

        #region Constructor
        public MainWindowViewModel(MainWindow mainOpen)
        {
            main = mainOpen;
            using (Service1Client wcf = new Service1Client())
            {
                IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList());
                TimList = new ObservableCollection<vwTim>(wcf.TimList());
                LigaList = new ObservableCollection<vwLiga>(wcf.LigaList());
                
            }
        }
        public MainWindowViewModel(MainWindow mainOpen,vwIgrac igracEdit)
        {
            main = mainOpen;
            using (Service1Client wcf = new Service1Client())
            {
                IgracList = new ObservableCollection<vwIgrac>(wcf.IgracList().ToList());
                TimList = new ObservableCollection<vwTim>(wcf.TimList().ToList());
                LigaList = new ObservableCollection<vwLiga>(wcf.LigaList().ToList());

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
                OnPropertyChanged("Tim");
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
                OnPropertyChanged("TimList");
            }
        }

        private vwLiga liga;
        public vwLiga Liga
        {
            get
            {
                return liga;
            }
            set
            {
                liga = value;
                OnPropertyChanged("Liga");
            }
        }

        private ObservableCollection<vwLiga> ligaList;
        public ObservableCollection<vwLiga> LigaList
        {
            get
            {
                return ligaList;
            }
            set
            {
                ligaList = value;
                OnPropertyChanged("LigaList");
            }
        }

        private Visibility viewTim = Visibility.Collapsed;
        public Visibility ViewTim
        {
            get
            {
                return viewTim;
            }
            set
            {
                viewTim = value;
                OnPropertyChanged("ViewTim");
            }
        }

        private Visibility viewIgrac = Visibility.Visible;
        public Visibility ViewIgrac
        {
            get
            {
                return viewIgrac;
            }
            set
            {
                viewIgrac = value;
                OnPropertyChanged("ViewIgrac");
            }
        }

        private Visibility viewLiga = Visibility.Collapsed;
        public Visibility ViewLiga
        {
            get
            {
                return viewLiga;
            }
            set
            {
                viewLiga = value;
                OnPropertyChanged("ViewLiga");
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

        private ICommand addTim;
        public ICommand AddTim
        {
            get
            {
                if(addTim == null)
                {
                    addTim = new RelayCommand(param => ExecuteAddTim(), param => CanExecuteAddTim());
                }
                return addTim;
            }
        }

        private void ExecuteAddTim()
        {
            try
            {
                AddTim tim = new AddTim();
                tim.ShowDialog();
                using(Service1Client wcf = new Service1Client())
                {
                    TimList = new ObservableCollection<vwTim>(wcf.TimList().ToList());
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool CanExecuteAddTim()
        {
            return true;
        }

        private ICommand addLiga;
        public ICommand AddLiga
        {
            get
            {
                if (addLiga == null)
                {
                    addLiga = new RelayCommand(param => ExecuteAddLiga(), param => CanExecuteAddLiga());
                }
                return addLiga;
            }
        }

        private void ExecuteAddLiga()
        {
            try
            {
                AddLiga liga = new AddLiga();
                liga.ShowDialog();
                using(Service1Client wcf = new Service1Client())
                {
                    LigaList = new ObservableCollection<vwLiga>(wcf.LigaList().ToList());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanExecuteAddLiga()
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
                    int tim = igrac.tim;
                    igr.ShowDialog();
                    if ((igr.DataContext as AddIgracViewModel).IsUpdateIgrac == true)
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

        private ICommand editTim;
        public ICommand EditTim
        {
            get
            {
                if (editTim == null)
                {
                    editTim = new RelayCommand(param => ExecuteEditTim(), param => CanExecuteEditTim());
                }
                return editTim;
            }
        }

        private void ExecuteEditTim()
        {
            try
            {
                AddTim tim = new AddTim(Tim);
                int liga = Tim.liga;
                tim.ShowDialog();
                if((tim.DataContext as TimViewModel).IsUpdateTim == true)
                {
                    using(Service1Client wcf = new Service1Client())
                    {
                        TimList = new ObservableCollection<vwTim>(wcf.TimList().ToList());
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private bool CanExecuteEditTim()
        {
            if (Tim == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private ICommand editLiga;
        public ICommand EditLiga
        {
            get
            {
                if(editLiga == null)
                {
                    editLiga = new RelayCommand(param => ExecuteEditLiga(), param => CanExecuteEditLiga());
                }
                return editLiga;
            }
        }

        private void ExecuteEditLiga()
        {
            try
            {
                AddLiga addLiga = new AddLiga(Liga);
                addLiga.ShowDialog();
                if((addLiga.DataContext as AddLigaViewModel).IsUpdateLiga == true)
                {
                    using(Service1Client wcf = new Service1Client())
                    {
                        LigaList = new ObservableCollection<vwLiga>(wcf.LigaList().ToList());
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private bool CanExecuteEditLiga()
        {
            if(liga == null)
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

        private ICommand deleteTim;
        public ICommand DeleteTim
        {
            get
            {
                if(deleteTim == null)
                {
                    deleteTim = new RelayCommand(param => ExecuteDeleteTim(), param => CanExecuteDeleteTim());
                }
                return deleteTim;
            }
        }

        private void ExecuteDeleteTim()
        {
            try
            {
                using(Service1Client wcf = new Service1Client())
                {
                    wcf.TimBrisanje(tim.ID);
                    TimList = new ObservableCollection<vwTim>(wcf.TimList().ToList());
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private bool CanExecuteDeleteTim()
        {
            return true;
        }

        private ICommand deleteLiga;
        public ICommand DeleteLiga
        {
            get
            {
                if(deleteLiga == null)
                {
                    deleteLiga = new RelayCommand(param => ExecuteDeleteLiga(), param => CanExecuteDeleteLiga());
                }
                return deleteLiga;
            }
        }

        private void ExecuteDeleteLiga()
        {
            try
            {
                using(Service1Client wcf = new Service1Client())
                {
                    wcf.LigaBrisanje(liga.ID);

                    LigaList = new ObservableCollection<vwLiga>(wcf.LigaList().ToList());
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.StackTrace.ToString());
            }
        }

        private bool CanExecuteDeleteLiga()
        {
            if (Liga != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private ICommand manageIgrac;
        public ICommand ManageIgrac
        {
            get
            {
                if(manageIgrac == null)
                {
                    manageIgrac = new RelayCommand(param => ExecuteManageIgrac(), param => CanExecuteManageIgrac());
                }
                return manageIgrac;
            }
        }

        private void ExecuteManageIgrac()
        {
            try
            {
                ViewTim = Visibility.Collapsed;
                ViewLiga = Visibility.Collapsed;
                ViewIgrac = Visibility.Visible;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanExecuteManageIgrac()
        {
            return true;
        }

        private ICommand manageTim;
        public ICommand ManageTim
        {
            get
            {
                if(manageTim == null)
                {
                    manageTim = new RelayCommand(param => ExecuteManageTim(), param => CanExecuteManageTim());
                   
                }
                return manageTim;
            }
        }

        private void ExecuteManageTim()
        {
            try
            {

                ViewIgrac = Visibility.Collapsed;
                ViewLiga = Visibility.Collapsed;
                ViewTim = Visibility.Visible;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanExecuteManageTim()
        {
            return true;
        }

        private ICommand manageLiga;
        public ICommand ManageLiga
        {
            get
            {
                if (manageLiga == null)
                {
                    manageLiga = new RelayCommand(param => ExecuteManageLiga(), param => CanExecuteManageLiga());

                }
                return manageLiga;
            }
          
        }

        private void ExecuteManageLiga()
        {
            try
            {

                ViewIgrac = Visibility.Collapsed;
                ViewLiga = Visibility.Collapsed;
                ViewLiga = Visibility.Visible;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanExecuteManageLiga()
        {
            return true;
        }

        private ICommand swapColumns;
        public ICommand SwapColumns
        {
            get
            {
                if(swapColumns == null)
                {
                    swapColumns = new RelayCommand(param => ExecuteSwapCoumns(), param => CanExecuteSwapColumns());
                }
                return swapColumns;

            }
        }

        private void ExecuteSwapCoumns()
        {
            //DataGridViewColumnCollection columnCollection = main.DataGridIgrac.Columns;

            //DataGridViewColumnCollection firstVisibleColumn =
            //    columnCollection.GetFirstColumn(DataGridViewElementStates.Visible);

            //DataGridViewColumnCollection columnCollection = dataGridView.Columns;

            //DataGridViewColumn firstVisibleColumn =
            //    columnCollection.GetFirstColumn(DataGridViewElementStates.Visible);
            //DataGridViewColumn lastVisibleColumn =
            //    columnCollection.GetLastColumn(
            //        DataGridViewElementStates.Visible, DataGridViewElementStates.None);

            //int firstColumn_sIndex = firstVisibleColumn.DisplayIndex;
            //firstVisibleColumn.DisplayIndex = lastVisibleColumn.DisplayIndex;
            //lastVisibleColumn.DisplayIndex = firstColumn_sIndex;
        }

        private bool CanExecuteSwapColumns()
        {
            return true;
        }
        #endregion
    }
}
