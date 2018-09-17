using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSERVICEFSS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        //LISTS
        [OperationContract]
        List<vwIgrac> IgracList();
        [OperationContract]
        List<vwTim> TimList();
        [OperationContract]
        List<vwLiga> LigaList();
        [OperationContract]
        List<vwKategorija> KategorijaList();
        [OperationContract]
        List<vwNacionalnost> NacionalnostList();

        //ADD
        [OperationContract]
        vwIgrac IgracAdd(vwIgrac igrac);
        [OperationContract]
        vwTim TimAdd(vwTim tim);
        [OperationContract]
        vwLiga LigaAdd(vwLiga liga);
        [OperationContract]
        vwKategorija KategorijaAdd(vwKategorija kategorija);
        [OperationContract]
        vwNacionalnost NacionalnostAdd(vwNacionalnost nacionalnost);

        //DELETE
        [OperationContract]
        void IgracBrisanje(int ID);
        [OperationContract]
        void TimBrisanje(int ID);
        [OperationContract]
        void KategorijaBrisanje(int ID);
        [OperationContract]
        void NacionalnostBrisanje(int ID);
        [OperationContract]
        void LigaBrisanje(int ID);

        //GET ONE 
        [OperationContract]
        vwIgrac GetOneIgrac(int ID);
        [OperationContract]
        vwKategorija GetOneKategorija(int ID);
        [OperationContract]
        vwLiga GetOneliga(int ID);
        [OperationContract]
        vwNacionalnost GetOneNacionalnost(int ID);
        [OperationContract]
        vwTim GetOneTim(int ID);

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
