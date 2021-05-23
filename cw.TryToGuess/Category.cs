using System;

namespace cw.TryToGuess
{
    [Serializable]
    public abstract class Category : IComparable<Category>
    {
        private int categorynumber;
        public int CategoryNumber
        {
            get { return categorynumber; }
            set { if (value < 0 || value > 50) { throw new ArgumentOutOfRangeException(); } else { categorynumber = value; } } // проверка введённых данных
        }
        public string CategoryName { get; set; }

        private int bestscore;
        public int ScoreToUnlock
        {
            get { return bestscore; }
            set { if (value < 0 || value > 1500) { throw new ArgumentOutOfRangeException(); } else { bestscore = value; } }
        }
        public Category(int CategoryNumber, string CategoryName, int ScoreToUnlock) //параметры в скобках
        {
            this.CategoryNumber = CategoryNumber;
            this.CategoryName = CategoryName; //обращение к переменным этого класса
            this.ScoreToUnlock = ScoreToUnlock;
        }
        public Category()
        {
            //конструктор
        }
        public int CompareTo(Category other) //сравнение
        {
            return CategoryNumber.CompareTo(other.CategoryNumber);
        }
    }
}
