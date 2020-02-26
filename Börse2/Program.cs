using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Börse
{
    enum Verkauf { Eine, Alle }



    class Program
    {
        static void Main(string[] args)
        {
            {

                // AktuelleKursNotierungen.ZeigeAktuelleKurse();
                AktuelleKursNotierungen A = new AktuelleKursNotierungen();
                //A.ZeigeAktuelleKurse();
                Börsianer B = new Börsianer();
               B.menuauswählen();
                
               // B.Geldeinzahlen();
              //  B.Geldauszahlen();
              //  B.Kaufen();

                Console.ReadLine();

            }


        }
    }

    public  class AktuelleKursNotierungen
    {

         public void ZeigeAktuelleKurse()
        {
            List<Aktie> dax = new List<Aktie>();
            List<Aktie> tecDax = new List<Aktie>();
            Random kursRandom = new Random();

            for (int i = 0; i < 1; i++)
            {
                dax.Add(new Aktie()
                {
                    AktienID = 1,
                    Aktienname = "Bitlc",
                    Wert = kursRandom.Next(-1, 30000)
                });
                dax.Add(new Aktie()
                {
                    AktienID = 2,
                    Aktienname = "SAP",
                    Wert = kursRandom.Next(-1, 30000)
                });

                foreach (var item in dax)
                {
                    Console.WriteLine("Name: " + item.Aktienname + "\t AktienID: " + item.AktienID + "\t Wert: " + item.Wert);
                }
                foreach (var item in tecDax)
                {
                    Console.WriteLine("Name: " + item.Aktienname + "\t  AktienID: " + item.AktienID + "\t Wert: " + item.Wert);
                }

            }



        }


    }
   public  class Aktie
    {
        public int AktienID { get; set; }
        public string Aktienname { get; set; }
        public double Wert { get; set; }




    }

    public class Börsianer
    {
        public int BörsenID { get; set; }
        public string Vorname { get; set; }
        public double Konto { get; set; } 
        public double Eingabe { get; set; }
        public double AktuelleKontozustand { get; set; } = 0;
        public Aktie AktieKonto { get; set; }
        public double AkAktuellKontozustand { get; set; } = 0;

        public void Login()
        {
            List<Börsianer> börsianer = new List<Börsianer>();
           // börsianer.Add(){ Vorname = "Börsianer1"};


            string Eingabe = Console.ReadLine();

        }
        public void menuauswählen() {
            Console.WriteLine("************ Willkommen in der Börse ***********");
        Console.WriteLine("(1) Geld Einzahlen");
        Console.WriteLine("(2) Geld Auszahlen");
        Console.WriteLine("(3) Akti Kaufen");
        Console.WriteLine("(4) Akti Verkaufen");
        int value = Convert.ToInt32(Console.ReadLine());
        switch (value)
	{
                case (1):
                    Geldeinzahlen();
                    break;
                case (2):
                    Geldauszahlen();
                    break;
                case (3):
                    Kaufen();
                    break;
                case (4):
                    Verkaufen();
                    break;
		default:
                    Console.WriteLine("Anmeldung");
 break;
	}
        }
        public void Geldeinzahlen()
        {
            double Eingabe;
            Console.WriteLine("Geben Sie eine Eingabe ein");
            Eingabe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tragen Sie die Einzahlungssumme ein : {0} € ", Eingabe);
            AktuelleKontozustand = Eingabe + AktuelleKontozustand;
            Konto = AktuelleKontozustand;
            Console.WriteLine("Dein Kontostand beträgt : {0} € ", AktuelleKontozustand);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("(1) Möchten Sie Nochmal Geld einzahlen");
            Console.WriteLine("(0) Abbrechen und zum Hauptmenü ");
            
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case (1):
                    Geldeinzahlen();
                    break;
                case (0):
                    menuauswählen();
                    break;
                default:
                    Console.WriteLine("Der Kurs Beobachten");
                    break;
            }


        }



        public void  Geldauszahlen()
                {
            double Eingabe;
            Console.WriteLine("Geben Sie eine Eingabe ein : ");
            Eingabe = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Tragen Sie die Einzahlungssumme ein : {0} € ", Eingabe);

            this.AktuelleKontozustand = AktuelleKontozustand - Eingabe;
            Console.WriteLine("Dein Kontostand beträgt : {0} €", AktuelleKontozustand);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("(1) Möchten Sie Nochmal Geld Auszahlen");
            Console.WriteLine("(0) Abbrechen und zum Hauptmenü ");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case (1):
                    Geldauszahlen();
                    break;
                case (0):
                    menuauswählen();
                    break;
                default:
                    Console.WriteLine("Der Kurs Beobachten");
                    break;
            }

        }

              public void Kaufen()
              {
                 AktuelleKursNotierungen aktuelleKurs = new AktuelleKursNotierungen();
                 aktuelleKurs.ZeigeAktuelleKurse();
            
            Console.WriteLine("Wollen Sie Die Aktie kaufen ?");
         
            Console.WriteLine("(1) Kaufen");
            Console.WriteLine("(2) Nicht Kaufen");
            Console.WriteLine("(3) Als Favorit speichern");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case (1):
                    Console.WriteLine("Die Aktie ist gekauft, und ist auf deine Aktiekonto ");
                    Aktie aktie = new Aktie();
                    AktuelleKontozustand = Konto - aktie.Wert;
                    //AkAktuellKontozustand = 0;
                    AkAktuellKontozustand = AkAktuellKontozustand + aktie.Wert;
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("(1) AktuelleKontozustand ");
                    Console.WriteLine("(2) AktuellAktieKontozustand ");
                    Console.WriteLine("(0) Abbrechen ");
                    switch (value)
                    {
                        case (1):
                            Console.WriteLine("Der AktuelleKontozusatnd ist {0} €", AktuelleKontozustand);
                            break;
                        case (2):
                            Console.WriteLine("Der AktuelleKontozusatnd ist {0} €", AkAktuellKontozustand);
                            break;
                        case (3):
                            Console.WriteLine("Abbrechen und Menu aufrufen");
                            break;
                        default:
                            break;
                    }
                    break;
                case (2):
                    Console.WriteLine("Die Aktie wird nicht gekauft");
                    break;
                case (3):
                    Console.WriteLine("Die Aktie als favorit gespeichert, Aktie im Auge halten");
                    break;
                default:
                    Console.WriteLine("Den Kurs beobachten ");
                    break;
            }



        }
        public void Verkaufen()
        {
            AktuelleKursNotierungen aktuelleKurs = new AktuelleKursNotierungen();
            aktuelleKurs.ZeigeAktuelleKurse();
            Console.WriteLine("Wollen Sie Die Aktie kaufen ?");
            int value = Convert.ToInt32(Console.ReadLine());
            switch (value)
            {
                case (1):
                    Console.WriteLine("Die Aktie kaufen ");
                    Aktie aktie = new Aktie();
                    AktuelleKontozustand = Konto - aktie.Wert;
                    //AkAktuellKontozustand = 0;
                    AkAktuellKontozustand = AkAktuellKontozustand + aktie.Wert;
                    break;
                case (2):
                    Console.WriteLine("Die Aktie nicht kaufen");
                    break;
                case (3):
                    Console.WriteLine("Die Aktie als favorit speichern, im Auge halten");
                    break;
                default:
                    Console.WriteLine("Den Kurs beobachten ");
                    break;
            }



        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;
//using System.Collections;
//using System.Net;
//using System.Threading;

//namespace Börse
//{
//    enum Verkauf { Eine, Alle }



//    class Program
//    {
//        static void Main(string[] args)
//        {
//            {

//                LoginAbgleich.Login();

//                Console.ReadLine();

//            }


//        }
//    }


//    static class AktuelleKursNotierungen
//    {

//        static public void ZeigeAktuelleKurse()
//        {
//            //List<Aktie> dax = new List<Aktie>();
//            //List<Aktie> tecDax = new List<Aktie>();
//            //Random kursRandom = new Random();

//            //for (int i = 0; i < 1; i++)
//            //{
//            //    dax.Add(new Aktie()
//            //    {
//            //        AktienID = 1,
//            //        Aktienname = "Bitlc",
//            //        Wert = kursRandom.Next(-1, 30000)
//            //    });
//            //    dax.Add(new Aktie()
//            //    {
//            //        AktienID = 2,
//            //        Aktienname = "SAP",
//            //        Wert = kursRandom.Next(-1, 30000)
//            //    });

//            //    foreach (var item in dax)
//            //    {
//            //        Console.WriteLine("Name: " + item.Aktienname + "\t AktienID: " + item.AktienID + "\t Wert: " + item.Wert);
//            //    }
//            //    foreach (var item in tecDax)
//            //    {
//            //        Console.WriteLine("Name: " + item.Aktienname + "\t  AktienID: " + item.AktienID + "\t Wert: " + item.Wert);
//            //    }

//            //}
//            int i = 0;
//            string[] companies = { "UK 100 Index", "Gold", "DAX" };

//            foreach (string s in companies)
//            {
//                Aktie.readValues(s);
//            }
//            i++;
//            Console.WriteLine();
//            Console.WriteLine();
//            Thread.Sleep(1000);

//            Console.ReadLine();



//        }


//    }
//    class Aktie
//    {
//        public int AktienID { get; set; }
//        public string Aktienname { get; set; }
//        public double Wert { get; set; }

//        public static void readValues(string company)
//        {
//            WebClient client = new WebClient();
//            List<string> elemente = new List<string>();
//            string[] vals;

//            if (company.Contains("UK 100 Index"))
//            {
//                vals = client.DownloadString("https://www.teletrader.com/ChartDataHistory.aspx?request=HISTORY%20tts-76593427%20TICKS%20510%20&dataLoader=ttws")
//                .Split(',');
//            }
//            else if (company.Contains("Gold"))
//            {
//                vals = client.DownloadString("https://www.teletrader.com/ChartDataHistory.aspx?request=HISTORY%20tts-78738373%20TICKS%20510%20&dataLoader=ttws")
//                .Split(',');
//            }
//            else
//            {
//                vals = client.DownloadString("https://www.teletrader.com/ChartDataHistory.aspx?request=HISTORY%20tts-514562%20TICKS%20510%20&dataLoader=ttws")
//                .Split(',');
//            }
//            int i = 0;
//            foreach (var item in vals)
//            {
//                elemente = item.Split(';').ToList();
//            }
//            Console.WriteLine("Das ist der Aktuelle Aktien Kurs von : " + company);
//            Console.WriteLine(elemente[elemente.Count() - 3]);
//        }
//    }


//    public class Börsianer
//    {
//        public int BörsenID { get; set; }
//        public string Vorname { get; set; }
//        public double Konto { get; set; }

//        public string Passwort { get; set; }

//    }


//    class LoginAbgleich
//    {
//        public static void Login()
//        {
//            string input;
//            string savePath = (@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug");
//            int ID = 0;
//            bool login = false;

//            string[] usernameArray = File.ReadAllLines(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\username.txt");//loads a text file and sets it to an array
//            ArrayList username = new ArrayList(usernameArray);//sets the array to an array list
//            string[] passwordArray = File.ReadAllLines(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\password.txt");
//            ArrayList password = new ArrayList(passwordArray);
//            string[] timeArray = File.ReadAllLines(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\time.txt");
//            ArrayList time = new ArrayList(timeArray);

//            start:
//            if (login == true)
//            {
//                goto menu;
//            }
//            Console.Clear();
//            Console.WriteLine(@"What would you like to do?
//1 Login
//2 Registrieren
//3 Shut Down");
//            input = Console.ReadLine();

//            switch (input)
//            {
//                case "1":
//                case "login":
//                    Console.WriteLine("Wie ist dein Username?");
//                    input = Console.ReadLine();
//                    input = input.ToLower();
//                    if (input == "default")
//                    {
//                        Console.WriteLine("Bitte gib einen anderen usernamen ein");
//                        Console.ReadKey();
//                        goto start;
//                    }
//                    foreach (string name in username)//runs through the username list
//                    {
//                        if (name == input)//returns true if it finds a match in the list
//                        {
//                            int listNo = username.IndexOf(input);//sets the listNo to the index number of the password list that matched
//                            Console.WriteLine("Wie ist dein Passwort?");
//                            input = Console.ReadLine();

//                            string passCheck = Convert.ToString(password[listNo]);//sets the passCheck var to the string index no found at the same index as the user name
//                            if (input == passCheck) //if the input and the passCheck are the same you logged in
//                            {
//                                ID = listNo;//sets the ID for the user
//                                string lastLogin = Convert.ToString(time[ID]);//gets the last login from the time list
//                                Console.WriteLine(@"Du bist Eingelogt!
//                                                    Letzter Login am " + lastLogin);
//                                AktuelleKursNotierungen.ZeigeAktuelleKurse();
//                                time[ID] = (Convert.ToString(DateTime.Now));//sets a new login time
//                                using (TextWriter writer = File.CreateText(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\time.txt"))//creates a txt file called time
//                                {
//                                    foreach (string date in time)
//                                    {
//                                        writer.WriteLine(date);//adds a new line to the txt file for time
//                                    }
//                                }
//                                Console.ReadKey();
//                                login = true;
//                                goto start;
//                            }
//                        }
//                    }
//                    Console.WriteLine("Error!");
//                    Console.ReadKey();
//                    goto start;



//                case "2":
//                case "registrieren":

//                    Console.WriteLine("Wie soll dein Username sein?");
//                    username:
//                    input = Console.ReadLine();
//                    input = input.ToLower();
//                    if (input == "")
//                    {
//                        Console.WriteLine("Gib dein Usernamen ein");
//                        goto username;
//                    }
//                    foreach (string name in username)
//                    {
//                        if (name == input)//checks if there is a user name called that already
//                        {
//                            Console.WriteLine("Der Username ist bereits vergeben");
//                            Console.ReadKey();
//                            goto start;
//                        }
//                    }
//                    username.Add(input);//adds the username to the username list
//                    Console.WriteLine("Wie soll dein passwort sein?");
//                    password:
//                    input = Console.ReadLine();
//                    if (input == "")
//                    {
//                        Console.WriteLine("Bitte gib dein Passwort ein");
//                        goto password;
//                    }
//                    password.Add(input);//adds the password to the password list
//                    using (TextWriter writer = File.CreateText(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\username.txt"))//creates a txt file called username
//                    {
//                        foreach (string name in username)
//                        {
//                            writer.WriteLine(name);//adds a new line to the txt file for the user
//                        }
//                    }
//                    using (TextWriter writer = File.CreateText(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\password.txt"))
//                    {
//                        foreach (string pass in password)
//                        {
//                            writer.WriteLine(pass);
//                        }
//                    }
//                    time.Add(Convert.ToString(DateTime.Now));
//                    using (TextWriter writer = File.CreateText(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\time.txt"))//creates a txt file called username
//                    {
//                        foreach (string date in time)
//                        {
//                            writer.WriteLine(date);//adds a new line to the txt file for the user
//                        }
//                    }
//                    Console.WriteLine("User Angelegt!");
//                    Console.ReadKey();
//                    break;



//                case "3":
//                case "shutdown":
//                    Console.Clear();
//                    Console.WriteLine("Shutting Down");
//                    Console.ReadKey();
//                    Environment.Exit(0);//closes down the console
//                    break;

//                default:
//                    Console.WriteLine("Unexpected input");
//                    Console.ReadKey();
//                    break;
//            }
//            goto start;

//            menu:
//            Console.Clear();

//            string user = Convert.ToString(username[ID]);
//            Console.WriteLine(@"Main menu 
//Willkommen zurück " + user);
//            Console.WriteLine(@"
//1 logout
//2 Ändere Password
//3 Shutdown");
//            input = Console.ReadLine();
//            input.ToLower();
//            switch (input)
//            {
//                case "1":
//                case "logout":
//                    Console.WriteLine("Willst du dich Ausloggen? y/n");
//                    input = Console.ReadLine();
//                    if (input == "y")
//                    {
//                        login = false;
//                        ID = 0;
//                        Console.WriteLine("Ausgeloggt");
//                        Console.ReadKey();
//                    }
//                    break;

//                case "2":
//                case "Ändere Passwort":
//                    Console.WriteLine("Gib dein neues Passwort ein?");
//                    input = Console.ReadLine();
//                    password[ID] = input;
//                    using (TextWriter writer = File.CreateText(@"C:\Users\samir\source\repos\Börse\Börse\bin\Debug\password.txt"))
//                    {
//                        foreach (string pass in password)
//                        {
//                            writer.WriteLine(pass);
//                        }
//                    }
//                    Console.WriteLine("Passwort geändert!");
//                    Console.ReadKey();
//                    break;

//                case "3":
//                case "shutdown":
//                    Console.Clear();
//                    Console.WriteLine("Shutting down");
//                    Console.ReadKey();
//                    Environment.Exit(0);//closes down the console
//                    break;

//                default:
//                    Console.WriteLine("Unexpected input");
//                    Console.ReadKey();
//                    break;
//            }
//            goto start;


//            Console.ReadKey();
//        }


//    }
//}