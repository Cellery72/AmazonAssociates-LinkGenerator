//       Program: Amazon Associates Referral Link Generator
//        Author: Justin Ellery
//          Date: June 18th 2017
//   Description: This simple application creates referral links based on a user's tracking ID and product ASIN specified.

using System;
using System.Windows.Forms;

namespace AmazonAssociatesGenerator_POC
{
    public partial class MainForm : Form
    {

        private string referralLink = "";
        public MainForm()
        {
            InitializeComponent();
        }


        // private functions
        // *****************

        private void toggleLinks(bool enabled)
        {
            this.linkReferral.Visible = enabled;
            this.linkTester.Visible = enabled;
            this.linkCopy.Visible = enabled;
        }
        private bool ValidDetails(int country, string ID, string ASIN, out string errorMsg)
        {
            bool returnValue = true;
            errorMsg = "";

            if(country==-1)
            {
                errorMsg = String.Concat(errorMsg, "No country selected" + Environment.NewLine);
                returnValue = false;
            }
            if(ID=="")
            {
                errorMsg = String.Concat(errorMsg, "No Tracking ID provided." + Environment.NewLine);
                returnValue = false;
            }
            if(ASIN=="")
            {
                errorMsg = String.Concat(errorMsg, "No Product ASIN provided." + Environment.NewLine);
                returnValue = false;
            }

            return returnValue;
        }

        


        // event handlers
        // **************

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string output = "";
            if (!ValidDetails(cbCountry.SelectedIndex,tbTrackingID.Text,tbASIN.Text,out output))
            {
                MessageBox.Show(this,output,"Opps, you forgot something!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                switch (cbCountry.SelectedIndex)
                {
                    case 0:
                        {
                            // CANADA
                            this.referralLink = "http://www.amazon.ca/dp/" + tbASIN.Text + "/?tag=" + tbTrackingID.Text;
                            break;
                        }
                    case 1:
                        {
                            // UNITED STATES
                            this.referralLink = "http://www.amazon.com/dp/" + tbASIN.Text + "/?tag=" + tbTrackingID.Text;
                            break;
                        }
                }
                this.toggleLinks(true);
            }
        }

        private void linkJustin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://justinellery.ca");
        }
        private void linkGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Cellery72/AmazonAssociates-LinkGenerator");
        }
        private void linkTester_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string outLink="";
            if (cbCountry.SelectedIndex==0)
            {
                outLink = Properties.Resources.testLinkCanada;
            }
            else if(cbCountry.SelectedIndex==1)
            {
                outLink = Properties.Resources.testLinkUnitedStates;
            }
            // open the tester link
            System.Diagnostics.Process.Start(outLink);
        }
        private void linkCopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(this.referralLink);
        }
        private void linkReferral_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.referralLink);
        }
    }
}
