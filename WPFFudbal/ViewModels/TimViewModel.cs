using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    class TimViewModel:ViewModelBase
    {
        AddTim openTim;

        #region Constructor
        public TimViewModel(AddTim addTim)
        {
            this.openTim = addTim;
            tim = new vwTim();
            using(Service1Client wcf = new Service1Client())
            {
                ListaLiga = new ObservableCollection<vwLiga>(wcf.LigaList().ToList());
            }
        }

        public TimViewModel(AddTim addTim,vwTim editTim)
        {
            openTim = addTim;
            tim = editTim;
            using (Service1Client wcf = new Service1Client())
            {
                ListaLiga = new ObservableCollection<vwLiga>(wcf.LigaList().ToList());
            }
        }

        #endregion

        #region Properties

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

        private ObservableCollection<vwLiga> listaLiga;
        public ObservableCollection<vwLiga> ListaLiga
        {
            get
            {
                return listaLiga;
            }
            set
            {
                listaLiga = value;
                OnPropertyChanged("ListaLiga");
            }
        }

        private bool isUpdateTim;
        public bool IsUpdateTim
        {
            get
            {
                return isUpdateTim;
            }
            set
            {
                isUpdateTim = value;
            }
        }
        #endregion

        #region Commands

        private ICommand save;
        public ICommand Save
        {
            get
            {
                if(save == null)
                {
                    save = new RelayCommand(param => ExecuteSave(), param => CanExecuteSave());
                }
                return save;
            }
        }

        private void ExecuteSave()
        {
            try
            {
                using (Service1Client wcf = new Service1Client())
                {
                    Tim.ID = tim.ID;
                    Tim.naziv = tim.naziv;
                    Tim.osnovan = tim.osnovan;
                    Tim.liga = liga.ID;
                    wcf.TimAdd(Tim);
                    IsUpdateTim = true;
                    openTim.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool CanExecuteSave()
        {

            if (String.IsNullOrEmpty(tim.naziv))
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
