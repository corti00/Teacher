using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Teacher.Data;
using Polenter.Serialization;



namespace Teacher.Logic
{
    class SaveManager
    {

        //Idee Interface für Methoden in Klassen dann implementiert so bekannt welche methoden es gibt
        public static void WriteXML<T>(T obj, string path)
        {
            //Standart XML
            var serializer = new SharpSerializer();

            // serialize
     //       serializer.Serialize(typeof(obj), path);

        }
       
    }
}
