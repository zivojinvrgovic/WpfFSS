using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSERVICEFSS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }








        //Igrac

        public vwIgrac IgracAdd(vwIgrac igrac)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (igrac.ID == 0)
                    {
                        tblIgrac newIgr = new tblIgrac();
                        newIgr.ime = igrac.ime;
                        newIgr.prezime = igrac.prezime;
                        newIgr.nacionalnost = igrac.nacionalnost;
                        newIgr.tim = igrac.tim;
                        newIgr.cena = igrac.cena;
                        context.tblIgracs.Add(newIgr);
                        context.SaveChanges();
                        igrac.ID = newIgr.ID;

                        return igrac;
                    }
                    else
                    {
                        tblIgrac userToEdit = (from r in context.tblIgracs where r.ID == igrac.ID select r).FirstOrDefault();
                        userToEdit.ime = igrac.ime;
                        userToEdit.prezime = igrac.prezime;
                        userToEdit.tim = igrac.tim;
                        userToEdit.cena = igrac.cena;
                        userToEdit.nacionalnost = igrac.nacionalnost;
                        context.SaveChanges();
                        return igrac;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void IgracBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    tblIgrac del = (from r in context.tblIgracs where r.ID == ID select r).First();
                    context.tblIgracs.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public List<vwIgrac> IgracList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwIgrac> list = new List<vwIgrac>();
                    list = (from x in context.vwIgracs select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwIgrac GetOneIgrac(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwIgrac tel = new vwIgrac();
                    tel = (from i in n.vwIgracs where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }

        //Kategorija

        public vwKategorija KategorijaAdd(vwKategorija kategorija)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (kategorija.ID == 0)
                    {
                        tblKategorija newKat = new tblKategorija();
                        newKat.rang = kategorija.rang;
                        context.tblKategorijas.Add(newKat);
                        context.SaveChanges();
                        kategorija.ID = newKat.ID;

                        return kategorija;
                    }
                    else
                    {
                        tblKategorija editKat = (from r in context.tblKategorijas where r.ID == kategorija.ID select r).FirstOrDefault();
                        editKat.rang = kategorija.rang;
                        context.SaveChanges();
                        return kategorija;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void KategorijaBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    tblKategorija del = (from r in context.tblKategorijas where r.ID == ID select r).FirstOrDefault();
                    context.tblKategorijas.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public List<vwKategorija> KategorijaList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwKategorija> list = new List<vwKategorija>();
                    list = (from x in context.vwKategorijas select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwKategorija GetOneKategorija(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwKategorija tel = new vwKategorija();
                    tel = (from i in n.vwKategorijas where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }

        //Liga

        public vwLiga LigaAdd(vwLiga liga)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (liga.ID == 0)
                    {
                        tblLiga newLiga = new tblLiga();
                        newLiga.naziv = liga.naziv;
                        newLiga.oznaka = liga.oznaka;
                        newLiga.rang = liga.rang;
                        context.tblLigas.Add(newLiga);
                        context.SaveChanges();
                        liga.ID = newLiga.ID;
                        return liga;
                    }
                    else
                    {
                        tblLiga editLiga = (from r in context.tblLigas where r.ID == liga.ID select r).FirstOrDefault();
                        editLiga.naziv = liga.naziv;
                        editLiga.oznaka = liga.oznaka;
                        editLiga.rang = liga.rang;
                        context.SaveChanges();

                        return liga;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void LigaBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    tblLiga del = (from r in context.tblLigas where r.ID == ID select r).FirstOrDefault();


                    context.tblLigas.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public List<vwLiga> LigaList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwLiga> list = new List<vwLiga>();
                    list = (from x in context.vwLigas select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwLiga GetOneliga(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwLiga tel = new vwLiga();
                    tel = (from i in n.vwLigas where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }

        //Naionalnost

        public vwNacionalnost NacionalnostAdd(vwNacionalnost nacionalnost)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (nacionalnost.ID == 0)
                    {
                        tblNacionalnost newNac = new tblNacionalnost();
                        newNac.naziv = nacionalnost.naziv;
                        newNac.skracenica = nacionalnost.skracenica;
                        context.tblNacionalnosts.Add(newNac);
                        context.SaveChanges();
                        nacionalnost.ID = newNac.ID;

                        return nacionalnost;
                    }
                    else
                    {
                        tblNacionalnost editNac = (from r in context.tblNacionalnosts where r.ID == nacionalnost.ID select r).FirstOrDefault();
                        editNac.naziv = nacionalnost.naziv;
                        editNac.skracenica = nacionalnost.skracenica;


                        context.SaveChanges();
                        return nacionalnost;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void NacionalnostBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {

                    tblNacionalnost del = (from r in context.tblNacionalnosts where r.ID == ID select r).FirstOrDefault();


                    context.tblNacionalnosts.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public List<vwNacionalnost> NacionalnostList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwNacionalnost> list = new List<vwNacionalnost>();
                    list = (from x in context.vwNacionalnosts select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwNacionalnost GetOneNacionalnost(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwNacionalnost tel = new vwNacionalnost();
                    tel = (from i in n.vwNacionalnosts where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }
        //Tim

        public vwTim TimAdd(vwTim tim)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (tim.ID == 0)
                    {
                        tblTim newTim = new tblTim();
                        newTim.naziv = tim.naziv;
                        newTim.sediste = tim.sediste;
                        newTim.liga = tim.liga;
                        newTim.osnovan = tim.osnovan;
                        context.tblTims.Add(newTim);
                        context.SaveChanges();
                        tim.ID = newTim.ID;

                        return tim;
                    }
                    else
                    {
                        tblTim editTim = (from r in context.tblTims where r.ID == tim.ID select r).FirstOrDefault();
                        editTim.naziv = tim.naziv;
                        editTim.sediste = tim.sediste;
                        editTim.liga = tim.liga;
                        editTim.osnovan = tim.osnovan;



                        context.SaveChanges();
                        return tim;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void TimBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {

                    tblTim del = (from r in context.tblTims where r.ID == ID select r).FirstOrDefault();


                    context.tblTims.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public List<vwTim> TimList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwTim> list = new List<vwTim>();
                    list = (from x in context.vwTims select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwTim GetOneTim(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwTim tel = new vwTim();
                    tel = (from i in n.vwTims where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public List<vwTrener> TrenerList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwTrener> list = new List<vwTrener>();
                    list = (from x in context.vwTreners select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwTrener TrenerAdd(vwTrener trener)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (trener.ID == 0)
                    {
                        tblTrener newTrener = new tblTrener();
                        newTrener.ime = trener.ime;
                        newTrener.prezime = trener.prezime;
                        newTrener.tim = trener.tim;
                        context.tblTreners.Add(newTrener);
                        context.SaveChanges();
                        trener.ID = newTrener.ID;

                        return trener;
                    }
                    else
                    {
                        tblTrener editTrener = (from r in context.tblTreners where r.ID == trener.ID select r).FirstOrDefault();
                        editTrener.ime = trener.ime;
                        editTrener.prezime = trener.prezime;
                        editTrener.tim = trener.tim;



                        context.SaveChanges();
                        return trener;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void TrenerBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {

                    tblTrener del = (from r in context.tblTreners where r.ID == ID select r).FirstOrDefault();


                    context.tblTreners.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public vwTrener GetOneTrener(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwTrener tel = new vwTrener();
                    tel = (from i in n.vwTreners where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }

        public List<vwSudija> SudijaList()
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    List<vwSudija> list = new List<vwSudija>();
                    list = (from x in context.vwSudijas select x).ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public vwSudija SudijaAdd(vwSudija sudija)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {
                    if (sudija.ID == 0)
                    {
                        tblSudija newSudija = new tblSudija();
                        newSudija.ime = sudija.ime;
                        newSudija.prezime = sudija.prezime;
                        newSudija.liga = sudija.liga;
                        context.tblSudijas.Add(newSudija);
                        context.SaveChanges();
                        sudija.ID = newSudija.ID;

                        return sudija;
                    }
                    else
                    {
                        tblSudija editSudija = (from r in context.tblSudijas where r.ID == sudija.ID select r).FirstOrDefault();
                        editSudija.ime = sudija.ime;
                        editSudija.prezime = sudija.prezime;
                        editSudija.liga = sudija.liga;



                        context.SaveChanges();
                        return sudija;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
                return null;
            }
        }

        public void SudijaBrisanje(int ID)
        {
            try
            {
                using (FSSEntities context = new FSSEntities())
                {

                    tblSudija del = (from r in context.tblSudijas where r.ID == ID select r).FirstOrDefault();


                    context.tblSudijas.Remove(del);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Exception " + ex.Message.ToString());
            }
        }

        public vwSudija GetOneSudija(int ID)
        {
            try
            {
                using (FSSEntities n = new FSSEntities())
                {
                    vwSudija tel = new vwSudija();
                    tel = (from i in n.vwSudijas where i.ID == ID select i).FirstOrDefault();
                    return tel;
                }
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exeption" + e.Message.ToString());
                return null;
            }
        }
    }
}
