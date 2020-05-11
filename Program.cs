using System;

namespace SaveToXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Wiktor", "Artymowicz", 28);
            Person person2 = new Person("Anna", "Dąbrowska", 30);
            Basket basket = new Basket(28.34, 4);
            Basket basket2 = new Basket(34.23, 7);

            XMLFile<Person> xMLFilePerson = new XMLFile<Person>();
            xMLFilePerson.AddToList(person);
            xMLFilePerson.AddToList(person2);

            xMLFilePerson.SaveToXML();

            Console.WriteLine();

            XMLFile<Basket> xMLFileBasket = new XMLFile<Basket>();
            xMLFileBasket.AddToList(basket);
            xMLFileBasket.AddToList(basket2);
            xMLFileBasket.SaveToXML();

            Console.WriteLine();
        }
    }
}
