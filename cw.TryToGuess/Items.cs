using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw.TryToGuess
{
    [Serializable]
    public class Items : Category // наследование от класса категори
    {
        public List<string> FirstSetOfItems = new List<string>(); // animals

        public List<string> SecondSetOfItems = new List<string>(); // birds

        public List<string> FirstSetOfImages = new List<string>();

        public List<string> SecondSetOfImages = new List<string>();

        public Items(int CategoryNumber, string CategoryName, int BestScore, List<string> FirstSetOfItems, List<string> FirstSetOfImages,
            List<string> SecondSetOfItems, List<string> SecondSetOfImages) //передача параметров 
            : base(CategoryNumber, CategoryName, BestScore)
        {
            this.FirstSetOfItems = FirstSetOfItems;
            this.FirstSetOfImages = FirstSetOfImages; //обращение к переменной класса
            this.SecondSetOfItems = SecondSetOfItems;
            this.SecondSetOfImages = SecondSetOfImages;
        }
        public Items()
        {

        }
    }
    
}
