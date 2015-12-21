using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ward_Management
{
    public class Ward
    {
        public String NurseID { get; set; }

        public String NurseFN { get; set; }

        public String NurseLN { get; set; }

        public Int32 NurseRank { get; set; }

        public String PatientID { get; set; }

        public String PatientFN { get; set; }

        public String PatientLN { get; set; }

        public String WardID { get; set; }

        public Int32 NoOfPatient { get; set; }

        public Int32 NoOfCritPatient { get; set; }

        public Int32 NoOfNurse { get; set; }

        public String WardStatus1 { get; set; }

        public String WardStatus2 { get; set; }

        public Int32 TotalPatient { get; set; }

        public Int32 TotalHighRankedNurse { get; set; }

        //Adding of a new Nurse to the assigned ward's XML file
        public void AddNurse()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(this.WardID + ".xml");
            XmlNode nurse = doc.CreateElement("Nurse");

            XmlNode nurseID = doc.CreateElement("NurseID");
            nurseID.InnerText = this.NurseID;
            nurse.AppendChild(nurseID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.NurseFN;
            nurse.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.NurseLN;
            nurse.AppendChild(lastname);

            XmlNode rank = doc.CreateElement("Rank");
            rank.InnerText = (this.NurseRank).ToString();
            nurse.AppendChild(rank);

            doc.DocumentElement.AppendChild(nurse);
            doc.Save(this.WardID + ".xml");
        }

        //Adding of a new Patient to the assigned ward's XML file
        public void AddPatient()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(this.WardID + ".xml");
            XmlNode patient = doc.CreateElement("Patient");

            XmlNode patientID = doc.CreateElement("PatientID");
            patientID.InnerText = this.PatientID;
            patient.AppendChild(patientID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.PatientFN;
            patient.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.PatientLN;
            patient.AppendChild(lastname);


            doc.DocumentElement.AppendChild(patient);
            doc.Save(this.WardID + ".xml");
        }

        //Adding of a new Critical Patient to the assigned ward's XML file
        public void AddCriticalPatient()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(this.WardID + ".xml");
            XmlNode c_patient = doc.CreateElement("CriticalPatient");

            XmlNode patientID = doc.CreateElement("PatientID");
            patientID.InnerText = this.PatientID;
            c_patient.AppendChild(patientID);

            XmlNode firstname = doc.CreateElement("FirstName");
            firstname.InnerText = this.PatientFN;
            c_patient.AppendChild(firstname);

            XmlNode lastname = doc.CreateElement("LastName");
            lastname.InnerText = this.PatientLN;
            c_patient.AppendChild(lastname);            

            doc.DocumentElement.AppendChild(c_patient);
            doc.Save(this.WardID + ".xml");
        }

        //Count the number of nurse in the ward's XML file
        public void CountNurse()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(this.WardID + ".xml");
            this.NoOfNurse = Doc.SelectNodes("Ward/Nurse").Count;
        }

        //Count the number of patient in the ward's XML file
        public void CountPatient()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(this.WardID + ".xml");
            this.NoOfPatient = Doc.SelectNodes("Ward/Patient").Count;
        }

        //Count the number of Critical Patient in the ward's XML file
        public void CountCriticalPatient()
        {
            XmlDocument Doc = new XmlDocument();
            Doc.Load(this.WardID + ".xml");
            this.NoOfCritPatient = Doc.SelectNodes("Ward/CriticalPatient").Count;
        }

        //The condition checking method.
        public void CheckPatientAndNurseRatio()
        {
            //getting the total number of patient in the ward
            this.TotalPatient = this.NoOfPatient + this.NoOfCritPatient;

            //Nested if starts here
            if (this.TotalPatient < 5)
            {
                this.WardStatus1 = this.WardID + " is fine.";
            }
            else if (this.TotalPatient >= 5 && this.TotalPatient < 10)
            {
                if (this.NoOfNurse < 1)
                {
                    this.WardStatus1 = "WARNING!" + "\n" + this.WardID + " needs 1 Nurse of any rank.";
                }
                else
                {
                    this.WardStatus1 = this.WardID + " is fine.";
                }
            }
            else if (this.TotalPatient >= 10 && this.TotalPatient < 15)
            {
                if (this.NoOfNurse < 2)
                {
                    int NoOfNurseNeeded = 2 - this.NoOfNurse;
                    this.WardStatus1 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of any rank.";
                }
                else
                {
                    this.WardStatus1 = this.WardID + " is fine.";
                }
            }
            else if (this.TotalPatient >= 15 && this.TotalPatient < 20)
            {
                if (this.NoOfNurse < 3)
                {
                    int NoOfNurseNeeded = 3 - this.NoOfNurse;
                    this.WardStatus1 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of any rank.";
                }
                else
                {
                    this.WardStatus1 = this.WardID + " is fine.";
                }
            }
            else if (this.TotalPatient == 20)
            {
                if (this.NoOfNurse < 4)
                {
                    int NoOfNurseNeeded = 3 - this.NoOfNurse;
                    this.WardStatus1 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of any rank.";
                }
                else
                {
                    this.WardStatus1 = this.WardID + " is fine.";
                }
            }
                                                                                                          
        }

        //The second condition checking method.
        public void CheckCritPatientAndNurseRatio()
        {
            //Get the value of nurse of rank 3-5
            this.CountHighRankedNurse();

            //nested if starts here
            if (this.NoOfCritPatient < 2)
            {
                this.WardStatus2 = this.WardID + " is fine.";
            }
            else if (this.NoOfCritPatient >= 2 && this.NoOfCritPatient < 4)
            {
                if (this.TotalHighRankedNurse < 2)
                {
                    int NoOfNurseNeeded = 2 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 4 && this.NoOfCritPatient < 6)
            {
                if (this.TotalHighRankedNurse < 4)
                {
                    int NoOfNurseNeeded = 4 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 6 && this.NoOfCritPatient < 8)
            {
                if (this.TotalHighRankedNurse < 6)
                {
                    int NoOfNurseNeeded = 6 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 8 && this.NoOfCritPatient < 10)
            {
                if (this.TotalHighRankedNurse < 8)
                {
                    int NoOfNurseNeeded = 8 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 10 && this.NoOfCritPatient < 12)
            {
                if (this.TotalHighRankedNurse < 10)
                {
                    int NoOfNurseNeeded = 10 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 12 && this.NoOfCritPatient < 14)
            {
                if (this.TotalHighRankedNurse < 12)
                {
                    int NoOfNurseNeeded = 12 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 14 && this.NoOfCritPatient < 16)
            {
                if (this.TotalHighRankedNurse < 14)
                {
                    int NoOfNurseNeeded = 14 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 16 && this.NoOfCritPatient < 18)
            {
                if (this.TotalHighRankedNurse < 16)
                {
                    int NoOfNurseNeeded = 16 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient >= 18 && this.NoOfCritPatient < 20)
            {
                if (this.TotalHighRankedNurse < 18)
                {
                    int NoOfNurseNeeded = 18 - this.TotalHighRankedNurse;
                    this.WardStatus2 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus2 = this.WardID + " is fine.";
                }
            }
            else if (this.NoOfCritPatient == 20)
            {
                if (this.TotalHighRankedNurse < 20)
                {
                    int NoOfNurseNeeded = 20 - this.NoOfNurse;
                    this.WardStatus1 = "WARNING!" + "\n" + this.WardID + " needs " + NoOfNurseNeeded + " more Nurse of Rank 3-5.";
                }
                else
                {
                    this.WardStatus1 = this.WardID + " is fine.";
                }
            }
        }

        public void CountHighRankedNurse()
        {
            int rank3 = 0, rank4 = 0, rank5 = 0;

            XmlDocument Doc = new XmlDocument();
            Doc.Load(this.WardID + ".xml");

            //everytime a particular rank of nurse is looped, the value will be incremented by 1. 
            foreach (XmlNode node in Doc.SelectNodes("Ward/Nurse"))
            {
                if (node.SelectSingleNode("Rank").InnerText == "3")
                {
                    rank3++;
                }
                else if (node.SelectSingleNode("Rank").InnerText == "4")
                {
                    rank4++;
                }
                else if (node.SelectSingleNode("Rank").InnerText == "5")
                {
                    rank5++;
                }
            }

            //getting the total number of nurse of rank 3-5
            this.TotalHighRankedNurse = rank3 + rank4 + rank5;
                
        }

        //delete a nurse records from the assigned ward's XML file
        public void DeleteNurse()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(this.WardID + ".xml");

            foreach (XmlNode node in xDoc.SelectNodes("Ward/Nurse"))
                if (node.SelectSingleNode("NurseID").InnerText == this.NurseID)
                {
                    node.ParentNode.RemoveChild(node);

                    break;
                }

            xDoc.Save(this.WardID + ".xml");
        }

        //delete a Patient records from the assigned ward's XML file
        public void DeletePatient()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(this.WardID + ".xml");

            foreach (XmlNode node in xDoc.SelectNodes("Ward/Patient"))
                if (node.SelectSingleNode("PatientID").InnerText == this.PatientID)
                {
                    node.ParentNode.RemoveChild(node);

                    break;
                }

            xDoc.Save(this.WardID + ".xml");
        }

        //delete a Critical Patient records from the assigned ward's XML file
        public void DeleteCriticalPatient()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(this.WardID + ".xml");

            foreach (XmlNode node in xDoc.SelectNodes("Ward/CriticalPatient"))
                if (node.SelectSingleNode("PatientID").InnerText == this.PatientID)
                {
                    node.ParentNode.RemoveChild(node);

                    break;
                }

            xDoc.Save(this.WardID + ".xml");
        }
    }
}
