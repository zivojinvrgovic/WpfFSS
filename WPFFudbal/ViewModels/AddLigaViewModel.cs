using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WCFSERVICEFSS;
using WPFFudbal.Commands;
using WPFFudbal.ServiceReference1;

namespace WPFFudbal.ViewModels
{
    public class AddLigaViewModel
    {
        #region Constructor
        AddLiga add;

        public AddLigaViewModel(AddLiga ligaa)
        {
            add = ligaa;
            liga = new vwLiga();
            using(Service1Client wcf = new Service1Client())
            {
                ListaKategorija = wcf.KategorijaList().ToList();
            }
        }

        public AddLigaViewModel(AddLiga liga,vwLiga l)
        {
            add = liga;
            Liga = l;

            using(Service1Client wcf = new Service1Client())
            {
                ListaKategorija = wcf.KategorijaList().ToList();
            }
        }

        #endregion

        #region Properties
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
            }
        }

        private vwKategorija kategorija;
        public vwKategorija Kategorija
        {
            get
            {
                return kategorija;
            }
            set
            {
                kategorija = value;
            }
        }

        private List<vwKategorija> listaKategorija;
        public List<vwKategorija> ListaKategorija
        {
            get
            {
                return listaKategorija;
            }
            set
            {
                listaKategorija = value;
            }
        }

        private bool isUpdateLiga;
        public bool IsUpdateLiga
        {
            get
            {
                return isUpdateLiga;
            }
            set
            {
                isUpdateLiga = value;
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
                    save = new RelayCommand(param => ExecuteAddLiga(), param => CanExecuteAddLiga());
                }
                return save;
            }
        }

        private void ExecuteAddLiga()
        {
            using(Service1Client wcf = new Service1Client())
            {

                liga.rang = Kategorija.ID;
                wcf.LigaAdd(liga);
                isUpdateLiga = true;
                add.Close();
            }
        }
        private bool CanExecuteAddLiga()
        {
            return true;
        }
        #endregion
    }
}
