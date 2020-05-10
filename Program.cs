using System;

namespace SaveToXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Wiktor", "Artymowicz", 28);
            Basket basket = new Basket(28.34, 4);

            XMLFile<Person> xMLFilePerson = new XMLFile<Person>(person);
            xMLFilePerson.SaveToXML();

            Console.WriteLine();

            XMLFile<Basket> xMLFileBasket = new XMLFile<Basket>(basket);
            xMLFileBasket.SaveToXML();

            Console.WriteLine();
        }
    }
}
