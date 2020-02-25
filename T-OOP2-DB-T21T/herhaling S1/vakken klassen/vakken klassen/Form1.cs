using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vakken_klassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StudentAdd_Click(object sender, EventArgs e)
        {
            if (StudentNummer.Value == 0)
            {
                MessageBox.Show("You forgot to give a new student nummer.");
            }
            else if (StudentNaam.Text == "")
            {
                MessageBox.Show("You forgot to write down the student's name.");
            }
            else if (Adres.Text == "")
            {
                MessageBox.Show("You forgot to write down the student's address.");
            }
            else
            {
                Student student = new Student(Convert.ToInt32(StudentNummer.Value), StudentNaam.Text, Adres.Text, Geboortedatum.Value);
                Studenten.Items.Add(student);
            }
        }
        private void AddCourse_Click(object sender, EventArgs e)
        {
            if (Studenten.SelectedItem == null)
            {
                MessageBox.Show("you haven't chosen a student yet.");
            }
            else
            {
                if (VakCode.Text == "")
                {
                    MessageBox.Show("you didn't fill in a vakCode.");
                }
                else if (VakNaam.Text == "")
                {
                    MessageBox.Show("you didn't fill in a vakNaam.");
                }
                else if (SBU.Value == 0)
                {
                    MessageBox.Show("you didn't fill in a SBU.");
                }
                else
                {
                    if (NewGrade.Value == 1)
                    {
                        MessageBox.Show("Grade of subject is set to 1.");
                    }
                    Vak newVak = new Vak(VakCode.Text, VakNaam.Text, Convert.ToInt32(SBU.Value));
                    Resultaat newResultaat = new Resultaat(newVak, Convert.ToInt32(NewGrade.Value));
                    ((Student)Studenten.SelectedItem).AddResultaat(newResultaat);
                }
            }
        }

        private void Studenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student_gegevens.Items.Clear();

            Student_gegevens.Items.Add("Naam: " + ((Student)Studenten.SelectedItem).Naam);
            Student_gegevens.Items.Add("Geboortedatum: " + ((Student)Studenten.SelectedItem).GeboorteDatum);
            Student_gegevens.Items.Add("Adres: " + ((Student)Studenten.SelectedItem).Adress);
            Student_gegevens.Items.Add("behaalde SBU: " + ((Student)Studenten.SelectedItem).SBU());
            Student_gegevens.Items.Add("Hoogste cijfer: " + ((Student)Studenten.SelectedItem).Hoger());

            Old_name.Text = ((Student)Studenten.SelectedItem).Naam;
            Old_adres.Text = ((Student)Studenten.SelectedItem).Adress;


            foreach (Resultaat resultaat in ((Student)Studenten.SelectedItem).Resultaten)
            {
                if (resultaat.Cijfer >= 6)
                {
                    Gehaald.Items.Add(resultaat.Vak.VakNaam);
                }
                else
                {
                    incomplete.Items.Add(resultaat.Vak.VakNaam + resultaat.Cijfer);
                }
            }
        }

        private void StudentUpdate_Click(object sender, EventArgs e)
        {
            if (New_name.Text != "" && New_adres.Text != "")
            {
                Name_change();
                Adres_change();
            }
            else if (New_name.Text != "")
            {
                Name_change();
            }
            else if (New_adres.Text != "")
            {
                Adres_change();
            }
            else
            {
                MessageBox.Show("you didn't fill in a new name nor adres.");
            }
        }

        private void Name_change()
        {
            ((Student)Studenten.SelectedItem).Naam = New_name.Text;
            Old_name.Text = ((Student)Studenten.SelectedItem).Naam;
            New_name.Text = "";
        }

        private void Adres_change()
        {
            ((Student)Studenten.SelectedItem).Adress = New_adres.Text;
            Old_adres.Text = ((Student)Studenten.SelectedItem).Adress;
            New_adres.Text = "";
        }
    }
}