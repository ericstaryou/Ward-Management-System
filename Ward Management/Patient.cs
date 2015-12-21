using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ward_Management
{
    public class Patient : Person
    {
        public Int32 DaysToBeHospitalised { get; set; }
        public String WardID { get; set; }
        

        public override void AddPerson()
        {
            //opening of the Patient Details XML file 
            //and assigning the value of the property into the XML nodes 
            //adding of a new Patient records

            XmlDocument doc = new XmlDocument();
            doc.Load("PatientDetails.xml");
            XmlNode patient = doc.CreateElement("Patient");

            XmlNode patientID = doc.CreateElement("PatientID");
            patientID.InnerText = this.ID;
            patient.AppendChild(patientID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.FirstName;
            patient.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.LastName;
            patient.AppendChild(lastname);

            XmlNode age = doc.CreateElement("Age");
            age.InnerText = (this.Age).ToString();
            patient.AppendChild(age);

            XmlNode gender = doc.CreateElement("Gender");
            gender.InnerText = this.Gender;
            patient.AppendChild(gender);

            XmlNode daystobehospitalised = doc.CreateElement("DaysToBeHospitalised");
            daystobehospitalised.InnerText = (this.DaysToBeHospitalised).ToString();
            patient.AppendChild(daystobehospitalised);

            XmlNode assignedward = doc.CreateElement("AssignedWard");
            assignedward.InnerText = this.WardID;
            patient.AppendChild(assignedward);

            doc.DocumentElement.AppendChild(patient);
            doc.Save("PatientDetails.xml");

        }

        public override void FindPerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("PatientDetails.xml");

            //Looping through all "Patient" nodes of the root - "PatientDetails"
            foreach (XmlNode node in xDoc.SelectNodes("PatientDetails/Patient"))

               //Validation of user's input (PatientID) with the "Patient" nodes
               if (node.SelectSingleNode("PatientID").InnerText == this.ID)
               {
                  this.FirstName = node.SelectSingleNode("FirstName").InnerText;
                  this.LastName = node.SelectSingleNode("LastName").InnerText;
                  this.Age = Convert.ToInt32(node.SelectSingleNode("Age").InnerText);
                  this.Gender = node.SelectSingleNode("Gender").InnerText;
                  this.DaysToBeHospitalised = Convert.ToInt32(node.SelectSingleNode("DaysToBeHospitalised").InnerText);
                  this.WardID = node.SelectSingleNode("AssignedWard").InnerText;

                  //break the loop
                  break;
               }
        }

        public override void DeletePerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("PatientDetails.xml");

            //Looping through all "Patient" nodes of the root - "PatientDetails"
            foreach (XmlNode node in xDoc.SelectNodes("PatientDetails/Patient"))
                //Validation of user's input (PatientID) with the "Patient" nodes
                if (node.SelectSingleNode("PatientID").InnerText == this.ID)
                {
                    //deleting the whole node
                    node.ParentNode.RemoveChild(node);

                    break;
                }

            xDoc.Save("PatientDetails.xml");
        }

        public override void ShowAllPerson()
        {
            throw new NotImplementedException();
        }

        public virtual void DischargePatient()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("PatientDetails.xml");

            foreach (XmlNode node in xDoc.SelectNodes("PatientDetails/Patient"))
                if (node.SelectSingleNode("PatientID").InnerText == this.ID)
                {
                    node.ParentNode.RemoveChild(node);
                    this.FirstName = node.SelectSingleNode("FirstName").InnerText;
                    this.LastName = node.SelectSingleNode("LastName").InnerText;

                    break;
                }

            xDoc.Save("PatientDetails.xml");


            //saving some details of deleted patient into the discharged patient file
            XmlDocument doc = new XmlDocument();
            doc.Load("DischargedPatient.xml");
            XmlNode d_patient = doc.CreateElement("DischargedPatient");

            XmlNode patientID = doc.CreateElement("PatientID");
            patientID.InnerText = this.ID;
            d_patient.AppendChild(patientID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.FirstName;
            d_patient.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.LastName;
            d_patient.AppendChild(lastname);

            doc.DocumentElement.AppendChild(d_patient);
            doc.Save("DischargedPatient.xml");

        }

        //generate ID
        public override string AutoGenerateID(string initial = "NP")
        {
            return base.AutoGenerateID(initial);
        }

        //save generated ID
        public override void SaveGeneratedID(string initial = "NP")
        {
            base.SaveGeneratedID(initial);
        }
    }
}
