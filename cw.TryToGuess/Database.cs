using System;
using System.Collections.Generic;
using System.Xml.Serialization; // для серализации

namespace cw.TryToGuess
{
    [Serializable] // для сериализации
    [XmlInclude(typeof(Items))] // тоже!
    public class Database
    {
        public List<Category> Category = new List<Category>(); // лист классов CATEGORY, хранит экземпляры класса категори
        public Database()
        {

        } // пустой конструктор
    }
}

