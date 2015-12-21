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
    public partial class NurseMenu : Form
    {
        public NurseMenu()
        {
            InitializeComponent();

            RefreshListBox();
        }

        //A method to refresh and show all the Nurse in the XML file.
        public void RefreshListBox()
        {
            NameListBox.Items.Clear();
            IDListBox.Items.Clear();

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("NurseDetails.xml"); //Opening of existing XML file

            foreach (XmlNode node in xmlDoc.SelectNodes("NurseDetails/Nurse")) //Display every PatientID node in the XML file using a foreach loop

                IDListBox.Items.Add(string.Format(node.SelectSingleNode("NurseID").InnerText));

            foreach (XmlNode node in xmlDoc.SelectNodes("NurseDetails/Nurse")) //Display every FirstName node in the XML file using a foreach loop

                NameListBox.Items.Add(string.Format(node.SelectSingleNode("FirstName").InnerText));
        }
     
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Saving the datails entered by user into XML file.


                Nurse n = new Nurse();

                //Assigning user entered details into Nurse class properties. 
                n.ID = _NurseID.Text.ToUpper();
                n.FirstName = _FirstName.Text.ToUpper();
                n.LastName = _LastName.Text.ToUpper();
                n.Age = Convert.ToInt32(_AgeNumericUpDown.Value);
                n.Gender = _Gender.Text.ToUpper();
                n.Rank = Convert.ToInt32(_RankComboBox.Text);
                n.WardID = _AssignedWardComboBox.Text;

                //Saving user details into XML file.
                n.AddPerson();

                //Updating the ID generator.
                n.SaveGeneratedID();

                //feedback for user as shown on the GUI. 
                feedbackLabel.Text = "Content Saved!";

                RefreshListBox();

                Ward ward = new Ward();
                ward.WardID = _AssignedWardComboBox.Text;
                ward.NurseID = _NurseID.Text.ToUpper();
                ward.NurseFN = _FirstName.Text.ToUpper();
                ward.NurseLN = _LastName.Text.ToUpper();
                ward.NurseRank = Convert.ToInt32(_RankComboBox.Text);
                ward.AddNurse();

                SaveButton.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please Complete the Form!");
            }
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                Nurse nurse = new Nurse();

                //Assigning user input into Nurse class property(ID).
                nurse.ID = SearchNurseID.Text;

                //Executing FindPerson method
                nurse.FindPerson();

                //Displaying stored value in the Patient class properties onto assigned text boxes.
                DisplayFN.Text = nurse.FirstName;
                DisplayLN.Text = nurse.LastName;
                DisplayA.Text = (nurse.Age).ToString();
                DisplayG.Text = nurse.Gender;
                DisplayR.Text = (nurse.Rank).ToString();
                DisplayAW.Text = nurse.WardID;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //assigning the selected item in the listbox onto the SearchNurseID textbox
            SearchNurseID.Text = IDListBox.SelectedItem.ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Delete the nurse's records from the Ward's XML file
                Ward ward = new Ward();
                ward.NurseID = SearchNurseID.Text.ToUpper();
                ward.WardID = DisplayAW.Text.ToUpper();
                ward.DeleteNurse();

                //Delete the nurse's records from the NurseDetails XML file
                Nurse nurse = new Nurse();
                nurse.ID = SearchNurseID.Text.ToUpper();
                nurse.DeletePerson();
                RefreshListBox();
            }
            catch
            {
                MessageBox.Show("Please make sure you have entered a valid NurseID!");
            }
        }

        private void NidGen_Click(object sender, EventArgs e)
        {
            Nurse n = new Nurse();

            //assigning the generated NurseID onto the _NurseID textbox
            _NurseID.Text = n.AutoGenerateID();
            SaveButton.Enabled = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
