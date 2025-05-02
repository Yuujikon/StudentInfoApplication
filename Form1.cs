using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void frmStudentInfo_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentInfo si = new StudentInfo();
            lboxStudentID.Items.Add(si.studentID = Convert.ToInt32(txtboxStudentID.Text));
            lboxLname.Items.Add(si.lastName = txtboxLname.Text);
            lboxFname.Items.Add(si.firstName = txtboxFname.Text);
        }
    }
}

namespace StudentNamespace
{
    public class StudentInfo
    {
        private int StudentID;
        private string LastName, FirstName;
        public int studentID { get { return StudentID; } set { this.StudentID = value; } }
        public string lastName { get { return LastName; } set { this.LastName = value; } }
        public string firstName { get { return FirstName; } set { this.FirstName = value; } }
        public StudentInfo()
        {
            StudentID = 0;
            LastName = string.Empty;
            FirstName = string.Empty;
        }
        
        public StudentInfo(int studentID, string lastName, string firstName)
        {
            this.StudentID = studentID;
            this.LastName = lastName;
            this.FirstName = firstName;
        }
    }
}