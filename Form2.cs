using System;
using System.Windows.Forms;

namespace GridDragDropApp
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        // public DonorRecord DonorRecord { get; private set; }

        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
        }

        private void SubmitButton_Click_1(object sender, EventArgs e)
        {
            DonorRecord donorRecord = new DonorRecord
            {
                // Add class object properties
                IDNumber = textBox1.Text,
                SourceCode = textBox2.Text,
                Amount = textBox3.Text,
                ThreeOfAddress = textBox4.Text,
                Change = textBox5.Text,
                Title = textBox6.Text,
                Fname = textBox7.Text,
                Mname = textBox8.Text,
                Lname = textBox9.Text,
                Suffix = textBox10.Text,
                Address1 = textBox11.Text,
                Address2 = textBox12.Text,
                City = textBox13.Text,
                State = textBox14.Text,
                Zip = textBox15.Text,

            };

            // Pass the data to Form1
            // ((Form1)Owner).AddDonorRecord(DonorRecord);

            mainForm.AddDonorRecord(donorRecord);

            // Close the form
            this.Close();
        }
    }
}
