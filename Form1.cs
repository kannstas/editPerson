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
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (personsListView.SelectedIndices.Count == 0)
                return;

            Person person = persons[personsListView.SelectedIndices[0]];


            EditPersonForm editForm = new EditPersonForm(person);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }

            /*

                        ListViewItem listViewItem = personsListView.SelectedItems[0];
                        editForm.FirstName = listViewItem.Text;
                        editForm.LastName = listViewItem.SubItems[1].Text;
                        editForm.Age = Convert.ToInt32(listViewItem.SubItems[2].Text);

                        if (editForm.ShowDialog() != DialogResult.OK)
                            return;

                        listViewItem.Text = editForm.FirstName;
                        listViewItem.SubItems[1].Text = editForm.LastName;
                        listViewItem.SubItems[2].Text = editForm.Age.ToString();*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();

            EditPersonForm editForm = new EditPersonForm(person);

            if (editForm.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            persons.Add(person);

            personsListView.VirtualListSize = persons.Count;
            personsListView.Invalidate();

/*
            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());*/



        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex< persons.Count)
            {
                e.Item = new ListViewItem(persons[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(persons[e.ItemIndex].LastName);
                e.Item.SubItems.Add(persons[e.ItemIndex].Age.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Person item in persons)
            {
                stringBuilder.Append(" ")
            }
        }
    }
}