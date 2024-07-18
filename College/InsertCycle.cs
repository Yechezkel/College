using GuestForShabat.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College
{
    public partial class InsertCycle : Form
    {
        DBContext dbContext = new DBContext();
        public InsertCycle()
        {
            InitializeComponent();
            
        }


        private void button_addCycle_Click(object sender, EventArgs e)
        {
            if (textBox_courseName.Text.Trim() == "" || textBox_cost.Text.Trim() == "" || textBox_courseDate.Text.Trim() == "")
            {
                MessageBox.Show("אנא הכנס שם קורס, תאריך פתיחה, ועלות");
                return;
            }
            if (textBox_sun.Text.Trim() == "" && textBox_mon.Text.Trim() == "" && textBox_tues.Text.Trim() == "" && textBox_wed.Text.Trim() == "" 
                && textBox_thurs.Text.Trim() == "" && textBox_fri.Text.Trim() == "" && textBox_sat.Text.Trim() == "")
            {
                MessageBox.Show("אנא הזן את שעות הקורס");
                return;
            }

            SqlParameter[] sp = { new SqlParameter("@CourseName", textBox_courseName.Text.Trim()),
                                    new SqlParameter("@StartDate", textBox_courseDate.Text.Trim()),
                                    new SqlParameter("@Cost", textBox_cost.Text.Trim()),
                                    new SqlParameter("@HoursOnSun", textBox_sun.Text.Trim()),
                                    new SqlParameter("@HoursOnMon", textBox_mon.Text.Trim()),
                                    new SqlParameter("@HoursOnTues", textBox_tues.Text.Trim()),
                                    new SqlParameter("@HoursOnWed", textBox_wed.Text.Trim()),
                                    new SqlParameter("@HoursOnThurs", textBox_thurs.Text.Trim()),
                                    new SqlParameter("@HoursOnFri", textBox_fri.Text.Trim()),
                                    new SqlParameter("@HoursOnSat", textBox_sat.Text.Trim()) };

            string query = "insert into Cycles(CourseName, StartDate, HoursOnSun, HoursOnMon, HoursOnTues, HoursOnWed, HoursOnThurs, HoursOnFri, HoursOnSat, Cost)" +
                            "values(@CourseName,  @StartDate, @HoursOnSun, @HoursOnMon, @HoursOnTues, @HoursOnWed, @HoursOnThurs, @HoursOnFri, @HoursOnSat, @Cost );";

            DataTable dataTable = dbContext.MakeQueryDT(query, sp);

            //return dataTable.Rows[0]["CategoryName"].ToString().Trim();



            //insert into Cycles(CourseName, StartDate, HoursOnSun, HoursOnMon, HoursOnTues, HoursOnWed, HoursOnThurs, HoursOnFri, HoursOnSat, Cost)
            //Values(N'אנגלית', '2021-02-14', N'אין לימודים', N'בין 18:00 ל 21:00', N'אין לימודים', N'אין לימודים', N'אין לימודים', N'אין לימודים', N'אין לימודים', 2225);

            //MessageBox.Show("נוסף בהצלחה");


        }

        private void button_next_Click(object sender, EventArgs e)
        {
            this.Close();
            new InsertTeacher().Show();
        }
    }
}
