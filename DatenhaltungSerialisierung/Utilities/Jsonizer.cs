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
        public static Stream Serialize(T data) 
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, data);
            ms.Position = 0;

            return ms;
        }

        public static String SerializeToString(T data)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, data);
            ms.Position = 0;

            StreamReader sr = new StreamReader(ms);

            return sr.ReadToEnd();
        }

        public static T Deserialize(Stream dataStream)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            return (T)serializer.ReadObject(dataStream);
        }

        public static T Deserialize(String dataString)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms);

            sw.Write(dataString);
            sw.Flush();
            ms.Position = 0;

            return (T)serializer.ReadObject(ms);
        }
    }
}
