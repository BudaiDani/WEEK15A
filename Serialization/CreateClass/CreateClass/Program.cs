﻿using System;
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
            Employee Kovacs2 = (Employee)Budai.Clone();
            Kovacs2.Room.Number = 112;

            Console.WriteLine(Budai.ToString());
            Console.WriteLine(Kovacs2.ToString());
            Console.ReadKey();
        }

        private static void Serialize(Person sp)
        {
            FileStream fs = new FileStream("Person.Dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, sp);

            fs.Close();
        }
    }
}
