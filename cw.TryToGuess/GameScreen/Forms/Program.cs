using cw.TryToGuess.GameScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cw.TryToGuess
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database database = new Database();
            XML xml = new XML();
            string path = "database.xml";


            List<string> testingList1 = new List<string>() { "Apple", "Banana", "Orange", "Mango", "Blueberry", "Lemon", "Avacado", "Grusha", "Kiwi",
            "Peach", "Pineapple", "Strawberry"};
            List<string> testingList2 = new List<string>() { "Onion", "Carrot", "Pumpkin", "Cucumber", "Tomato", "Broccoli", "Aubergine", "Beet",
            "Cabbage", "Garlic", "Pea", "Potato"};

            List<string> testingListImg1 = new List<string>() { "../../img/fruit/fruit_apple.png", "../../img/fruit/fruit_banana.png",
                "../../img/fruit/fruit_orange.png", "../../img/fruit/fruit_mango.png", "../../img/fruit/fruit_blueberry.png",
                "../../img/fruit/fruit_lemon.png", "../../img/fruit/fruit_avacado.png", "../../img/fruit/fruit_grusha.png", "../../img/fruit/fruit_kiwi.png",
                "../../img/fruit/fruit_peach.png", "../../img/fruit/fruit_pineapple.png", "../../img/fruit/fruit_strawberry.png" };
            List<string> testingListImg2 = new List<string>() { "../../img/vegetables/vegetables_onion.png", "../../img/vegetables/vegetables_carrot.png",
                "../../img/vegetables/vegetables_pumpkin.png", "../../img/vegetables/vegetables_cucumber.png", "../../img/vegetables/vegetables_tomato.png",
                "../../img/vegetables/vegetables_broccoli.png", "../../img/vegetables/vegetables_aubergine.png", "../../img/vegetables/vegetables_beet.png",
                , "../../img/vegetables/vegetables_cabbage.png", "../../img/vegetables/vegetables_garlic.png", "../../img/vegetables/vegetables_pea.png", "../../img/vegetables/vegetables_potato.png" };

            List<string> testingList3 = new List<string>() { "Cat", "Dog", "Cow", "Bull", "Rabbit", "Fox", "Beaver", "Lion", "Melaml", "Pig", "Squirrel", "Tiger" };
            List<string> testingList4 = new List<string>() { "Calibri", "Pigeon", "Eagle", "Falcon", "Bullfinch", "Parrot", "Albatross", "Crow", "Duck", "Gull", "Sparrow", "Penguin" };

            List<string> testingListImg3 = new List<string>() { "../../img/animals/animals_cat.png", "../../img/animals/animals_dog.png",
                "../../img/animals/animals_cow.png", "../../img/animals/animals_bull.png", "../../img/animals/animals_rabbit.png",
                "../../img/animals/animals_fox.png", "../../img/animals/animals_beaver.png", "../../img/animals/animals_melamp.png", "../../img/animals/animals_pig.png"
            , "../../img/animals/animals_squirrel.png", "../../img/animals/animals_tiger.png"};
            List<string> testingListImg4 = new List<string>() { "../../img/birds/birds_calibri.png", "../../img/birds/birds_pigeon.png",
                "../../img/birds/birds_eagle.png", "../../img/birds/birds_falcon.png", "../../img/birds/birds_bullfinch.png",
                "../../img/birds/birds_parrot.png", "../../img/birds/birds_albatross.png", "../../img/birds/birds_crow.png",
                "../../img/birds/birds_duck.png", "../../img/birds/birds_gull.png", "../../img/birds/birds_spawword.png", "../../img/birds/birds_penguin.png" };


            database.Category.Add(new Items(1, "ФРУКТЫ;ОВОЩИ", 15, testingList1, testingListImg1, testingList2, testingListImg2));

            database.Category.Add(new Items(2, "ЖИВОТНЫЕ;ПТИЦЫ", 30, testingList3, testingListImg3, testingList4, testingListImg4));
            //////                                   |что идет первым будет за ферст а что вторым за секонд

            xml.Serializer(database, path);

            //xml.Deserialize(ref database, path);

            //User[] users = new User[] { new User("Mike", 12, 1), new User("JUICE", 27, 2), new User("Kennedy", 3, 1) };
           

            DatabaseActions dbActions = new DatabaseActions(database, 1);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ScoreTable(users));

            Application.Run(new TryToGuess_GameScreen(database, dbActions));
        }
    }
}
