using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateList();
        }

        private List<string> list;

        private void CreateList()
        {
            list = new List<string>
            {
                "Dog", "Cat", "Monkey", "Fly", "Donkey", "Dog2"
            };
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string result = list.Find((x) => x == tbxInput.Text); //有點像foreach x in list
            MessageBox.Show("Find: " + result);
        }

        private void btnFindIndex_Click(object sender, EventArgs e)
        {
            int index = list.FindIndex((x) => x == tbxInput.Text);
            MessageBox.Show("Find Index: " + index);
        }

        private void btnFindAll_Click(object sender, EventArgs e)
        {
            List<string> results = list.FindAll((x) => x.Contains(tbxInput.Text));
            MessageBox.Show("Find All: " + string.Join(",", results));
        }

        private void btnFindLast_Click(object sender, EventArgs e) //從尾巴反著往前找
        {
            string result = list.FindLast((x) => x.Contains(tbxInput.Text));
            MessageBox.Show("Find Last: " + result);
        }
    }
}
