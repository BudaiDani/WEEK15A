using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CreateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Budai = new Employee("Dani", DateTime.Now, 1000, "HS");
            Budai.Room = new Room(111);
            Employee Budai2 = (Employee)Budai.Clone();
            Budai2.Room.Number = 112;

            Console.WriteLine(Budai.ToString());
            Console.WriteLine(Budai2.ToString());
            Console.ReadKey();
            Serialize(Budai);
            Serialize(Budai2);
            Deserialize();
        }

        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, sp);

            fs.Close();
        }

       

        private static Person Deserialize()
        {
            Person dsp = new Person();

            FileStream fs = new FileStream("Person.Dat", FileMode.Open);

            BinaryFormatter bf = new BinaryFormatter();

            dsp = (Person)bf.Deserialize(fs);

            fs.Close();

            return dsp;
        }
    }
}
