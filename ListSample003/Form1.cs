using ListSample001;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample003
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
            list = new List<MyRectangle>
            {
                new MyRectangle { Name = "D1", Width = 5, Height = 5 },
                new MyRectangle { Name = "D2", Width = 10, Height = 10 },
                new MyRectangle { Name = "D3", Width = 20, Height = 20 },
                new MyRectangle { Name = "D4", Width = 100, Height = 100 }
            };
        }

        private void SetComboBox()
        {
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }


        // sender：發送者
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 從參數中取得觸發該事件的物件
            ComboBox theComboBox = (ComboBox)sender;
            int index = theComboBox.SelectedIndex;
            // int index = comboBox1.SelectedIndex; 等價於上兩列
            MyRectangle item = list[index];
            MessageBox.Show($"取得索引 {index} 面積為 {item.Area}");
        }
    }
}
