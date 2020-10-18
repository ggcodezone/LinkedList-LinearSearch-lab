using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinearSearchApp
{
    public partial class Form1 : Form
    {
        const int ListSize = 100;
        public Form1()
        {
            InitializeComponent();
        }

        private void ListofNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ListofNumbers.Items.Clear();
            searchInput_TextChanged.Text = "";
            searchResult_TextChanged.Clear();
        }

        private void Fillbutton_Click(object sender, EventArgs e)
        {
            int i;
            Random random = new Random();

            for(i=0; i< ListSize; i++)
            {
                int RandomNumber = random.Next(0, 100);
                ListofNumbers.Items.Add(RandomNumber);
            }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
