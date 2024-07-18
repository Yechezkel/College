namespace College
{
    partial class InsertSubject
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
            this.button_addSubject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_subjectName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_courseDate = new System.Windows.Forms.TextBox();
            this.textBox_subjectName = new System.Windows.Forms.TextBox();
            this.textBox_TeacherTZ = new System.Windows.Forms.TextBox();
            this.textBox_courseName = new System.Windows.Forms.TextBox();
            this.textBox_numofHours = new System.Windows.Forms.TextBox();
            this.button_prev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_addSubject
            // 
            this.button_addSubject.Location = new System.Drawing.Point(343, 374);
            this.button_addSubject.Name = "button_addSubject";
            this.button_addSubject.Size = new System.Drawing.Size(75, 23);
            this.button_addSubject.TabIndex = 0;
            this.button_addSubject.Text = "הוספה";
            this.button_addSubject.UseVisualStyleBackColor = true;
            this.button_addSubject.Click += new System.EventHandler(this.button_addSubject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "הוספת נושא לקורס";
            // 
            // label_subjectName
            // 
            this.label_subjectName.AutoSize = true;
            this.label_subjectName.Location = new System.Drawing.Point(572, 208);
            this.label_subjectName.Name = "label_subjectName";
            this.label_subjectName.Size = new System.Drawing.Size(53, 13);
            this.label_subjectName.TabIndex = 2;
            this.label_subjectName.Text = "שם נושא";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ת.ז. מרצה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "שם קורס";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(548, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "מספר השעות הכולל";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "תאריך פתיחת הקורס";
            // 
            // textBox_courseDate
            // 
            this.textBox_courseDate.Location = new System.Drawing.Point(374, 294);
            this.textBox_courseDate.Name = "textBox_courseDate";
            this.textBox_courseDate.Size = new System.Drawing.Size(100, 20);
            this.textBox_courseDate.TabIndex = 7;
            // 
            // textBox_subjectName
            // 
            this.textBox_subjectName.Location = new System.Drawing.Point(551, 224);
            this.textBox_subjectName.Name = "textBox_subjectName";
            this.textBox_subjectName.Size = new System.Drawing.Size(100, 20);
            this.textBox_subjectName.TabIndex = 8;
            // 
            // textBox_TeacherTZ
            // 
            this.textBox_TeacherTZ.Location = new System.Drawing.Point(176, 224);
            this.textBox_TeacherTZ.Name = "textBox_TeacherTZ";
            this.textBox_TeacherTZ.Size = new System.Drawing.Size(100, 20);
            this.textBox_TeacherTZ.TabIndex = 9;
            // 
            // textBox_courseName
            // 
            this.textBox_courseName.Location = new System.Drawing.Point(374, 224);
            this.textBox_courseName.Name = "textBox_courseName";
            this.textBox_courseName.Size = new System.Drawing.Size(100, 20);
            this.textBox_courseName.TabIndex = 10;
            // 
            // textBox_numofHours
            // 
            this.textBox_numofHours.Location = new System.Drawing.Point(551, 294);
            this.textBox_numofHours.Name = "textBox_numofHours";
            this.textBox_numofHours.Size = new System.Drawing.Size(100, 20);
            this.textBox_numofHours.TabIndex = 11;
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(636, 374);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 12;
            this.button_prev.Text = "הקודם";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button_prev_Click);
            // 
            // insertSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.textBox_numofHours);
            this.Controls.Add(this.textBox_courseName);
            this.Controls.Add(this.textBox_TeacherTZ);
            this.Controls.Add(this.textBox_subjectName);
            this.Controls.Add(this.textBox_courseDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_subjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_addSubject);
            this.Name = "insertSubject";
            this.Text = "insertSubject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_subjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_courseDate;
        private System.Windows.Forms.TextBox textBox_subjectName;
        private System.Windows.Forms.TextBox textBox_TeacherTZ;
        private System.Windows.Forms.TextBox textBox_courseName;
        private System.Windows.Forms.TextBox textBox_numofHours;
        private System.Windows.Forms.Button button_prev;
    }
}