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
    public partial class WardMenu : Form
    {
        public void RefreshWardListBox()
        {
            //Clearing the items on the WardList ListBox. 
            WardListListBox.Items.Clear();
            

            XmlDocument xmlDoc = new XmlDocument();

            //Opening of existing XML file.
            xmlDoc.Load("WardList.xml");

            //Display every WardID node in the XML file using a foreach loop.
            foreach (XmlNode node in xmlDoc.SelectNodes("AllWard/Ward"))

                WardListListBox.Items.Add(string.Format(node.SelectSingleNode("WardID").InnerText));

        }
        public WardMenu()
        {
            InitializeComponent();

            //Calling of the Refresh ListBox Method
            RefreshWardListBox();
        }

        //ignore
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void WardListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //assigning the selected item in the listbox onto the _WardID textbox
            _WardID.Text = WardListListBox.SelectedItem.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                //Clearing the ListBoxes.
                WardStatus1.Clear(); 
                NurseListBox.Items.Clear();
                NPListBox.Items.Clear();
                CPListBox.Items.Clear();
                RankListBox.Items.Clear();

                XmlDocument xmlDoc = new XmlDocument();

                //Opening of existing XML file.
                xmlDoc.Load(_WardID.Text +".xml");

                //Display every nurse, patient and critical patient ID node in the selected ward XML file using a foreach loop.
                foreach (XmlNode node in xmlDoc.SelectNodes("Ward/Nurse"))
                                  
                    NurseListBox.Items.Add(string.Format(node.SelectSingleNode("NurseID").InnerText));

                foreach (XmlNode node in xmlDoc.SelectNodes("Ward/Nurse"))

                    RankListBox.Items.Add(string.Format(node.SelectSingleNode("Rank").InnerText));          
            
                foreach (XmlNode node in xmlDoc.SelectNodes("Ward/Patient"))

                    NPListBox.Items.Add(string.Format(node.SelectSingleNode("PatientID").InnerText));

                foreach (XmlNode node in xmlDoc.SelectNodes("Ward/CriticalPatient"))

                    CPListBox.Items.Add(string.Format(node.SelectSingleNode("PatientID").InnerText));

                //THE COUNTING AND CONDITIONS CHECKING STARTS HERE
                Ward ward = new Ward();
                ward.WardID = _WardID.Text;

                //Counting of the number of nurse and all the patients
                ward.CountNurse();
                ward.CountPatient();
                ward.CountCriticalPatient();

                //Assigning the counted value onto the read-only textbox
                NurseNum.Text = (ward.NoOfNurse).ToString();
                NPNum.Text = (ward.NoOfPatient).ToString();
                CPNum.Text = (ward.NoOfCritPatient).ToString();

                //Checking the condition
                ward.CheckPatientAndNurseRatio();

                //showing the total patient number
                TotalPNum.Text = (ward.TotalPatient).ToString();

                //showing the results on the rich textbox
                WardStatus1.Text = ward.WardStatus1;

                //giving colour to the output text on the rich textbox
                if (WardStatus1.Text.Contains("WARNING!") == true)
                {
                    //make "warning!" red
                    WardStatus1.Select(0, 8);
                    WardStatus1.SelectionColor = Color.Red;

                    //make the rest blue
                    WardStatus1.Select(9, WardStatus1.TextLength);
                    WardStatus1.SelectionColor = Color.Blue;
                }
                else
                {
                    //everything green colour
                    WardStatus1.Select(0, WardStatus1.TextLength);
                    WardStatus1.SelectionColor = Color.Green;
                }

                //check 2nd conditon
                ward.CheckCritPatientAndNurseRatio();

                //show the total number of nurse with rank 3-5
                RNurseNum.Text = (ward.TotalHighRankedNurse).ToString();

                //show the results
                WardStatus2.Text = ward.WardStatus2;

                if (WardStatus2.Text.Contains("WARNING!") == true)
                {
                    WardStatus2.Select(0, 8);
                    WardStatus2.SelectionColor = Color.Red;
                    WardStatus2.Select(9, WardStatus2.TextLength);
                    WardStatus2.SelectionColor = Color.Blue;
                }
                else
                {
                    WardStatus2.Select(0, WardStatus2.TextLength);
                    WardStatus2.SelectionColor = Color.Green;
                }
         
            }
            catch
            {
                MessageBox.Show("Please Enter the Available WardID!");
            }
        }
    }
}
