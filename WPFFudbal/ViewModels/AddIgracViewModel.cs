using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFFudbal.ServiceReference1;

namespace WPFFudbal.ViewModels
{
    class AddIgracViewModel
    {
        AddIgrac add;

        #region Constructor

        public AddIgracViewModel(AddIgrac add)
        {
            this.add = add;
            igrac = new vwIgrac();
            using (Service1Client wcf=new Service1Client())
            {
                NacionalnostList = wcf.NacionalnostList().ToList();
                TimList = wcf.TimList().ToList();
            }
            

        }

        public AddIgracViewModel(AddIgrac add,vwIgrac igracEdit)
        {
            this.add = add;
            igrac = new vwIgrac();
            using(Service1Client wcf=new Service1Client())
            {
                NacionalnostList = wcf.NacionalnostList().ToList();
                TimList = wcf.TimList().ToList();
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
        private List<vwTim> timList;
        public List<vwTim> TimList
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

        private List<vwNacionalnost> nacionalnostList;
        public List<vwNacionalnost> NacionalnostList
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

        #region Commands

        #endregion
    }
}
