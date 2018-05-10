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
			Random rnd = new Random();
			int[] nums = new int[4];
			for (int i = 0; i < nums.Length; i++)
			{
				nums[i] = rnd.Next(0, 6);

				// 檢查下一個數字是否重複
				for (int j = 0; j < i;)
				{
					if (nums[i] == nums[j])
					{
						nums[i] = rnd.Next(0, 6);
						j = 0;
					}
					else
					{
						j++;
					}
				}
				// 控制項[]查詢 Controls.Find(string key, bool searchAllChildren)
				// return 型別 Control 的陣列
				Controls.Find("NumLabel" + i.ToString(), false)[0].Text = nums[i].ToString();
			}
		}
	}
}