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
    public partial class InsertTeacher : Form
    {
        DBContext dbContext = new DBContext();
   
        public InsertTeacher()
        {
            InitializeComponent();
        }

        private void button_addTeacher_Click(object sender, EventArgs e)
        {
            if (textBox_TeacherFirstName.Text.Trim() == "" || textBox_TeacherLastName.Text.Trim() == "" || textBox_TeacherTZ.Text.Trim() == "" || textBox_HourlyWage.Text.Trim() == "")
            {
                MessageBox.Show("אנא הכנס פרטי מרצה מלאים");
                return;
            }
            
            SqlParameter[] sp = { new SqlParameter("@TeacherFirstName", textBox_TeacherFirstName.Text.Trim()),
                                    new SqlParameter("@TeacherLastName", textBox_TeacherLastName.Text.Trim()),
                                    new SqlParameter("TeacherTZ", textBox_TeacherTZ.Text.Trim()),
                                    new SqlParameter("@HourlyWage", textBox_HourlyWage.Text.Trim())  };

            string query = "insert into  Teachers(TeacherFirstName, TeacherLastName, TeacherTZ, HourlyWage)" +
                            "values(@TeacherFirstName, @TeacherLastName, @TeacherTZ, @HourlyWage );";

            DataTable dataTable = dbContext.MakeQueryDT(query, sp);
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            this.Close();
            new InsertCycle().Show();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.Close();
            new InsertSubject().Show();
        }
    }
}
