using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace cw.TryToGuess
{
    class XML
    {
        public XML()
        {

        }
        public void Deserialize(ref Database database, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Database));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                database = (Database)formatter.Deserialize(fs);
            }
        }
        public void Serializer(Database database, string filename) //класс сериализац. в скобках (сслыка на файл )
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Database));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate)) // файлвый поток
            {
                formatter.Serialize(fs, database);
            }
        }

        public void UserSerializer(User[] user, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(User[]));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, user);
            }
        }

        public User[] UserDeserialize(string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(User[]));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                return (User[])formatter.Deserialize(fs);
            }
        }
    }
}
