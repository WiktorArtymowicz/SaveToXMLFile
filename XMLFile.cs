using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace SaveToXMLFile
{
    public class XMLFile<T> where T : ISaveToXMLFile
    {
        private List<T> _itemList = new List<T>();
        private string _data = string.Empty;
        System.Reflection.MemberInfo info = typeof(T);

        public void AddToList(T value)
        {
            _itemList.Add(value);
        }

        public void SaveToXML()
        {
            foreach (var item in _itemList)
            {
                _data += item.ToXML();
            }

            CreateXML();
        }

        private void CreateXML()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml($@"<{info.Name}>{_data}</{info.Name}>");
            XmlNode node = xmlDocument.DocumentElement;

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;

            XmlWriter xmlWriter = XmlWriter.Create($@"{CreateDirectory()}\{info.Name}.xml", xmlWriterSettings);
            xmlDocument.Save(xmlWriter);

            Console.WriteLine($"Typ {info.Name} został zapisany do pliku XML");
        }

        private string CreateDirectory()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory() + "XMLFiles");

            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            return directoryInfo.FullName;
        }
    }
}
