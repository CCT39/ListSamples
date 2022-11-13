using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListSample006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxSelectionMode();
            ChangeData();
        }

        private List<string> leftList;
        private List<string> rightList;

        private void CreateList()
        {
            leftList = new List<string>()
            {
                "A", "B", "C", "D"
            };
            rightList = new List<string>();
        }

        private void SetListBoxSelectionMode()
        {
            lbxLeft.SelectionMode = SelectionMode.One;
            lbxRight.SelectionMode = SelectionMode.One;
        }

        private void ChangeData()
        {
            lbxLeft.DataSource = null; //先切換資料來源，變成null之後再回去，畫面才知道改變了
            lbxRight.DataSource = null;
            lbxLeft.DataSource = leftList;
            lbxRight.DataSource = rightList;
        }

        private void btnToRight_Click(object sender, EventArgs e)
        {
            if (lbxLeft.SelectedItem != null) //不是SelectedItems
            {
                string item = (string)lbxLeft.SelectedItem;
                leftList.Remove(item);
                rightList.Add(item);
                ChangeData();
            }
        }

        private void btnToLeft_Click(object sender, EventArgs e)
        {
            if (lbxRight.SelectedItem != null)
            {
                string item = (string)lbxRight.SelectedItem;
                rightList.Remove(item);
                leftList.Add(item);
                ChangeData();
            }
        }
    }
}
