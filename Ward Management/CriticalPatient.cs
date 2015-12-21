using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ward_Management
{
    public class CriticalPatient : Patient
    {
        public String IllnessLevel { get; set; }
        public String SharingWard { get; set; }


        public override void AddPerson()
        {
            //opening of the CriticalPatient Details XML file 
            //and assigning the value of the property into the XML nodes 
            //adding of a new Critical Patient records

            XmlDocument doc = new XmlDocument();
            doc.Load("CriticalPatientDetails.xml");
            XmlNode c_patient = doc.CreateElement("CriticalPatient");

            XmlNode patientID = doc.CreateElement("PatientID");
            patientID.InnerText = this.ID;
            c_patient.AppendChild(patientID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.FirstName;
            c_patient.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.LastName;
            c_patient.AppendChild(lastname);

            XmlNode age = doc.CreateElement("Age");
            age.InnerText = (this.Age).ToString();
            c_patient.AppendChild(age);

            XmlNode gender = doc.CreateElement("Gender");
            gender.InnerText = this.Gender;
            c_patient.AppendChild(gender);

            XmlNode daystobehospitalised = doc.CreateElement("DaysToBeHospitalised");
            daystobehospitalised.InnerText = (this.DaysToBeHospitalised).ToString();
            c_patient.AppendChild(daystobehospitalised);

            XmlNode illnesslevel = doc.CreateElement("IllnessLevel");
            illnesslevel.InnerText = this.IllnessLevel;
            c_patient.AppendChild(illnesslevel);

            XmlNode sharingward = doc.CreateElement("SharingWard");
            sharingward.InnerText = this.SharingWard;
            c_patient.AppendChild(sharingward);

            XmlNode assignedward = doc.CreateElement("AssignedWard");
            assignedward.InnerText = this.WardID;
            c_patient.AppendChild(assignedward);

            doc.DocumentElement.AppendChild(c_patient);
            doc.Save("CriticalPatientDetails.xml");
        }

        public override void FindPerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("CriticalPatientDetails.xml");

            //Looping through all "Patient" nodes of the root - "PatientDetails"
            foreach (XmlNode node in xDoc.SelectNodes("CriticalPatientDetails/CriticalPatient"))

                //Validation of user's input (PatientID) with the "Patient" nodes
                if (node.SelectSingleNode("PatientID").InnerText == this.ID)
                {
                    this.FirstName = node.SelectSingleNode("FirstName").InnerText;
                    this.LastName = node.SelectSingleNode("LastName").InnerText;
                    this.Age = Convert.ToInt32(node.SelectSingleNode("Age").InnerText);
                    this.Gender = node.SelectSingleNode("Gender").InnerText;
                    this.DaysToBeHospitalised = Convert.ToInt32(node.SelectSingleNode("DaysToBeHospitalised").InnerText);
                    this.IllnessLevel = node.SelectSingleNode("IllnessLevel").InnerText;
                    this.SharingWard = node.SelectSingleNode("SharingWard").InnerText;
                    this.WardID = node.SelectSingleNode("AssignedWard").InnerText;

                    //break the loop
                    break;
                } 
        }

        public override void DeletePerson()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("CriticalPatientDetails.xml");

            //Looping through all "CriticalPatient" nodes of the root - "CriticalPatientDetails"
            foreach (XmlNode node in xDoc.SelectNodes("CriticalPatientDetails/CriticalPatient"))
                if (node.SelectSingleNode("PatientID").InnerText == this.ID)
                {
                    //deleting the whole node
                    node.ParentNode.RemoveChild(node);

                    break;
                }

            xDoc.Save("CriticalPatientDetails.xml");
        }
        public override void ShowAllPerson()
        {
            throw new NotImplementedException();
        }

        public override void DischargePatient()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("CriticalPatientDetails.xml");

            foreach (XmlNode node in xDoc.SelectNodes("CriticalPatientDetails/CriticalPatient"))
                if (node.SelectSingleNode("PatientID").InnerText == this.ID)
                {
                    node.ParentNode.RemoveChild(node);
                    this.FirstName = node.SelectSingleNode("FirstName").InnerText;
                    this.LastName = node.SelectSingleNode("LastName").InnerText;

                    break;
                }

            xDoc.Save("CriticalPatientDetails.xml");


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
        public override string AutoGenerateID(string initial = "CP")
        {
            return base.AutoGenerateID(initial);
        }

        //save generated ID
        public override void SaveGeneratedID(string initial = "CP")
        {
            base.SaveGeneratedID(initial);
        }
    }
}
