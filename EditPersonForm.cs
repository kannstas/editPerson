using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EditPerson
{
    public partial class EditPersonForm : Form
    {
        Person person;
        public string FirstName
        {
            get { return firstNameTextBox.Text; }
            set { firstNameTextBox.Text = value; }

        }
        public string LastName
        {
            get { return lastNameTextBox.Text; }
            set { lastNameTextBox.Text = value; }

        }

        public int Age
        {
            get { return (int)ageNumericUpDown.Value; }
            set { ageNumericUpDown.Value = value; }

        }
        public EditPersonForm(Person person)
        {
            InitializeComponent();

            this.person = person;
            this.FirstName = person.FirstName;
            this.LastName = person.LastName;
            this.Age = person.Age;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person.FirstName = this.FirstName;
            person.LastName = this.LastName;
            person.Age = this.Age;

            MessageBox.Show("Сотрудник " + person.ToString());
        }
    }
}
