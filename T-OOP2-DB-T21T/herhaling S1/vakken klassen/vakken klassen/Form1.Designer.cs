namespace vakken_klassen
{
    partial class Form1
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
            this.Studenten = new System.Windows.Forms.ListBox();
            this.StudentAdd = new System.Windows.Forms.Button();
            this.Geboortedatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Adres = new System.Windows.Forms.TextBox();
            this.StudentNaam = new System.Windows.Forms.TextBox();
            this.StudentNummer = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NewGrade = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SBU = new System.Windows.Forms.NumericUpDown();
            this.VakNaam = new System.Windows.Forms.TextBox();
            this.VakCode = new System.Windows.Forms.TextBox();
            this.AddCourse = new System.Windows.Forms.Button();
            this.Student_gegevens = new System.Windows.Forms.ListBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.New_adres = new System.Windows.Forms.TextBox();
            this.Old_adres = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.New_name = new System.Windows.Forms.TextBox();
            this.Old_name = new System.Windows.Forms.TextBox();
            this.Update_student = new System.Windows.Forms.GroupBox();
            this.StudentUpdate = new System.Windows.Forms.Button();
            this.Gehaald = new System.Windows.Forms.ListBox();
            this.incomplete = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentNummer)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBU)).BeginInit();
            this.Update_student.SuspendLayout();
            this.SuspendLayout();
            // 
            // Studenten
            // 
            this.Studenten.FormattingEnabled = true;
            this.Studenten.Location = new System.Drawing.Point(12, 38);
            this.Studenten.Name = "Studenten";
            this.Studenten.Size = new System.Drawing.Size(135, 498);
            this.Studenten.TabIndex = 0;
            this.Studenten.SelectedIndexChanged += new System.EventHandler(this.Studenten_SelectedIndexChanged);
            // 
            // StudentAdd
            // 
            this.StudentAdd.Location = new System.Drawing.Point(6, 123);
            this.StudentAdd.Name = "StudentAdd";
            this.StudentAdd.Size = new System.Drawing.Size(109, 23);
            this.StudentAdd.TabIndex = 1;
            this.StudentAdd.Text = "Add Student ";
            this.StudentAdd.UseVisualStyleBackColor = true;
            this.StudentAdd.Click += new System.EventHandler(this.StudentAdd_Click);
            // 
            // Geboortedatum
            // 
            this.Geboortedatum.Location = new System.Drawing.Point(6, 97);
            this.Geboortedatum.Name = "Geboortedatum";
            this.Geboortedatum.Size = new System.Drawing.Size(199, 20);
            this.Geboortedatum.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Adres);
            this.groupBox1.Controls.Add(this.StudentAdd);
            this.groupBox1.Controls.Add(this.StudentNaam);
            this.groupBox1.Controls.Add(this.StudentNummer);
            this.groupBox1.Controls.Add(this.Geboortedatum);
            this.groupBox1.Location = new System.Drawing.Point(153, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 157);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New student ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Geboortedatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student nummer";
            // 
            // Adres
            // 
            this.Adres.Location = new System.Drawing.Point(6, 71);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(199, 20);
            this.Adres.TabIndex = 5;
            // 
            // StudentNaam
            // 
            this.StudentNaam.Location = new System.Drawing.Point(6, 45);
            this.StudentNaam.Name = "StudentNaam";
            this.StudentNaam.Size = new System.Drawing.Size(199, 20);
            this.StudentNaam.TabIndex = 4;
            // 
            // StudentNummer
            // 
            this.StudentNummer.Location = new System.Drawing.Point(6, 19);
            this.StudentNummer.Name = "StudentNummer";
            this.StudentNummer.Size = new System.Drawing.Size(199, 20);
            this.StudentNummer.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.NewGrade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.SBU);
            this.groupBox2.Controls.Add(this.VakNaam);
            this.groupBox2.Controls.Add(this.VakCode);
            this.groupBox2.Controls.Add(this.AddCourse);
            this.groupBox2.Location = new System.Drawing.Point(153, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 170);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update courses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grade";
            // 
            // NewGrade
            // 
            this.NewGrade.Location = new System.Drawing.Point(6, 108);
            this.NewGrade.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NewGrade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NewGrade.Name = "NewGrade";
            this.NewGrade.Size = new System.Drawing.Size(199, 20);
            this.NewGrade.TabIndex = 8;
            this.NewGrade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(239, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "SBU (studie belastings in uren)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "VakNaam";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "VakCode";
            // 
            // SBU
            // 
            this.SBU.Location = new System.Drawing.Point(6, 82);
            this.SBU.Name = "SBU";
            this.SBU.Size = new System.Drawing.Size(199, 20);
            this.SBU.TabIndex = 5;
            // 
            // VakNaam
            // 
            this.VakNaam.Location = new System.Drawing.Point(6, 56);
            this.VakNaam.Name = "VakNaam";
            this.VakNaam.Size = new System.Drawing.Size(199, 20);
            this.VakNaam.TabIndex = 4;
            // 
            // VakCode
            // 
            this.VakCode.Location = new System.Drawing.Point(6, 30);
            this.VakCode.Name = "VakCode";
            this.VakCode.Size = new System.Drawing.Size(199, 20);
            this.VakCode.TabIndex = 3;
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(6, 134);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(109, 23);
            this.AddCourse.TabIndex = 2;
            this.AddCourse.Text = "Add Course Results";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // Student_gegevens
            // 
            this.Student_gegevens.FormattingEnabled = true;
            this.Student_gegevens.Location = new System.Drawing.Point(558, 38);
            this.Student_gegevens.Name = "Student_gegevens";
            this.Student_gegevens.Size = new System.Drawing.Size(230, 121);
            this.Student_gegevens.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "New Adres";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "New name";
            // 
            // New_adres
            // 
            this.New_adres.Location = new System.Drawing.Point(6, 113);
            this.New_adres.Name = "New_adres";
            this.New_adres.Size = new System.Drawing.Size(199, 20);
            this.New_adres.TabIndex = 10;
            // 
            // Old_adres
            // 
            this.Old_adres.Location = new System.Drawing.Point(6, 87);
            this.Old_adres.Name = "Old_adres";
            this.Old_adres.Size = new System.Drawing.Size(199, 20);
            this.Old_adres.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Old Adres";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(239, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Old name";
            // 
            // New_name
            // 
            this.New_name.Location = new System.Drawing.Point(6, 61);
            this.New_name.Name = "New_name";
            this.New_name.Size = new System.Drawing.Size(199, 20);
            this.New_name.TabIndex = 14;
            // 
            // Old_name
            // 
            this.Old_name.Location = new System.Drawing.Point(6, 35);
            this.Old_name.Name = "Old_name";
            this.Old_name.Size = new System.Drawing.Size(199, 20);
            this.Old_name.TabIndex = 13;
            // 
            // Update_student
            // 
            this.Update_student.Controls.Add(this.StudentUpdate);
            this.Update_student.Controls.Add(this.Old_name);
            this.Update_student.Controls.Add(this.label9);
            this.Update_student.Controls.Add(this.label11);
            this.Update_student.Controls.Add(this.label10);
            this.Update_student.Controls.Add(this.New_name);
            this.Update_student.Controls.Add(this.New_adres);
            this.Update_student.Controls.Add(this.label12);
            this.Update_student.Controls.Add(this.Old_adres);
            this.Update_student.Location = new System.Drawing.Point(153, 351);
            this.Update_student.Name = "Update_student";
            this.Update_student.Size = new System.Drawing.Size(399, 187);
            this.Update_student.TabIndex = 17;
            this.Update_student.TabStop = false;
            this.Update_student.Text = "name / adres edditor ";
            // 
            // StudentUpdate
            // 
            this.StudentUpdate.Location = new System.Drawing.Point(6, 139);
            this.StudentUpdate.Name = "StudentUpdate";
            this.StudentUpdate.Size = new System.Drawing.Size(109, 38);
            this.StudentUpdate.TabIndex = 17;
            this.StudentUpdate.Text = "change name /adres";
            this.StudentUpdate.UseVisualStyleBackColor = true;
            this.StudentUpdate.Click += new System.EventHandler(this.StudentUpdate_Click);
            // 
            // Gehaald
            // 
            this.Gehaald.FormattingEnabled = true;
            this.Gehaald.Location = new System.Drawing.Point(558, 201);
            this.Gehaald.Name = "Gehaald";
            this.Gehaald.Size = new System.Drawing.Size(230, 329);
            this.Gehaald.TabIndex = 18;
            // 
            // incomplete
            // 
            this.incomplete.FormattingEnabled = true;
            this.incomplete.Location = new System.Drawing.Point(817, 38);
            this.incomplete.Name = "incomplete";
            this.incomplete.Size = new System.Drawing.Size(230, 498);
            this.incomplete.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Studenten";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(558, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Studenten gegevens";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(558, 175);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Completed subjects";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(814, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Incompleted subjects";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 545);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.incomplete);
            this.Controls.Add(this.Gehaald);
            this.Controls.Add(this.Update_student);
            this.Controls.Add(this.Student_gegevens);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Studenten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentNummer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SBU)).EndInit();
            this.Update_student.ResumeLayout(false);
            this.Update_student.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Studenten;
        private System.Windows.Forms.Button StudentAdd;
        private System.Windows.Forms.DateTimePicker Geboortedatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown StudentNummer;
        private System.Windows.Forms.TextBox Adres;
        private System.Windows.Forms.TextBox StudentNaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.NumericUpDown NewGrade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SBU;
        private System.Windows.Forms.TextBox VakNaam;
        private System.Windows.Forms.TextBox VakCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Student_gegevens;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox New_adres;
        private System.Windows.Forms.TextBox Old_adres;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox New_name;
        private System.Windows.Forms.TextBox Old_name;
        private System.Windows.Forms.GroupBox Update_student;
        private System.Windows.Forms.Button StudentUpdate;
        private System.Windows.Forms.ListBox Gehaald;
        private System.Windows.Forms.ListBox incomplete;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

