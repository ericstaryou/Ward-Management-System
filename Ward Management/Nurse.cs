using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ward_Management
{
    public class Nurse : Person
    {
        public Int32 Rank { get; set; }

        public String WardID { get; set; }

        public override void AddPerson()
        {
            //opening of the Nurse Details XML file 
            //and assigning the value of the property into the XML nodes 
            //adding of a new Nurse records

            XmlDocument doc = new XmlDocument();
            doc.Load("NurseDetails.xml");
            XmlNode nurse = doc.CreateElement("Nurse");

            XmlNode nurseID = doc.CreateElement("NurseID");
            nurseID.InnerText = this.ID;
            nurse.AppendChild(nurseID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.FirstName;
            nurse.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.LastName;
            nurse.AppendChild(lastname);

            XmlNode age = doc.CreateElement("Age");
            age.InnerText = (this.Age).ToString();
            nurse.AppendChild(age);

            XmlNode gender = doc.CreateElement("Gender");
            gender.InnerText = this.Gender;
            nurse.AppendChild(gender);

            XmlNode rank = doc.CreateElement("Rank");
            rank.InnerText = (this.Rank.ToString());
            nurse.AppendChild(rank);

            XmlNode assignedward = doc.CreateElement("WardID");
            assignedward.InnerText = (this.WardID);
            nurse.AppendChild(assignedward);


            doc.DocumentElement.AppendChild(nurse);
            doc.Save("NurseDetails.xml");
        }

        public override void FindPerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("NurseDetails.xml");

            //Looping through all "Nurse" nodes of the root - "NurseDetails"
            foreach (XmlNode node in xDoc.SelectNodes("NurseDetails/Nurse"))

                //Validation of user's input (NurseID) with the "Nurse" nodes
                if (node.SelectSingleNode("NurseID").InnerText == this.ID)
                {
                    this.FirstName = node.SelectSingleNode("FirstName").InnerText;
                    this.LastName = node.SelectSingleNode("LastName").InnerText;
                    this.Age = Convert.ToInt32(node.SelectSingleNode("Age").InnerText);
                    this.Gender = node.SelectSingleNode("Gender").InnerText;
                    this.Rank = Convert.ToInt32(node.SelectSingleNode("Rank").InnerText);
                    this.WardID = node.SelectSingleNode("WardID").InnerText;
                    //break the loop
                    break;
                } 
        }

        public override void DeletePerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("NurseDetails.xml");

            //Looping through all "Nurse" nodes of the root - "NurseDetails"
            foreach (XmlNode node in xDoc.SelectNodes("NurseDetails/Nurse"))
                if (node.SelectSingleNode("NurseID").InnerText == this.ID)
                {
                    //deleting the whole node
                    node.ParentNode.RemoveChild(node);

                    break;
                }

            xDoc.Save("NurseDetails.xml");
        }
        public override void ShowAllPerson()
        {
            throw new NotImplementedException();
        }

        //generate ID
        public override string AutoGenerateID(string initial = "N")
        {
            return base.AutoGenerateID(initial);
        }

        //save generated ID
        public override void SaveGeneratedID(string initial = "N")
        {
            base.SaveGeneratedID(initial);
        }
    }
}
