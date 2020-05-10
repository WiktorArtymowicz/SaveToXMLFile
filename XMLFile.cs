using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SaveToXMLFile
{
    public class XMLFile<T> where T : SaveToXMLFile
    {
        private T _objectToSaveInXML;

        public XMLFile(T value)
        {
            _objectToSaveInXML = value;
        }

        public void SaveToXML()
        {
            XDocument document = XDocument.Parse(_objectToSaveInXML.SaveToXMLFile());
            Console.WriteLine(document);
        }
    }
}
