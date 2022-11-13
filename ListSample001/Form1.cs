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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyRectangle item = (MyRectangle)comboBox1.SelectedItem;
            // 轉型的原因是，comboBox1.SelectedItem的型別是object，若直接抓會找不到name跟area
            MessageBox.Show($"{item.Name} 的面積為 {item.GetArea():N0}");
        }
    }
}
