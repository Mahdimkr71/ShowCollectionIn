using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShowCollectionIn
{
    public partial class Form1 : Form
    {
        List<PersonData> people;
        public Form1()
        {
            InitializeComponent();
                 people = new List<PersonData>
            {
                new PersonData { FirstName = "milad",LastName = "safari", Age = 26 },
                new PersonData { FirstName = "reza",LastName = "feli", Age = 25 },
                new PersonData { FirstName = "mina",LastName = "nadi", Age = 35 }
            };
            PeopleGridView.DataSource = people;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonData data = new PersonData()
            {
                FirstName = FisrtNameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Age = int.Parse(AgeTextBox.Text),
            };
            people.Add(data);
            PeopleGridView.DataSource = null;
            PeopleGridView.DataSource = people;
            PeopleGridView.Refresh();
            FisrtNameTextBox.Text = null;
            AgeTextBox.Text = null;
            LastNameTextBox.Text = null;
        }
    }
}
