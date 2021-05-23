using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw.TryToGuess
{
    public class DatabaseActions
    {
        Database database; // заготовка что мы что-то запишем 

        private Dictionary<string, string> FirstDictionary = new Dictionary<string, string>(); //словарь

        private Dictionary<string, string> SecondDictionary = new Dictionary<string, string>(); // словарь 

        public bool rightSide;

        public int ScoreToUnlock;

        public string[] LevelName;
        public DatabaseActions()
        {

        }
        public DatabaseActions(Database database, int level) //класс
        {
            this.database = database;

            CategoryUpload(level); //функция
        }
        private void ToDictionary(List<string> FirstSetOfItems, List<string> FirstSetOfImages,
            List<string> SecondSetOfItems, List<string> SecondSetOfImages)
        {
            for (int i = 0; i < FirstSetOfItems.Count(); i++)
            {
                FirstDictionary.Add(FirstSetOfItems[i], FirstSetOfImages[i]);

                SecondDictionary.Add(SecondSetOfItems[i], SecondSetOfImages[i]);
            }
        }
        public bool CategoryUpload(int level)
        {
            FirstDictionary.Clear(); //очищение двух словарей 
            SecondDictionary.Clear();

            foreach (var category in database.Category) //цикл
            {
                if (level == category.CategoryNumber)
                {
                    LevelName = category.CategoryName.Split(';'); //разделяет на массивы строк 
                    ToDictionary(((Items)category).FirstSetOfItems, ((Items)category).FirstSetOfImages, // запись в класс итемс
                        ((Items)category).SecondSetOfItems, ((Items)category).SecondSetOfImages);
                    ScoreToUnlock = category.ScoreToUnlock;

                    return true;
                }
            }

            return false;
        }
        public string ChooseItemsToCompare() //выбор что будем сравнивать
        {
            Random rnd = new Random();
            int rand = rnd.Next(0, FirstDictionary.Count); //передаём 0 и кол-во эл в словаре
            if (rnd.Next(1, 3) == 1) //если выпадает 1, то->
            {
                foreach (KeyValuePair<string, string> keyValue in FirstDictionary)
                {
                    rightSide = true;

                    return FirstDictionary.ElementAt(rand).Value; //вернёт элемент из первого словаря под заданным номером 
                }
            }
            else
            {
                foreach (KeyValuePair<string, string> keyValue in SecondDictionary)
                {
                    rightSide = false;

                    return SecondDictionary.ElementAt(rand).Value;
                }
            }

            return null;
        }
    }
}
