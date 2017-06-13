using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyMathLibrary;

namespace Main_NumberGuessing
{
    public partial class GuessGameForm : Form
    {
        private static int[] ans = new int[4];

        public GuessGameForm()
        {
            InitializeComponent();

            #region 隨機產生四個猜數字

            RandomGenerator random = new RandomGenerator();
            List<int> numbers = new List<int>();
            for (int index = 0; index < 10; index++)
                numbers.Add(index);
            for (int count = 1; count <= 4; count++)
            {
                int index = random.Next(0, numbers.Count);
                ans[count - 1] = numbers[index];
                numbers.Remove(numbers[index]);
            }
            AnswerLabel.Text = ans[0].ToString() + ans[1].ToString() + ans[2].ToString() + ans[3].ToString();

            #endregion 隨機產生四個猜數字
        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            int[] keyin = new int[4];
            int a = 0, b = 0;  // a=字對位置也對的個數; b=字對位置不對的個數

            keyin[0] = int.Parse(Number1TextBox.Text);
            keyin[1] = int.Parse(Number2TextBox.Text);
            keyin[2] = int.Parse(Number3TextBox.Text);
            keyin[3] = int.Parse(Number4TextBox.Text);

            #region 判斷幾A幾B

            if (a != 4)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (ans[i] == keyin[i])  //比較A
                        a++;
                    else
                    {   //比較B
                        for (int j = 0; j < 4; j++)
                        {   //再比較一次
                            if (ans[i] == keyin[j])  //比較B
                                b++;
                        }
                    }
                }
                GuessTextBox.Text += keyin[0].ToString() + keyin[1].ToString() + keyin[2].ToString() + keyin[3].ToString() + "\r\n";
                ResultTextBox.Text += a + "A" + b + "B" + "\r\n";
                if (a == 4) MessageBox.Show("恭喜您! 猜對了...");
                Number1TextBox.Text = "";
                Number2TextBox.Text = "";
                Number3TextBox.Text = "";
                Number4TextBox.Text = "";
            }

            #endregion 判斷幾A幾B
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            #region 隨機產生四個猜數字

            RandomGenerator random = new RandomGenerator();
            List<int> numbers = new List<int>();
            for (int index = 0; index < 10; index++)
                numbers.Add(index);
            for (int count = 1; count <= 4; count++)
            {
                int index = random.Next(0, numbers.Count);
                ans[count - 1] = numbers[index];
                numbers.Remove(numbers[index]);
            }
            AnswerLabel.Text = ans[0].ToString() + ans[1].ToString() + ans[2].ToString() + ans[3].ToString();

            #endregion 隨機產生四個猜數字
        }
    }
}