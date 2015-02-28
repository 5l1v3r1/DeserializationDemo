using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using deserialization_Demo.Classes;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;

namespace deserialization_Demo
{
    public partial class Form1 : Form
    {
        string personPath = @"C:\Users\Admin\Desktop\tmpObjects\person.obj";
        string adminPath = @"C:\Users\Admin\Desktop\tmpObjects\admin.obj";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSettup_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            Person person = new Person();

            SerializationHelper.SerializeToBinaryFile(adminPath, admin);
            SerializationHelper.SerializeToBinaryFile(personPath, person);
        }

        private void btnLoadPerson_Click(object sender, EventArgs e)
        {
            Person person = SerializationHelper.DeserializeFromBinaryFile<Person>(personPath);
            lblOut.Text = person.GetText();            
        }

        private void btnLoadAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = SerializationHelper.DeserializeFromBinaryFile<Person>(adminPath);
            }
            catch(Exception ex)
            {
                GC.Collect();
                lblOut.Text = "Cast Exception!";
            }
            
            
        }


    }
}
