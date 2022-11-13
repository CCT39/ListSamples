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
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 原本事件觸發是在InitializeComponent();就委派，此處改到最後再委派，即可解決問題
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            int index = comboBox1.SelectedIndex;
            MyRectangle item = list[index];
            MessageBox.Show($"取得索引 {index} 面積為 {item.Area}");
            // 假如只希望它做一次
            // comboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
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
            comboBox1.DataSource = list; //出錯的原因是，這邊塞值之後就會觸發事件，跳出視窗
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Area";
        }
    }
}
