using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SaveToXMLFile
{
    public class Person : ISaveToXMLFile
    {
        private string _name = string.Empty;
        private string _surname = string.Empty;
        private int _age = 0;

        public string Name { get => _name; }
        public string Surname { get => _surname; }
        public int Age { get => _age; }

        public Person(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }

        public string ToXML()
        {
            return $@"<Person> <Name>{_name}</Name> <Surname>{_surname}</Surname> <Age>{_age}</Age> </Person>";
        }
    }
}
