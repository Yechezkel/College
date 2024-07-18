using GuestForShabat.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class InsertSubject : Form
    {
        DBContext dbContext = new DBContext();
        public InsertSubject()
        {
            InitializeComponent();
        }

        private void button_addSubject_Click(object sender, EventArgs e)
        {
            if (textBox_subjectName.Text.Trim() == "" || textBox_courseName.Text.Trim() == "" || textBox_courseDate.Text.Trim() == "" || textBox_TeacherTZ.Text.Trim() == "" || textBox_numofHours.Text.Trim() == "")
            {
                MessageBox.Show("אנא הכנס פרטים מלאים");
                return;
            }

            SqlParameter[] sp = { new SqlParameter("@CourseName", textBox_courseName.Text.Trim()),
                                    new SqlParameter("@StartDate", textBox_courseDate.Text.Trim()),
                                    new SqlParameter("@NumofHours", textBox_numofHours.Text.Trim()),
                                     new SqlParameter("@subjectName", textBox_subjectName.Text.Trim()),
                                    new SqlParameter("@TeacherTZ", textBox_TeacherTZ.Text.Trim()) };

            string query = @"DECLARE @CycleID INT;
                            SELECT @CycleID = CycleID
                            FROM Cycles
                            WHERE CourseName = @CourseName AND StartDate = @StartDate;
                            DECLARE @TeacherID INT;
                            SELECT @TeacherID = TeacherID
                            FROM Teachers
                            WHERE TeacherTZ = @TeacherTZ;
                            insert into Subjects (CycleID , SubjectName, TeacherID, NumofHours)
                            Values (@CycleID, @subjectName, @TeacherID,@NumofHours);";
            DataTable dataTable = dbContext.MakeQueryDT(query, sp);
        }

        private void button_prev_Click(object sender, EventArgs e)
        {

            this.Close();
            new InsertTeacher().Show();
        }
    }
}
