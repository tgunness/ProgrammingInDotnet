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
        public ListBoxes()
        {
            InitializeComponent();
            _allPersons = new List<Person>()
            {
                new Person("Jim","Halpert",123,"A Road"),
                new Person("Pam","Beesley",456,"B Road"),
                new Person("Dwight","Schrute",789,"C Road"),
                new Person("Michael","Scott",147,"D Road")
            };
            myListBox.Items.AddRange(_allPersons.ToArray());          
        }

        public void DisplayPerson(object sender, EventArgs e)
        {
            if (myListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select an item first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(myListBox.SelectedItem.GetType() != typeof(Person))
            {
                MessageBox.Show("The select item is not a Person type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _selectedPerson = (Person)myListBox.SelectedItem;
                PersonDetailForm detail = new PersonDetailForm();
                detail.Show();
            }            
        }

        public void Exit(object sender, EventArgs e)
        {
            Close();
        }

    }
}
