using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ward_Management
{
    public abstract class Person
    {
        public String ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Int32 Age { get; set; }
        public String Gender { get; set; }

        //an abstract method for the child's class to override (polymorphism)
        public abstract void AddPerson(); 

        public abstract void FindPerson();

        public abstract void DeletePerson();

        public abstract void ShowAllPerson();

        //An auto ID generator. 
        public virtual string AutoGenerateID(string initial)
        {         
            int ID;
            //reading the current latest ID.
            var sr = new StreamReader(initial + "id.txt");
            ID = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            ID++;
            
            //formatting of the ID            
            string PersonID = initial + String.Format("{0:000}", ID);
            return PersonID;
        }

        //Saving of the generated ID
        public virtual void SaveGeneratedID(string initial)
        {
            int ID;

            //reading the current latest ID.
            var sr = new StreamReader(initial + "id.txt");
            ID = Convert.ToInt32(sr.ReadLine());
            sr.Close();

            ID++;

            //saving the incremented ID.
            StreamWriter outputFile;
            outputFile = File.CreateText(initial + "id.txt");
            outputFile.WriteLine(ID);
            outputFile.Close();
            
        }
        
    }
}
