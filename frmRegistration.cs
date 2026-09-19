using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class frmRegistration : Form
    {
        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;

        public frmRegistration()
        {
            InitializeComponent();

            cbPrograms.Items.Add("BS in Information Technology");
            cbPrograms.Items.Add("BS in Computer Engineering");
            cbPrograms.Items.Add("BS in Information Systems");
            cbPrograms.Items.Add("BS in Tourism");
            cbPrograms.Items.Add("BS in House Management");

            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
        }

        public long StudentNumber(string studNum)
        {
            if (string.IsNullOrWhiteSpace(studNum))
                throw new ArgumentNullException();

            if (!Regex.IsMatch(studNum, @"^[0-9]+$"))
                throw new FormatException();

            _StudentNo = long.Parse(studNum);
            return _StudentNo;
        }

        public long ContactNo(string contact)
        {
            if (string.IsNullOrWhiteSpace(contact))
                throw new ArgumentNullException();

            if (!Regex.IsMatch(contact, @"^[0-9]{10,11}$"))
                throw new FormatException();

            _ContactNo = long.Parse(contact);
            return _ContactNo;
        }

        public string FullName(string lastName, string firstName, string middleInitial)
        {
            if (string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(middleInitial))
                throw new ArgumentNullException();

            if (!Regex.IsMatch(lastName, @"^[a-zA-Z ]+$") ||
                !Regex.IsMatch(firstName, @"^[a-zA-Z ]+$") ||
                !Regex.IsMatch(middleInitial, @"^[a-zA-Z ]+$"))
                throw new FormatException();

            _FullName = lastName + ", " + firstName + ", " + middleInitial;
            return _FullName;
        }

        public int Age(string age)
        {
            if (string.IsNullOrWhiteSpace(age))
                throw new ArgumentNullException();

            if (!Regex.IsMatch(age, @"^[0-9]{1,3}$"))
                throw new FormatException();

            _Age = int.Parse(age);

            if (_Age <= 0 || _Age > 120)
                throw new OverflowException();

            return _Age;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInformationClass.SetFullName = FullName(txtLastName.Text, txtFirstName.Text, txtMiddleInitial.Text);

                StudentInformationClass.SetStudentNo = StudentNumber(txtStudentNo.Text);

                StudentInformationClass.SetProgram = cbPrograms.Text;

                StudentInformationClass.SetGender = cbGender.Text;

                StudentInformationClass.SetContactNo = ContactNo(txtContactNo.Text);

                StudentInformationClass.SetAge = Age(txtAge.Text);

                StudentInformationClass.SetBirthDay = datePickerBirthday.Value.ToString("yyyy-MM-dd");

                frmConfirmation frm = new frmConfirmation(); 
                frm.ShowDialog();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format.","Format Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please complete all fields.","Missing Input",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Input value is out of range.","Overflow Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Index out of range.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                Console.WriteLine("Registration process completed.");
            }
        }
    }
}