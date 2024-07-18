namespace College
{
    partial class InsertTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_TeacherFirstName = new System.Windows.Forms.TextBox();
            this.textBox_TeacherLastName = new System.Windows.Forms.TextBox();
            this.textBox_TeacherTZ = new System.Windows.Forms.TextBox();
            this.textBox_HourlyWage = new System.Windows.Forms.TextBox();
            this.button_addTeacher = new System.Windows.Forms.Button();
            this.button_prev = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "הוספת מרצה חדש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "תעודת זהות";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "שכר שעתי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "שם פרטי";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "שם משפחה";
            // 
            // textBox_TeacherFirstName
            // 
            this.textBox_TeacherFirstName.Location = new System.Drawing.Point(457, 203);
            this.textBox_TeacherFirstName.Name = "textBox_TeacherFirstName";
            this.textBox_TeacherFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_TeacherFirstName.TabIndex = 6;
            // 
            // textBox_TeacherLastName
            // 
            this.textBox_TeacherLastName.Location = new System.Drawing.Point(457, 307);
            this.textBox_TeacherLastName.Name = "textBox_TeacherLastName";
            this.textBox_TeacherLastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_TeacherLastName.TabIndex = 7;
            // 
            // textBox_TeacherTZ
            // 
            this.textBox_TeacherTZ.Location = new System.Drawing.Point(209, 203);
            this.textBox_TeacherTZ.Name = "textBox_TeacherTZ";
            this.textBox_TeacherTZ.Size = new System.Drawing.Size(100, 20);
            this.textBox_TeacherTZ.TabIndex = 8;
            // 
            // textBox_HourlyWage
            // 
            this.textBox_HourlyWage.Location = new System.Drawing.Point(209, 307);
            this.textBox_HourlyWage.Name = "textBox_HourlyWage";
            this.textBox_HourlyWage.Size = new System.Drawing.Size(100, 20);
            this.textBox_HourlyWage.TabIndex = 9;
            // 
            // button_addTeacher
            // 
            this.button_addTeacher.Location = new System.Drawing.Point(355, 364);
            this.button_addTeacher.Name = "button_addTeacher";
            this.button_addTeacher.Size = new System.Drawing.Size(75, 23);
            this.button_addTeacher.TabIndex = 10;
            this.button_addTeacher.Text = "הוספה";
            this.button_addTeacher.UseVisualStyleBackColor = true;
            this.button_addTeacher.Click += new System.EventHandler(this.button_addTeacher_Click);
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(650, 395);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 11;
            this.button_prev.Text = "הקודם";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(108, 395);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(75, 23);
            this.button_next.TabIndex = 24;
            this.button_next.Text = "הבא";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // InsertTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.button_addTeacher);
            this.Controls.Add(this.textBox_HourlyWage);
            this.Controls.Add(this.textBox_TeacherTZ);
            this.Controls.Add(this.textBox_TeacherLastName);
            this.Controls.Add(this.textBox_TeacherFirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InsertTeacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_TeacherFirstName;
        private System.Windows.Forms.TextBox textBox_TeacherLastName;
        private System.Windows.Forms.TextBox textBox_TeacherTZ;
        private System.Windows.Forms.TextBox textBox_HourlyWage;
        private System.Windows.Forms.Button button_addTeacher;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button_next;
    }
}