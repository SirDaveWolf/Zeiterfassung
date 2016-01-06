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
            var anfang = DateTime.Parse(Console.ReadLine());
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
                //Success-/Failmeldung
                Console.WriteLine("Eintrag erfolgreich geschrieben!");
                Console.ReadKey();

                Console.WriteLine("Es ist ein Fehler aufgetreten");
                Console.ReadKey();

                /*if (istAdmin == true) 
                {
                    RenderAdminView();
            }
                */

                /*
                 else
                 * {
                 *  RenderUserView();
                 * }
                 */
                
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

            //Datenbank - dazugehörigen Datensatz laden
            Console.WriteLine("1 " + user.Name);
            Console.WriteLine("2 " + user.Vorname);
            Console.WriteLine("3 " + user.EMail);
            Console.WriteLine("4 " + user.Passwort);
            Console.WriteLine("5 " + user.MinArbeitszeit);
            Console.WriteLine("6 " + user.IstAdmin);
            Console.WriteLine("");
            Console.WriteLine("Bitte wählen Sie aus was geändert werden soll: ");
            var auswahlChanges = Console.ReadLine();
            switch (auswahlChanges)
            {
                case "1":
                    {
                        Console.WriteLine("Bitte neuen Namen eingeben: ");
                        var newUserName = Console.ReadLine();
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Bitte neuen Vornamen eingeben: ");
                        var neueUserVorname = Console.ReadLine();
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("Bitte die neue Email-Adresse eingeben: ");
                        var newUserMail = Console.ReadLine();
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("Bitte das neue Passwort eingeben: ");
                        var newUserPasswort = Console.ReadLine();
                    }
                    break;

                case "5":
                    {
                        Console.WriteLine("Bitte die neue Mindestarbeitszeit eingeben: ");
                        var newUserArbeitszeit = Console.ReadLine();
                    }
                    break;

                case "6":
                    {
                        Console.WriteLine("Adminrolle vergeben [j/n] ? ");
                        var newUserAdmin = Console.ReadLine();
                    }
                    break;

            }
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

                Console.WriteLine("Eintrag erfolgreich geschrieben!");
                Console.ReadKey();
                //danach RenderAdminMitarbeiterMenü();

                Console.WriteLine("Es ist ein Fehler aufgetreten");
                Console.ReadKey();
                //danach RenderAdminMitarbeiterMenü();
                
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

            //Datenbank - dazugehörigen Datensatz laden
            Console.WriteLine("1 " + project.Bezeichnung);
            Console.WriteLine("2 " + project.Kurzbeschreibung);
            Console.WriteLine("3 " + project.MaxStundensatz);
            Console.WriteLine("");
            Console.WriteLine("Bitte wählen Sie aus was geändert werden soll: ");
            var auswahlChanges = Console.ReadLine();
            switch (auswahlChanges)
                {
                case "1":
                        {
                            Console.WriteLine("Bitte neue Bezeichnung eingeben: ");
                            var neueProjektBez = Console.ReadLine();
                        }
                    break;

                case "2":
                        {
                            Console.WriteLine("Bitte neue Kurzbeschreibung eingeben: ");
                            var neueProjektKurz = Console.ReadLine();
                        }
                    break;

                case "3":
                    {
                        Console.WriteLine("Bitte den neuen maximalen Stundensatz eingeben: ");
                        var neuerMaxStundensatz = Console.ReadLine();
                    }
                    break;

                }
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

                //Success-/Failmeldung
                Console.WriteLine("Eintrag erfolgreich geschrieben!");
                Console.ReadKey();
                //danach RenderAdminProjektMenü();

                Console.WriteLine("Es ist ein Fehler aufgetreten");
                Console.ReadKey();
                //danach RenderAdminProjektMenü();
                
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

            //Success-/Failmeldung
            Console.WriteLine("Eintrag erfolgreich geschrieben!");
            Console.ReadKey();
            //RenderUserView(); ODER RenderAdminView();

            Console.WriteLine("Es ist ein Fehler aufgetreten");
            Console.ReadKey();
            //RenderUserView(); ODER RenderAdminView();
        }

    }
}
