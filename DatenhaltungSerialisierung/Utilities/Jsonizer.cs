using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit.DatenhaltungSerialisierung.Utilities
{
    public static class Jsonizer<T>
    {
        public static Stream Serialize( T data )
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer( typeof( T ) );
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject( ms, data );
                ms.Position = 0;

                return ms;
            }
            catch { return null; }
        }

        public static String SerializeToString( T data )
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer( typeof( T ) );
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject( ms, data );
                ms.Position = 0;

                StreamReader sr = new StreamReader( ms );

                return sr.ReadToEnd();
            }
            catch { return ""; }
        }

        public static T Deserialize( Stream dataStream )
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer( typeof( T ) );
                return ( T )serializer.ReadObject( dataStream );
            }
            catch { return default( T ); }
        }

        public static T Deserialize( String dataString )
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer( typeof( T ) );
                MemoryStream ms = new MemoryStream();
                StreamWriter sw = new StreamWriter( ms );

                sw.Write( dataString );
                sw.Flush();
                ms.Position = 0;

                return ( T )serializer.ReadObject( ms );
            }
            catch { return default( T ); }
        }
    }
}
