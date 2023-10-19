using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6InClassDemo.MultipleForms
{
    public partial class ListBoxes : MyFormBase
    {
        public List<Person> _allPersons;
        public PersonDetailForm detail;
        public ListBoxes()
        {
            InitializeComponent();
            detail = new PersonDetailForm();
            _allPersons = new List<Person>()
            {
                new Person("Jim","Halpert",123,"A Road"),
                new Person("Pam","Beesley",456,"B Road"),
                new Person("Dwight","Schrute",789,"C Road"),
                new Person("Michael","Scott",147,"D Road")
            };

            myListBox.Items.AddRange(_allPersons.ToArray());
            myListBox.Items.Add("This is a string");
        }

        public void DisplayPerson(object sender, EventArgs e)
        {
            

            selectedPerson = (Person)myListBox.SelectedItem;
            detail.Show();

            //if(myListBox.SelectedItem == null)
            //{
            //    MessageBox.Show("Please select an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (myListBox.SelectedItem is Person)
            //{
            //    Person selectedPerson = (Person)myListBox.SelectedItem;
            //    MessageBox.Show($"You selected {selectedPerson.FirstName} {selectedPerson.LastName} \n" +
            //        $"Their address is {selectedPerson.Address} \n" +
            //        $"Their sin number is {selectedPerson.SinNumber}.");
            //}
            //else
            //{
            //    MessageBox.Show("The select item is not a Person type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        public void Exit(object sender, EventArgs e)
        {
            Close();
        }

    }
}
