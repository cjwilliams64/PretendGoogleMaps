using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PretendGoogleMaps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent(); //connects the methods below to support the created form
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //code for the project

            string street = txtBoxStreet.Text; //declaring variables. txtBox are the labels
            string city = txtBoxCity.Text;
            string state = txtBoxState.Text;
            string zipcode = txtBoxZipCode.Text;

            try
            {
                
                StringBuilder queryData = new StringBuilder(); //mutable string of characters. instance!
                queryData.Append("http://maps.google.com/maps?q="); //append method from Google Maps

                if (street != string.Empty)
                {
                    queryData.Append(street + "," + "+");
                }
                if (city != string.Empty)
                {
                    queryData.Append(city + "," + "+");
                }
                if (state != string.Empty)
                {
                    queryData.Append(state + "," + "+");
                }
                if (zipcode != string.Empty)
                {
                    queryData.Append(zipcode + "," + "+");
                }

                webBrowser1.Navigate(queryData.ToString()); //this is a reference to the WB in the form. 
                //Navigate loads the doc at the URL into the WB control. 
                //takes in the queryData string
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString(), "Error");
            }
        }
    }
}
