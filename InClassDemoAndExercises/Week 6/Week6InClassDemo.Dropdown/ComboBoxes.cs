using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6InClassDemo.Dropdown
{
    public partial class ComboBoxes : Form
    {
        public ComboBoxes()
        {
            InitializeComponent();
            myComboBox.Items.Add("a");
            myComboBox.Items.Add("b");
            myComboBox.Items.Add(123);
            myComboBox.Items.Add(456);
            myComboBox.Items.Add('c');
            myComboBox.Items.Add((double)789);
        }

        public void ShowWhatsInComboxBox(object sender, EventArgs e)
        {
            string output = "";
            foreach(var item in myComboBox.Items)
            {
                output += $"Element [{myComboBox.Items.IndexOf(item)}] is of type {item.GetType()} \n";
            }

            MessageBox.Show(output);

            var selectedItem = myComboBox.SelectedItem;

            MessageBox.Show($"The selected item is {selectedItem}");
        }

        public void Exit(object sender, EventArgs e)
        {
            Close();
        }
    }
}
