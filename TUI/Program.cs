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

        static void Main( string[] args )
        {
            while ( appIsRunning )
            {
                System.Threading.Thread.Sleep( 100 );

                RenderMenu();
                HandleInput();
            }
        }

        static void RenderMenu ()
        {
            Console.Clear();
            Console.WriteLine( "Menü" );
        }

        static void HandleInput ()
        {
            var info = Console.ReadLine();

            if ( info.Contains( "ja" ) )
            {
            }

            if ( info.Contains( "exit" ) )
            {
                appIsRunning = false;
            }
        }
    }
}
