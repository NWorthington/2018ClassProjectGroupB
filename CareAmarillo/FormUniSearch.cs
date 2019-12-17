using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CareAmarillo
{
    public partial class FormUniSearch : Form
    {
        public FormUniSearch()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            string wordSearched = textBox1.Text;
            var userSearch = new User();
            userSearch.SearchDataset(wordSearched);
        }

        public void PopulateSearch()
        {
            string wordSearched = textBox1.Text;
            var userSearch = new User();
            List<string> list = new List<string>();
            foreach (string row in userSearch.SearchDataset(wordSearched))
            {
                list.Add(row);
            }
            listBox1.DataSource = list;
        }
    }
}
