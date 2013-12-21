using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace TaskRunner.Util
{
    /// <summary>
    /// Rights to use any portion of this code for any Production related purposes
    /// require explicit written permission from the author Johnson Fan and can be
    /// reached at JohnsonFan@yahoo.com.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XmlSerializer<T>
    {

        public static void Serialize(string filePath, T obj)
        {
            XmlSerializer xsr = new XmlSerializer(typeof(T));
            XmlTextWriter writer = new XmlTextWriter(filePath, System.Text.Encoding.UTF8);
            xsr.Serialize(writer, obj);
            writer.Close();
        }

        public static T Deserialize(string filePath)
        {
            XmlSerializer xsr = new XmlSerializer(typeof(T));
            XmlDocument xmlDoc = new XmlDocument();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            XmlTextReader reader = new XmlTextReader(fs);
            T obj = (T)xsr.Deserialize(reader);                     
            fs.Close();
            return obj;
        }


    }
}
