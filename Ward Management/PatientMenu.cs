using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ward_Management
{
    public partial class PatientMenu : Form
    {
        //A method to refresh the listbox and show all the NORMAL Patient in the XML file.
        public void RefreshListBox()
        {
            //Clearing the items on in all the NORMAL Patient list boxes before writting on it.
            NameListBox.Items.Clear();
            IDListBox.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();

            //Opening of existing XML file.
            xmlDoc.Load("PatientDetails.xml");

            //Display every PatientID node in the XML file using a foreach loop.
            foreach (XmlNode node in xmlDoc.SelectNodes("PatientDetails/Patient")) 

                IDListBox.Items.Add(string.Format(node.SelectSingleNode("PatientID").InnerText));

            //Display every FirstName node in the XML file using a foreach loop.
            foreach (XmlNode node in xmlDoc.SelectNodes("PatientDetails/Patient")) 

                NameListBox.Items.Add(string.Format(node.SelectSingleNode("FirstName").InnerText));
        }

        //A method to refresh the listbox and show all the CRITICAL Patient in the xml file.
        public void RefreshListBox2()
        {
            NameListBox2.Items.Clear();
            IDListBox2.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("CriticalPatientDetails.xml");

            foreach (XmlNode node in xmlDoc.SelectNodes("CriticalPatientDetails/CriticalPatient")) 

                IDListBox2.Items.Add(string.Format(node.SelectSingleNode("PatientID").InnerText));

            foreach (XmlNode node in xmlDoc.SelectNodes("CriticalPatientDetails/CriticalPatient")) 

                NameListBox2.Items.Add(string.Format(node.SelectSingleNode("FirstName").InnerText));
        }
        public PatientMenu()
        {
            InitializeComponent();

            //Calling of the RefreshListBox method to display all the looped PatientID and Name on the list boxes. 
            RefreshListBox();

            RefreshListBox2();

        }

        //ignore
        private void PatientMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                //Counting the total number of critical patient and normal patient.
                Ward w = new Ward();
                w.WardID = AssignedWard.Text;
                w.CountPatient();
                w.CountCriticalPatient();
                int totalpatient = w.NoOfPatient + w.NoOfCritPatient;

                //To make sure the chosen ward is not full.
                if (totalpatient == 20)
                {
                    MessageBox.Show(w.WardID + " is FULLED! Please select another Ward.");
                }
                else
                {


                    //Saving the datails entered by user into XML file.

                    Patient p = new Patient();

                    //Assigning user entered details into Patient class properties. 
                    p.ID = _PatientID.Text.ToUpper();
                    p.FirstName = _FirstName.Text.ToUpper();
                    p.LastName = _LastName.Text.ToUpper();
                    p.Age = (int)numericUpDown1.Value;
                    p.Gender = _Gender.Text.ToUpper();
                    p.DaysToBeHospitalised = (int)numericUpDown2.Value;
                    p.WardID = AssignedWard.Text.ToUpper();

                    //Saving user details into XML file.
                    p.AddPerson();

                    //Updating the ID generator.
                    p.SaveGeneratedID();

                    //feedback for user as shown on the GUI. 
                    feedback.Text = "Content Saved!";

                    //Refreshing the List Boxes.
                    RefreshListBox();

                    //Saving a record of the entered Patient into the Assigned Ward List.
                    Ward ward = new Ward();
                    ward.WardID = AssignedWard.Text;
                    ward.PatientID = _PatientID.Text.ToUpper();
                    ward.PatientFN = _FirstName.Text.ToUpper();
                    ward.PatientLN = _LastName.Text.ToUpper();
                    ward.AddPatient();

                    //Enabling the Save button.
                    Save.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Please complete the form!");
            }
        }

        //ignore
        private void ShowButton_Click(object sender, EventArgs e)
        {
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try 
            {
                if (NormalPatient.Checked)
                {
                    Patient patient = new Patient();

                    //Assigning user input into Patient class property(ID).
                    patient.ID = SearchPatientID.Text.ToUpper();

                    //Executing FindPerson method
                    patient.FindPerson();

                    //Displaying stored value in the Patient class properties into assigned text boxes.
                    DisplayFN.Text = patient.FirstName;
                    DisplayLN.Text = patient.LastName;
                    DisplayA.Text = (patient.Age).ToString();
                    DisplayG.Text = patient.Gender;
                    DisplayDTBH.Text = (patient.DaysToBeHospitalised).ToString();
                    DisplayAW.Text = patient.WardID;
                }
                else if (CriticalPatient.Checked)
                {
                    CriticalPatient cp = new CriticalPatient();

                    //Assigning user input into CriticalPatient class property(ID).
                    cp.ID = SearchPatientID.Text.ToUpper();

                    //Executing FindPerson method
                    cp.FindPerson();

                    //Displaying stored value in the CriticalPatient class properties into assigned text boxes.
                    DisplayFN.Text = cp.FirstName;
                    DisplayLN.Text = cp.LastName;
                    DisplayA.Text = (cp.Age).ToString();
                    DisplayG.Text = cp.Gender;
                    DisplayDTBH.Text = (cp.DaysToBeHospitalised).ToString();
                    DisplayAW.Text = cp.WardID;
                    DisplayIL.Text = cp.IllnessLevel;
                    DisplayWS.Text = cp.SharingWard;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            DeletePatientButton.Enabled = true;
            DischargePatientButton.Enabled = true;
        }

        private void IDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assigning selected item on the list box to the SearchPatientID textbox only when the NormalPatient radiobutton is checked.
            if (NormalPatient.Checked)
            {
                SearchPatientID.Text = IDListBox.SelectedItem.ToString();
            }
            
        }

        //ignore
        private void label22_Click(object sender, EventArgs e)
        {

        }

        //Deleting a patient and his/her details (Death of a Patient)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (NormalPatient.Checked)
                {
                    //Deleting the patient's record in the Ward XML file
                    Ward ward = new Ward();
                    ward.PatientID = SearchPatientID.Text.ToUpper();
                    ward.WardID = DisplayAW.Text.ToUpper();
                    ward.DeletePatient();

                    //Deleting the patient's record in the PatientDetails XML file
                    Patient patient = new Patient();
                    patient.ID = SearchPatientID.Text.ToUpper();
                    patient.DeletePerson();
                    RefreshListBox();                   
                }
                else if (CriticalPatient.Checked)
                {
                    //Deleting the Critical patient's record in the Ward XML file
                    Ward ward = new Ward();
                    ward.PatientID = SearchPatientID.Text.ToUpper();
                    ward.WardID = DisplayAW.Text.ToUpper();
                    ward.DeleteCriticalPatient();

                    //Deleting the Critical patient's record in the CriticalPatientDetails XML file
                    CriticalPatient cp = new CriticalPatient();
                    cp.ID = SearchPatientID.Text.ToUpper();
                    cp.DeletePerson();
                    RefreshListBox2();                    
                }
                else
                {
                    MessageBox.Show("Please choose a type of patient and enter a patiendID!");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ignore
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //ignore
        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void CSave_Click(object sender, EventArgs e)
        {
            try
            {
                //Counting of Patient and Critical Patient in the ward
                Ward w = new Ward();
                w.WardID = CWardID.Text;
                w.CountPatient();
                w.CountCriticalPatient();
                int totalpatient = w.NoOfPatient + w.NoOfCritPatient;

                if (totalpatient == 20)
                {
                    MessageBox.Show(w.WardID + " is FULLED! Please select another Ward.");
                }
                else
                {
                    //Saving the datails entered by user into XML file.


                    CriticalPatient cp = new CriticalPatient();

                    //Assigning user entered details into CriticalPatient class properties. 
                    cp.ID = CPatientID.Text.ToUpper();
                    cp.FirstName = CFirstName.Text.ToUpper();
                    cp.LastName = CLastName.Text.ToUpper();
                    cp.Age = (int)CAge.Value;
                    cp.Gender = CGender.Text.ToUpper();
                    cp.DaysToBeHospitalised = (int)CDaysToBeHospitalised.Value;
                    cp.IllnessLevel = CIllnessLevel.Text.ToUpper();
                    cp.SharingWard = CWardSharing.Text.ToUpper();
                    cp.WardID = CWardID.Text.ToUpper();

                    //Saving user details into XML file.
                    cp.AddPerson();

                    //Updating the ID generator.
                    cp.SaveGeneratedID();

                    //feedback for user as shown on the GUI. 
                    Cfeedback.Text = "Content Saved!";

                    RefreshListBox2();

                    //Adding the details of this patient to the assigned ward's XML file
                    Ward ward = new Ward();
                    ward.WardID = CWardID.Text.ToUpper();
                    ward.PatientID = CPatientID.Text.ToUpper();
                    ward.PatientFN = CFirstName.Text.ToUpper();
                    ward.PatientLN = CLastName.Text.ToUpper();
                    ward.AddCriticalPatient();

                    //enalbles the save button
                    CSave.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Please complete the form!");
            }
        }

        private void IDListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Assigning selected item on the list box to the SearchPatientID textbox only when the CriticalPatient radiobutton is checked.
            if (CriticalPatient.Checked)
            {
                SearchPatientID.Text = IDListBox2.SelectedItem.ToString();
            }
            
        }
        
        //Clearing all the Text Boxes in the Search Patient tab menu when the NormalPatient radiobutton is checked.
        private void NormalPatient_CheckedChanged(object sender, EventArgs e)
        {
            DisplayFN.Clear();
            DisplayLN.Clear();
            DisplayA.Clear();
            DisplayG.Clear();
            DisplayDTBH.Clear();
            DisplayAW.Clear();
            DisplayIL.Clear();
            DisplayWS.Clear();

            SearchButton.Enabled = true;
      
            IDListBox.Enabled = true;
            IDListBox2.Enabled = false;
            SearchPatientID.Clear();
            SearchPatientID.Focus();

            DeletePatientButton.Enabled = false;
            DischargePatientButton.Enabled = false;
            

        }

        //Clearing all the Text Boxes in the Search Patient tab menu when the CriticalPatient radiobutton is checked.
        private void CriticalPatient_CheckedChanged(object sender, EventArgs e)
        {
            DisplayFN.Clear();
            DisplayLN.Clear();
            DisplayA.Clear();
            DisplayG.Clear();
            DisplayDTBH.Clear();
            DisplayAW.Clear();
            DisplayIL.Clear();
            DisplayWS.Clear();

            SearchButton.Enabled = true;
            
            IDListBox2.Enabled = true;
            IDListBox.Enabled = false;
            SearchPatientID.Clear();
            SearchPatientID.Focus();

            DeletePatientButton.Enabled = false;
            DischargePatientButton.Enabled = false;
        }

        //Discharging a patient - Deleting his/her details while recording their ID and name in a DischargedPatient XML file. 
        private void DischargePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (NormalPatient.Checked)
                {
                    //Delete the Patient's record from his hospitalised ward's XML file
                    Ward ward = new Ward();
                    ward.PatientID = SearchPatientID.Text.ToUpper();
                    ward.WardID = DisplayAW.Text.ToUpper();
                    ward.DeletePatient();

                    //Delete the Patient's recod from PatientDetails XML file.
                    Patient patient = new Patient();
                    patient.ID = SearchPatientID.Text.ToUpper();
                    patient.DischargePatient();
                    RefreshListBox();
                }
                else if (CriticalPatient.Checked)
                {
                    Ward ward = new Ward();
                    ward.PatientID = SearchPatientID.Text.ToUpper();
                    ward.WardID = DisplayAW.Text.ToUpper();
                    ward.DeleteCriticalPatient();

                    CriticalPatient cp = new CriticalPatient();
                    cp.ID = SearchPatientID.Text.ToUpper();
                    cp.DischargePatient();
                    RefreshListBox2();
                }
                else
                {
                    MessageBox.Show("Please choose a type of patient and key in a patientID!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenerateIDbutton_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            
            //assigning the generated PatientID into the read-only patientID textbox
            _PatientID.Text = p.AutoGenerateID();
            Save.Enabled = true;
        }

        private void CPidGen_Click(object sender, EventArgs e)
        {
            CriticalPatient cp = new CriticalPatient();

            //assigning the generated CriticalPatientID into the read-only CPatientID textbox
            CPatientID.Text = cp.AutoGenerateID();
            CSave.Enabled = true;
        }
    }
}
