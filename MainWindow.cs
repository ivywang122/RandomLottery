using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLottery
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            int[] nums = new int[4];
            Random rnd = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(0, 10);
                // 檢查下一個數字是否重複
                for (int j = 0; j < i; j++)
                {
                    // 如果重複
                    if (nums[i] == nums[j])
                    {
                        // 再 random 一次
                        nums[i] = rnd.Next(0, 10);
                        // 再重新檢查一次
                        j = 0;
                    }
                }
                // 控制項[]查詢 Controls.Find(string key, bool searchAllChildren)
                // return 型別 Control 的陣列
                Controls.Find("numLabel" + i.ToString(), false)[0].Text = nums[i].ToString();
            }
        }
    }
}