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

        public void AddToList(T value)
        {
            _itemList.Add(value);
        }

        public void SaveToXML()
        {
            foreach (var item in _itemList)
            {
                _data += item.SaveToXMLFile();
            }

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml($@"<Data>{_data}</Data>");
            XmlNode node = xmlDocument.DocumentElement;

            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;

            System.Reflection.MemberInfo info = typeof(T);

            XmlWriter xmlWriter = XmlWriter.Create($@"C:\Users\kurt4\Documents\{info.Name}.xml", xmlWriterSettings);
            xmlDocument.Save(xmlWriter);
        }
    }
}
