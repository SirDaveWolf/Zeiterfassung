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

                //If User = Admin
                RenderAdminView();

                //If User = User
                RenderUserView();
            }
        }

        static void RenderAdminView()
        {
            Console.Clear();
            Console.WriteLine("Menü - bitte wählen Sie aus: ");
            Console.WriteLine("1 - Startseite");
            Console.WriteLine("2 - Mitarbeiterverwaltung");
            Console.WriteLine("3 - Projektverwaltung");
            Console.WriteLine("4 - Optionen");
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
                default:
                    {
                        RenderAdminView();
                    }
                    break;
            }
        }

        static void RenderUserView()
        {
            Console.Clear();
            Console.WriteLine("Menü - bitte wählen Sie aus: ");
            Console.WriteLine("1 - Startseite");
            Console.WriteLine("2 - Optionen");
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

                default:
                    {
                        RenderUserView();
                    }
                    break;
            }
        }

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
                //Schreibe in die Datenbank
            }

            else if (richtig == "n")
            {
                RenderStartseite();
            }

            else
            {
                RenderStartseite();
            }
        }

        static void RenderAdminMitarbeiterMenü()
        {
            Console.Clear();
            Console.WriteLine("Mitarbeiterverwaltung");
            Console.WriteLine("1 - Mitarbeiter editieren");
            Console.WriteLine("2 - Neuen Mitarbeiter anlegen");
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
                default:
                    {
                        RenderAdminMitarbeiterMenü();
                    }
                    break;
            }

        }

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
        }

        static void RenderAdminProjektMenü()
        {
            Console.Clear();
            Console.WriteLine("Projektverwaltung");
            Console.WriteLine("1 - Ein Projekt bearbeiten");
            Console.WriteLine("2 - Neues Projekt anlegen");
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
                default:
                    {
                        RenderAdminProjektMenü();
                    }
                    break;
            }
        }

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
        }

        static void RenderOptionen()
        {
            Console.Clear();
            Console.WriteLine("Passwort ändern");
            Console.WriteLine("Altes Passwort eingeben: ");
            var passwortAlt = Console.ReadLine();
            Console.WriteLine("Neues Passwort eingeben: ");
            var passwortNeu = Console.ReadLine();
        }

        static void HandleInput()
        {
            var info = Console.ReadLine();

            if (info.Contains("ja"))
            {
            }

            if (info.Contains("exit"))
            {
                appIsRunning = false;
            }
        }
    }
}
