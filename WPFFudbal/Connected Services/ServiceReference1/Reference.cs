﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFFudbal.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IgracList", ReplyAction="http://tempuri.org/IService1/IgracListResponse")]
        WCFSERVICEFSS.vwIgrac[] IgracList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IgracList", ReplyAction="http://tempuri.org/IService1/IgracListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwIgrac[]> IgracListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TimList", ReplyAction="http://tempuri.org/IService1/TimListResponse")]
        WCFSERVICEFSS.vwTim[] TimList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TimList", ReplyAction="http://tempuri.org/IService1/TimListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwTim[]> TimListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LigaList", ReplyAction="http://tempuri.org/IService1/LigaListResponse")]
        WCFSERVICEFSS.vwLiga[] LigaList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LigaList", ReplyAction="http://tempuri.org/IService1/LigaListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwLiga[]> LigaListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategorijaList", ReplyAction="http://tempuri.org/IService1/KategorijaListResponse")]
        WCFSERVICEFSS.vwKategorija[] KategorijaList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategorijaList", ReplyAction="http://tempuri.org/IService1/KategorijaListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwKategorija[]> KategorijaListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NacionalnostList", ReplyAction="http://tempuri.org/IService1/NacionalnostListResponse")]
        WCFSERVICEFSS.vwNacionalnost[] NacionalnostList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NacionalnostList", ReplyAction="http://tempuri.org/IService1/NacionalnostListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwNacionalnost[]> NacionalnostListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TrenerList", ReplyAction="http://tempuri.org/IService1/TrenerListResponse")]
        WCFSERVICEFSS.vwTrener[] TrenerList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TrenerList", ReplyAction="http://tempuri.org/IService1/TrenerListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwTrener[]> TrenerListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SudijaList", ReplyAction="http://tempuri.org/IService1/SudijaListResponse")]
        WCFSERVICEFSS.vwSudija[] SudijaList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SudijaList", ReplyAction="http://tempuri.org/IService1/SudijaListResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwSudija[]> SudijaListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IgracAdd", ReplyAction="http://tempuri.org/IService1/IgracAddResponse")]
        WCFSERVICEFSS.vwIgrac IgracAdd(WCFSERVICEFSS.vwIgrac igrac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IgracAdd", ReplyAction="http://tempuri.org/IService1/IgracAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwIgrac> IgracAddAsync(WCFSERVICEFSS.vwIgrac igrac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TimAdd", ReplyAction="http://tempuri.org/IService1/TimAddResponse")]
        WCFSERVICEFSS.vwTim TimAdd(WCFSERVICEFSS.vwTim tim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TimAdd", ReplyAction="http://tempuri.org/IService1/TimAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwTim> TimAddAsync(WCFSERVICEFSS.vwTim tim);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LigaAdd", ReplyAction="http://tempuri.org/IService1/LigaAddResponse")]
        WCFSERVICEFSS.vwLiga LigaAdd(WCFSERVICEFSS.vwLiga liga);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LigaAdd", ReplyAction="http://tempuri.org/IService1/LigaAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwLiga> LigaAddAsync(WCFSERVICEFSS.vwLiga liga);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategorijaAdd", ReplyAction="http://tempuri.org/IService1/KategorijaAddResponse")]
        WCFSERVICEFSS.vwKategorija KategorijaAdd(WCFSERVICEFSS.vwKategorija kategorija);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategorijaAdd", ReplyAction="http://tempuri.org/IService1/KategorijaAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwKategorija> KategorijaAddAsync(WCFSERVICEFSS.vwKategorija kategorija);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NacionalnostAdd", ReplyAction="http://tempuri.org/IService1/NacionalnostAddResponse")]
        WCFSERVICEFSS.vwNacionalnost NacionalnostAdd(WCFSERVICEFSS.vwNacionalnost nacionalnost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NacionalnostAdd", ReplyAction="http://tempuri.org/IService1/NacionalnostAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwNacionalnost> NacionalnostAddAsync(WCFSERVICEFSS.vwNacionalnost nacionalnost);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TrenerAdd", ReplyAction="http://tempuri.org/IService1/TrenerAddResponse")]
        WCFSERVICEFSS.vwTrener TrenerAdd(WCFSERVICEFSS.vwTrener trener);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TrenerAdd", ReplyAction="http://tempuri.org/IService1/TrenerAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwTrener> TrenerAddAsync(WCFSERVICEFSS.vwTrener trener);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SudijaAdd", ReplyAction="http://tempuri.org/IService1/SudijaAddResponse")]
        WCFSERVICEFSS.vwSudija SudijaAdd(WCFSERVICEFSS.vwSudija sudija);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SudijaAdd", ReplyAction="http://tempuri.org/IService1/SudijaAddResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwSudija> SudijaAddAsync(WCFSERVICEFSS.vwSudija sudija);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IgracBrisanje", ReplyAction="http://tempuri.org/IService1/IgracBrisanjeResponse")]
        void IgracBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IgracBrisanje", ReplyAction="http://tempuri.org/IService1/IgracBrisanjeResponse")]
        System.Threading.Tasks.Task IgracBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TimBrisanje", ReplyAction="http://tempuri.org/IService1/TimBrisanjeResponse")]
        void TimBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TimBrisanje", ReplyAction="http://tempuri.org/IService1/TimBrisanjeResponse")]
        System.Threading.Tasks.Task TimBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategorijaBrisanje", ReplyAction="http://tempuri.org/IService1/KategorijaBrisanjeResponse")]
        void KategorijaBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/KategorijaBrisanje", ReplyAction="http://tempuri.org/IService1/KategorijaBrisanjeResponse")]
        System.Threading.Tasks.Task KategorijaBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NacionalnostBrisanje", ReplyAction="http://tempuri.org/IService1/NacionalnostBrisanjeResponse")]
        void NacionalnostBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/NacionalnostBrisanje", ReplyAction="http://tempuri.org/IService1/NacionalnostBrisanjeResponse")]
        System.Threading.Tasks.Task NacionalnostBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LigaBrisanje", ReplyAction="http://tempuri.org/IService1/LigaBrisanjeResponse")]
        void LigaBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LigaBrisanje", ReplyAction="http://tempuri.org/IService1/LigaBrisanjeResponse")]
        System.Threading.Tasks.Task LigaBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TrenerBrisanje", ReplyAction="http://tempuri.org/IService1/TrenerBrisanjeResponse")]
        void TrenerBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TrenerBrisanje", ReplyAction="http://tempuri.org/IService1/TrenerBrisanjeResponse")]
        System.Threading.Tasks.Task TrenerBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SudijaBrisanje", ReplyAction="http://tempuri.org/IService1/SudijaBrisanjeResponse")]
        void SudijaBrisanje(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SudijaBrisanje", ReplyAction="http://tempuri.org/IService1/SudijaBrisanjeResponse")]
        System.Threading.Tasks.Task SudijaBrisanjeAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneIgrac", ReplyAction="http://tempuri.org/IService1/GetOneIgracResponse")]
        WCFSERVICEFSS.vwIgrac GetOneIgrac(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneIgrac", ReplyAction="http://tempuri.org/IService1/GetOneIgracResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwIgrac> GetOneIgracAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneKategorija", ReplyAction="http://tempuri.org/IService1/GetOneKategorijaResponse")]
        WCFSERVICEFSS.vwKategorija GetOneKategorija(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneKategorija", ReplyAction="http://tempuri.org/IService1/GetOneKategorijaResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwKategorija> GetOneKategorijaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneliga", ReplyAction="http://tempuri.org/IService1/GetOneligaResponse")]
        WCFSERVICEFSS.vwLiga GetOneliga(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneliga", ReplyAction="http://tempuri.org/IService1/GetOneligaResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwLiga> GetOneligaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneNacionalnost", ReplyAction="http://tempuri.org/IService1/GetOneNacionalnostResponse")]
        WCFSERVICEFSS.vwNacionalnost GetOneNacionalnost(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneNacionalnost", ReplyAction="http://tempuri.org/IService1/GetOneNacionalnostResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwNacionalnost> GetOneNacionalnostAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneTim", ReplyAction="http://tempuri.org/IService1/GetOneTimResponse")]
        WCFSERVICEFSS.vwTim GetOneTim(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneTim", ReplyAction="http://tempuri.org/IService1/GetOneTimResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwTim> GetOneTimAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneTrener", ReplyAction="http://tempuri.org/IService1/GetOneTrenerResponse")]
        WCFSERVICEFSS.vwTrener GetOneTrener(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneTrener", ReplyAction="http://tempuri.org/IService1/GetOneTrenerResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwTrener> GetOneTrenerAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneSudija", ReplyAction="http://tempuri.org/IService1/GetOneSudijaResponse")]
        WCFSERVICEFSS.vwSudija GetOneSudija(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetOneSudija", ReplyAction="http://tempuri.org/IService1/GetOneSudijaResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.vwSudija> GetOneSudijaAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        WCFSERVICEFSS.CompositeType GetDataUsingDataContract(WCFSERVICEFSS.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<WCFSERVICEFSS.CompositeType> GetDataUsingDataContractAsync(WCFSERVICEFSS.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WPFFudbal.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WPFFudbal.ServiceReference1.IService1>, WPFFudbal.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WCFSERVICEFSS.vwIgrac[] IgracList() {
            return base.Channel.IgracList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwIgrac[]> IgracListAsync() {
            return base.Channel.IgracListAsync();
        }
        
        public WCFSERVICEFSS.vwTim[] TimList() {
            return base.Channel.TimList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwTim[]> TimListAsync() {
            return base.Channel.TimListAsync();
        }
        
        public WCFSERVICEFSS.vwLiga[] LigaList() {
            return base.Channel.LigaList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwLiga[]> LigaListAsync() {
            return base.Channel.LigaListAsync();
        }
        
        public WCFSERVICEFSS.vwKategorija[] KategorijaList() {
            return base.Channel.KategorijaList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwKategorija[]> KategorijaListAsync() {
            return base.Channel.KategorijaListAsync();
        }
        
        public WCFSERVICEFSS.vwNacionalnost[] NacionalnostList() {
            return base.Channel.NacionalnostList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwNacionalnost[]> NacionalnostListAsync() {
            return base.Channel.NacionalnostListAsync();
        }
        
        public WCFSERVICEFSS.vwTrener[] TrenerList() {
            return base.Channel.TrenerList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwTrener[]> TrenerListAsync() {
            return base.Channel.TrenerListAsync();
        }
        
        public WCFSERVICEFSS.vwSudija[] SudijaList() {
            return base.Channel.SudijaList();
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwSudija[]> SudijaListAsync() {
            return base.Channel.SudijaListAsync();
        }
        
        public WCFSERVICEFSS.vwIgrac IgracAdd(WCFSERVICEFSS.vwIgrac igrac) {
            return base.Channel.IgracAdd(igrac);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwIgrac> IgracAddAsync(WCFSERVICEFSS.vwIgrac igrac) {
            return base.Channel.IgracAddAsync(igrac);
        }
        
        public WCFSERVICEFSS.vwTim TimAdd(WCFSERVICEFSS.vwTim tim) {
            return base.Channel.TimAdd(tim);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwTim> TimAddAsync(WCFSERVICEFSS.vwTim tim) {
            return base.Channel.TimAddAsync(tim);
        }
        
        public WCFSERVICEFSS.vwLiga LigaAdd(WCFSERVICEFSS.vwLiga liga) {
            return base.Channel.LigaAdd(liga);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwLiga> LigaAddAsync(WCFSERVICEFSS.vwLiga liga) {
            return base.Channel.LigaAddAsync(liga);
        }
        
        public WCFSERVICEFSS.vwKategorija KategorijaAdd(WCFSERVICEFSS.vwKategorija kategorija) {
            return base.Channel.KategorijaAdd(kategorija);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwKategorija> KategorijaAddAsync(WCFSERVICEFSS.vwKategorija kategorija) {
            return base.Channel.KategorijaAddAsync(kategorija);
        }
        
        public WCFSERVICEFSS.vwNacionalnost NacionalnostAdd(WCFSERVICEFSS.vwNacionalnost nacionalnost) {
            return base.Channel.NacionalnostAdd(nacionalnost);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwNacionalnost> NacionalnostAddAsync(WCFSERVICEFSS.vwNacionalnost nacionalnost) {
            return base.Channel.NacionalnostAddAsync(nacionalnost);
        }
        
        public WCFSERVICEFSS.vwTrener TrenerAdd(WCFSERVICEFSS.vwTrener trener) {
            return base.Channel.TrenerAdd(trener);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwTrener> TrenerAddAsync(WCFSERVICEFSS.vwTrener trener) {
            return base.Channel.TrenerAddAsync(trener);
        }
        
        public WCFSERVICEFSS.vwSudija SudijaAdd(WCFSERVICEFSS.vwSudija sudija) {
            return base.Channel.SudijaAdd(sudija);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwSudija> SudijaAddAsync(WCFSERVICEFSS.vwSudija sudija) {
            return base.Channel.SudijaAddAsync(sudija);
        }
        
        public void IgracBrisanje(int ID) {
            base.Channel.IgracBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task IgracBrisanjeAsync(int ID) {
            return base.Channel.IgracBrisanjeAsync(ID);
        }
        
        public void TimBrisanje(int ID) {
            base.Channel.TimBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task TimBrisanjeAsync(int ID) {
            return base.Channel.TimBrisanjeAsync(ID);
        }
        
        public void KategorijaBrisanje(int ID) {
            base.Channel.KategorijaBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task KategorijaBrisanjeAsync(int ID) {
            return base.Channel.KategorijaBrisanjeAsync(ID);
        }
        
        public void NacionalnostBrisanje(int ID) {
            base.Channel.NacionalnostBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task NacionalnostBrisanjeAsync(int ID) {
            return base.Channel.NacionalnostBrisanjeAsync(ID);
        }
        
        public void LigaBrisanje(int ID) {
            base.Channel.LigaBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task LigaBrisanjeAsync(int ID) {
            return base.Channel.LigaBrisanjeAsync(ID);
        }
        
        public void TrenerBrisanje(int ID) {
            base.Channel.TrenerBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task TrenerBrisanjeAsync(int ID) {
            return base.Channel.TrenerBrisanjeAsync(ID);
        }
        
        public void SudijaBrisanje(int ID) {
            base.Channel.SudijaBrisanje(ID);
        }
        
        public System.Threading.Tasks.Task SudijaBrisanjeAsync(int ID) {
            return base.Channel.SudijaBrisanjeAsync(ID);
        }
        
        public WCFSERVICEFSS.vwIgrac GetOneIgrac(int ID) {
            return base.Channel.GetOneIgrac(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwIgrac> GetOneIgracAsync(int ID) {
            return base.Channel.GetOneIgracAsync(ID);
        }
        
        public WCFSERVICEFSS.vwKategorija GetOneKategorija(int ID) {
            return base.Channel.GetOneKategorija(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwKategorija> GetOneKategorijaAsync(int ID) {
            return base.Channel.GetOneKategorijaAsync(ID);
        }
        
        public WCFSERVICEFSS.vwLiga GetOneliga(int ID) {
            return base.Channel.GetOneliga(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwLiga> GetOneligaAsync(int ID) {
            return base.Channel.GetOneligaAsync(ID);
        }
        
        public WCFSERVICEFSS.vwNacionalnost GetOneNacionalnost(int ID) {
            return base.Channel.GetOneNacionalnost(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwNacionalnost> GetOneNacionalnostAsync(int ID) {
            return base.Channel.GetOneNacionalnostAsync(ID);
        }
        
        public WCFSERVICEFSS.vwTim GetOneTim(int ID) {
            return base.Channel.GetOneTim(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwTim> GetOneTimAsync(int ID) {
            return base.Channel.GetOneTimAsync(ID);
        }
        
        public WCFSERVICEFSS.vwTrener GetOneTrener(int ID) {
            return base.Channel.GetOneTrener(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwTrener> GetOneTrenerAsync(int ID) {
            return base.Channel.GetOneTrenerAsync(ID);
        }
        
        public WCFSERVICEFSS.vwSudija GetOneSudija(int ID) {
            return base.Channel.GetOneSudija(ID);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.vwSudija> GetOneSudijaAsync(int ID) {
            return base.Channel.GetOneSudijaAsync(ID);
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public WCFSERVICEFSS.CompositeType GetDataUsingDataContract(WCFSERVICEFSS.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<WCFSERVICEFSS.CompositeType> GetDataUsingDataContractAsync(WCFSERVICEFSS.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}
