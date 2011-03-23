using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace BazaKontaktow
{
    class Kontakt
    {
        public String  nick;
        public String  imie;
        public String nazwisko;
        public String  adres;
        public String email;
        public int nrTelefonu;
        public String zdjecie;
        public String adresWww;
        public DateTime dataUrodzenia;

        public Kontakt(String nnick, String iimie, String nnazwisko, String aadres, String eemail, int nnrTelefonu, String zzdjecie, String aadresWww, DateTime ddataUrodzenia)
        {
            nick = nnick; imie = iimie; nazwisko = nnazwisko; adres = aadres; email = eemail; nrTelefonu = nnrTelefonu; zdjecie = zzdjecie; adresWww = aadresWww; dataUrodzenia = ddataUrodzenia;
        }

        public override string ToString()
        {
            return nick+" "+imie+" "+nazwisko+" "+adres+" "+email+" "+nrTelefonu.ToString()+" "+adresWww+" "+dataUrodzenia.ToString();
        }

        
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
