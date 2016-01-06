using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.TUI
{
    class Program
    {
        static Boolean appIsRunning = true;

        static void Main(string[] args)
        {

            while (appIsRunning)
            {
                System.Threading.Thread.Sleep(100);

                Console.WriteLine("LOGIN");
                Console.WriteLine(" ");
                Console.WriteLine("Bitte E-Mail Adresse eingeben: ");
                var eMail = Console.ReadLine();
                Console.WriteLine("Bitte Passwort eingeben: ");
                var passwort = Console.ReadLine();

                //TODO: Login und If User = Admin
                RenderAdminView();

                //TODO: Login und If User = User
                RenderUserView();
            }
        } //Geht zu früh zu ?

        //Admin-Ansicht mit mehr Auswahlmöglichkeiten
        static void RenderAdminView()
        {
            Console.Clear();
            Console.WriteLine("Menü - bitte wählen Sie aus: ");
            Console.WriteLine("1 - Startseite");
            Console.WriteLine("2 - Mitarbeiterverwaltung");
            Console.WriteLine("3 - Projektverwaltung");
            Console.WriteLine("4 - Optionen");
            Console.WriteLine("5 - Logout");
            String auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    {
                        RenderStartseite();
                    }
                    break;

                case "2":
                    {
                        RenderAdminMitarbeiterMenü();
                    }
                    break;

                case "3":
                    {
                        RenderAdminProjektMenü();
                    }
                    break;

                case "4":
                    {
                        RenderOptionen();
                    }
                    break;
                case "5":
                    {
                        //TODO: Logout
                    }
                    break;
                default:
                    {
                        RenderAdminView();
                    }
                    break;
            }
        }

        //User-Ansicht mit den Standard-Auswahlmöglichkeiten
        static void RenderUserView()
        {
            Console.Clear();
            Console.WriteLine("Menü - bitte wählen Sie aus: ");
            Console.WriteLine("1 - Startseite");
            Console.WriteLine("2 - Optionen");
            Console.WriteLine("3 - Logout");
            String auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    {
                        RenderStartseite();
                    }
                    break;

                case "2":
                    {
                        RenderOptionen();
                    }
                    break;

                case "3":
                    {
                        //TODO: Logout
                    }
                    break;

                default:
                    {
                        RenderUserView();
                    }
                    break;
            }
        }

        //Startseite mit Zeiterfassung : accessed by admin and user
        static void RenderStartseite() 
        {
            
            Console.Clear();
            Console.WriteLine("Zeiterfassung");
            Console.WriteLine("Bitte ein Projekt auswählen: ");
            Int32 enumerator = 0;
            /*foreach( var project in Projects )
                {
                    Console.WriteLine( "{0} - {1}", enumerator++, project.ShortDescription );
                }
            Int32 input = Convert.ToInt32( Console.ReadLine() );
            var selectedProject = Projects[ input ];*/

            Console.WriteLine("Um welche Uhrzeit wurde mit der Arbeit begonnen?");
            var anfang = Console.ReadLine();
            Console.WriteLine("Ist diese Zeit abrechenbar [j/n] ?");
            var istAbrechenbar = Console.ReadLine();
            Console.WriteLine("Um welche Uhrzeit wurde die Arbeit beendet?");
            var ende = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Sind alle Angaben richtig [j/n] ?");
            String richtig = Console.ReadLine();

            if (richtig == "j")
            {
                //TODO: Schreibe in die Datenbank
                //danach RenderUserView(); ODER RenderAdminView();
                //Success-/Failmeldung ?
            }

            else if (richtig == "n")
            {
                RenderStartseite();
                //Info, dass Werte zurückgesetzt werden ?
            }

            else
            {
                RenderStartseite();
                //Meldung unzulässige Eingabe ?
            }
        }

        //seperates Menü für den Admin - Mitarbeiterverwaltung
        static void RenderAdminMitarbeiterMenü()
        {
            Console.Clear();
            Console.WriteLine("Mitarbeiterverwaltung");
            Console.WriteLine("1 - Mitarbeiter editieren");
            Console.WriteLine("2 - Neuen Mitarbeiter anlegen");
            Console.WriteLine("3 - Zurück zum Hauptmenü");
            var auswahlMitarbeiter = Console.ReadLine();

            switch(auswahlMitarbeiter)
            {
                case "1":
                    {
                        RenderAdminMitarbeiterEdit();
                    }
                    break;
                case "2":
                    {
                        RenderAdminMitarbeiterNeu();
                    }
                    break;
                case "3":
                    {
                        RenderAdminView();
                    }
                    break;
                default:
                    {
                        RenderAdminMitarbeiterMenü();
                        //Meldung unzulässige Eingabe ?
                    }
                    break;
            }

        }

        //Mitarbeitereditor
        static void RenderAdminMitarbeiterEdit()
        {
            Console.Clear();
            Console.WriteLine("Einen Mitarbeiter bearbeiten");
            Int32 enumerator = 0;
            /*foreach (var mitarbeiter in Mitarbeiter)
            {
                Console.WriteLine("{0} - {1}", enumerator++, mitarbeiter.Name);
            }
            Int32 input = Convert.ToInt32(Console.ReadLine());
            var selectedMitarbeiter = Mitarbeiter[input];*/
        }

        //neuen Mitarbeiter anlegen
        static void RenderAdminMitarbeiterNeu()
        {
            Console.Clear();
            Console.WriteLine("Einen neuen Mitarbeiter anlegen");
            Console.WriteLine(" ");
            Console.WriteLine("Vorname: ");
            var vorname = Console.ReadLine();
            Console.WriteLine("Nachname: ");
            var nachname = Console.ReadLine();
            Console.WriteLine("E-Mail: ");
            var eMail = Console.ReadLine();
            Console.WriteLine("min. Arbeitszeit: ");
            var minArbeitszeit = Console.ReadLine();
            Console.WriteLine("Ist Admin [j/n] ?");
            var istAdmin = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Sind alle Angaben richtig [j/n] ?");
            String richtig = Console.ReadLine();

            if (richtig == "j")
            {
                //Schreibe in die Datenbank
                //Success-/Failmeldung ?
                //danach RenderAdminMitarbeiterMenü();
                
            }

            else if (richtig == "n")
            {
                RenderStartseite();
                //Info, dass Werte zurückgesetzt werden ?
            }

            else
            {
                RenderStartseite();
                //Meldung unzulässige Eingabe ?
            }
        }

        //seperates Menü für den Admin - Projektverwaltung
        static void RenderAdminProjektMenü()
        {
            Console.Clear();
            Console.WriteLine("Projektverwaltung");
            Console.WriteLine("1 - Ein Projekt bearbeiten");
            Console.WriteLine("2 - Neues Projekt anlegen");
            Console.WriteLine("3 - Zurück zum Hauptmenü");
            var auswahlProjekt = Console.ReadLine();

            switch (auswahlProjekt)
            {
                case "1":
                    {
                        RenderAdminProjektEdit();
                    }
                    break;
                case "2":
                    {
                        RenderAdminProjektNeu();
                    }
                    break;
                case "3":
                    {
                        RenderAdminView();
                    }
                    break;
                default:
                    {
                        RenderAdminProjektMenü();
                        //Meldung unzulässige Eingabe ?
                    }
                    break;
            }
        }

        //Projekteditor
        static void RenderAdminProjektEdit()
        {
            Console.Clear();
            Console.WriteLine("Ein Projekt bearbeiten");
            Int32 enumerator = 0;
            /*foreach (var project in Projects)
            {
                Console.WriteLine("{0} - {1}", enumerator++, project.ShortDescription);
            }
            Int32 input = Convert.ToInt32(Console.ReadLine());
            var selectedProject = Projects[input];*/
        }

        //neues Projekt anlegen
        static void RenderAdminProjektNeu()
        {
            Console.Clear();
            Console.WriteLine("Ein neues Projekt anlegen");
            Console.WriteLine(" ");
            Console.WriteLine("Projektname: ");
            var projektname = Console.ReadLine();
            Console.WriteLine("Beschreibung: ");
            var beschreibung = Console.ReadLine();
            Console.WriteLine("Projektleiter: ");
            var projektleiter = Console.ReadLine();
            Console.WriteLine("angesetzte Zeit: ");
            var minArbeitszeit = Console.ReadLine();
            Console.WriteLine(" ");
            Console.WriteLine("Sind alle Angaben richtig [j/n] ?");
            String richtig = Console.ReadLine();

            if (richtig == "j")
            {
                //TODO: Schreibe in die Datenbank
                //Success-/Failmeldung ?
                //danach RenderAdminProjektMenü();
                
            }

            else if (richtig == "n")
            {
                RenderStartseite();
                //Info, dass Werte zurückgesetzt werden ?
            }

            else
            {
                RenderStartseite();
                //Meldung unzulässige Eingabe ?
            }
        }

        //Optionen mit Passwortänderung : accessed by admin and user 
        static void RenderOptionen()
        {
            Console.Clear();
            Console.WriteLine("Passwort ändern");
            Console.WriteLine("Altes Passwort eingeben: ");
            var passwortAlt = Console.ReadLine();
            Console.WriteLine("Neues Passwort eingeben: ");
            var passwortNeu = Console.ReadLine();
            
            //TODO: Schreibe in die Datenbank
            //Success-/Failmeldung ?
            //RenderUserView(); ODER RenderAdminView();
        }

    }
}
