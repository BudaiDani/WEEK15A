using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CreateClass
{
    [Serializable]
    class Person : IDeserializationCallback
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        [NonSerialized]
        public int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        public Person()
        {

        }

        public Person(string Name, DateTime birthDate)
        {
            this.Name = Name;
            this.birthDate = birthDate;
        }

        public enum Genders : int { Male, Female };

        public Genders gender;

        public override string ToString()
        {
            return (String.Format("name: {0}, birth date: {1}", this.name, this.birthDate));
        }

        void IDeserializationCallback.OnDeserialization(Object sender)
        {
        }
    }
}
