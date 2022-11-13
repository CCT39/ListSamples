using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetComboBox();
        }

        private List<MyRectangle> list;

        private void CreateList()
        {
            list = new List<MyRectangle>();
            list.Add(new MyRectangle { Name = "D1", Width = 5, Height = 5 });
            list.Add(new MyRectangle { Name = "D2", Width = 10, Height = 10 });
            list.Add(new MyRectangle { Name = "D3", Width = 20, Height = 20 });
            list.Add(new MyRectangle { Name = "D4", Width = 100, Height = 100 });
        }

        private void SetComboBox()
        {
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MyRectangle item = (MyRectangle)comboBox1.SelectedItem;
            int area = (int)comboBox1.SelectedValue;
            MessageBox.Show($"{area:N0}");
        }
    }
}
