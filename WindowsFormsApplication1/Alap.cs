using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Alap : Form
    {
        public AdatbazisQledb odb;

        public Alap()
        {
            try
            {
                InitializeComponent();
                odb = AdatbazisQledb.PeldanySzerez();
                odb.Kapcsolodas(Environment.CurrentDirectory + @"\Felhasznalok.accdb");
            }
            catch (Exception)
            {
                MessageBox.Show("HIBA: Betöltési hiba!");
            }
        }

        public class AdatbazisQledb
        {
            protected DataSet ds;
            protected OleDbDataAdapter oda;
            protected DataTable dt;
            protected OleDbCommand oc;
            OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Environment.CurrentDirectory + @"\Felhasznalok.accdb" + ";");

            #region Singleton

            public AdatbazisQledb()
            {
            }
            public static AdatbazisQledb sajat;
            public static AdatbazisQledb PeldanySzerez()
            {
                if (sajat == null) sajat = new AdatbazisQledb();
                return sajat;
            }

            #endregion


            public bool Kapcsolodas(string Adatbázisfájl)
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (OleDbException ode)
                {

                    MessageBox.Show(ode.Message);
                    Logger.Error(ode.Message, "Kapcsolódási hiba");
                    return false;
                }
                finally
                {
                    Lekapcsolodas();
                }
            }
            public void Lekapcsolodas()
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            public string Login(string felhasznalonev, string jelszo)
            {
                string Azonosito_nev;
                try
                {
                    conn.Open();
                    string lekérdezés = String.Format("Select Felhasznalonev, Jelszo from Felhasznalo where Felhasznalonev = {0} and Jelszo = {1} ", felhasznalonev, jelszo);
                    string névmegjelenítés = String.Format("Select Nev from Felhasznalo where Felhasznalonev = {0}", felhasznalonev);
                    ds = new DataSet();//Összes tábla megjelenítése
                    oc = new OleDbCommand(lekérdezés, conn);
                    OleDbDataReader odr;
                    odr = oc.ExecuteReader();//Adatkeresés
                    int count = 0;
                    while (odr.Read())
                    {
                        count += 1;
                    }
                    if (count == 1)
                    {
                        odr.Close();
                        oda = new OleDbDataAdapter(névmegjelenítés, conn);
                        oda.Fill(ds, "Felhasznalo");
                        Azonosito_nev = ((string)ds.Tables[0].Rows[0]["Nev"]);
                        Logger.Info(Azonosito_nev, "Login");
                        return Azonosito_nev;
                    }
                    else if (count > 0)
                    {
                        MessageBox.Show("Dupla jelszó vagy felhasználónév");
                        Logger.Error("Dupla jelszó vagy felhasználónév", "Login");
                    }
                    else
                    {
                        MessageBox.Show("Felhasználó név vagy jelszó rossz");
                        Logger.Error("Felhasználó név vagy jelszó rossz", "Login");
                    }

                }
                catch (OleDbException ode)
                {
                    MessageBox.Show(ode.Message);
                    Logger.Error(ode.Message, "Login");
                }
                Logger.Error("Nincs ilyen felhasználó név!", "Login");
                return "Nincs ilyen felhasználó név!";

            }
            
            public void Alkamazottlekérdező(DataGridView Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select * from Felhasznalo");
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();
                    BindingSource bSource = new BindingSource();
                    bSource.DataSource = dt;
                    oda.Fill(dt);
                    Megjelenito.DataSource = dt;
                    oda.Update(dt);
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Alkalmazott megjelenítő hiba"); }
                finally { Lekapcsolodas(); }
            }

            public void SzámlaMegtekintő(DataGridView Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select * from Szamlak");
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();
                    oda.Fill(dt);
                    Megjelenito.DataSource = dt;
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Számla Megjelenítő hiba"); }
                finally { Lekapcsolodas(); }
            }

            public void Termékmegtekintő(DataGridView Megjelenito)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("Select * from Termekek");
                    oda = new OleDbDataAdapter(query, conn);
                    dt = new DataTable();
                    oda.Fill(dt);
                    Megjelenito.DataSource = dt;
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Termék megjelenítő hiba"); }
                finally { Lekapcsolodas(); }
            }
            public void Tagfelvétel(string Nev, DateTime Szuletesi_ido, string Lakcim, string Felhasznalonev, string Jelszo)
            {
                try
                {
                    conn.Open();
                    string query = String.Format("INSERT INTO Felhasznalo (Nev,Szuletesi_ido,Lakcim,Felhasznalonev,Jelszo) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",Nev, Szuletesi_ido, Lakcim, Felhasznalonev, Jelszo);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                    Logger.Info(query, "Tagfelvételi adatok");
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Tagfelvételi hiba"); }
                finally { Lekapcsolodas(); }
            }
            public void Termékfelvitel(string Vonalkod, string Gyorskód, string Név, string Szállító, string Szállítóikód, string Beszallito, string Kategória, int Menny_érték, string Menny_egység, string Kiszerelés, int Eladási_ár, double Nettó, double Akció, DateTime datum, bool Tiltott, string Áfa)
            {
                try
                {
                    conn.Open();
                    if (Gyorskód == "")
                    {
                        Gyorskód = "-1";
                    }
                    string query = String.Format("INSERT INTO Termekek (Vonalkod, Gyorskód, Nev, Szallito, Szallitoi_kod, Beszallito_orszag, Kategoria, Mennyisegi_ar, Mennyisegi_egyseg, Kiszereles, Eladasi_ar, Netto_ar, Akcios_ar, Datum, Tiltott_lista, Áfa) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}', {7} ,'{8}','{9}', {10} , {11} , {12} ,'{13}','{14}','{15}');", Vonalkod, Gyorskód, Név, Szállító, Szállítóikód, Beszallito, Kategória, Menny_érték, Menny_egység, Kiszerelés, Convert.ToInt32(Eladási_ár), Convert.ToDouble(Nettó), Convert.ToDouble(Akció), Convert.ToString(datum), Convert.ToInt32(Tiltott), Áfa);
                    oda = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    oda.Fill(ds);
                    Logger.Info(query, "Termékfelviteli adatok");
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Termékfelviteli hiba"); }
                finally { Lekapcsolodas(); }
            }

            public void SqlParancs(string SQLParancs)
            {
                try
                {
                    conn.Open();
                    oda = new OleDbDataAdapter(SQLParancs, conn);
                    ds = new DataSet();
                    oda.Fill(ds);

                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "SqlParancs hiba"); }
                finally { Lekapcsolodas(); }
            }

            public string Ország(string Vonalkód)
            {
                string beszallito;
                try
                {

                    conn.Open();
                    string query = String.Format("Select * from EAN_13 ");
                    char j = '"';
                    oc = new OleDbCommand(query, conn);
                    OleDbDataReader odr;
                    odr = oc.ExecuteReader();//Adatkeresés
                    int i = 0;
                    while (odr.Read())
                    {

                        string orszag = odr.GetString(0);
                        if (orszag.Length == 9)
                        {
                            string eleje = orszag.Substring(0, 3);
                            string vege = orszag.Substring(6, 3);
                            if (int.Parse(Vonalkód) >= int.Parse(eleje) && int.Parse(Vonalkód) <= int.Parse(vege))
                            {
                                string névmegjelenítés = String.Format("Select Ország from EAN_13");
                                oda = new OleDbDataAdapter(névmegjelenítés, conn);
                                ds = new DataSet();
                                oda.Fill(ds, "EAN_13");
                                beszallito = ((string)ds.Tables[0].Rows[i]["Ország"]);
                                return beszallito;
                            }
                        }
                        else if (orszag.Length == 3 && orszag == Vonalkód)
                        {
                            string névmegjelenítés = String.Format("SELECT Ország FROM EAN_13 WHERE Kód = " + j + "{0}" + j + "", Vonalkód);
                            oda = new OleDbDataAdapter(névmegjelenítés, conn);
                            ds = new DataSet();
                            oda.Fill(ds, "EAN_13");
                            beszallito = ds.Tables[0].Rows[0]["Ország"].ToString();
                            return beszallito;
                        }
                        i++;
                    }
                    odr.Close();
                    return beszallito = "Nincs ilyen vonalkód a listában";
                }
                catch (OleDbException ode) { MessageBox.Show(ode.Message); Logger.Error(ode.Message, "Nincs ilyen vonalkód a listában"); }
                finally { conn.Close(); }
                return beszallito = "HIBA";
            }
        }
    }
}
