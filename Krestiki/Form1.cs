using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Krestiki
{
    public partial class Form1 : Form
    {
        public static int count;
        public Form1()
        {
            InitializeComponent();
            count = 0;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(button1.Text == "X" || button1.Text == "0")
            {
                Task.Factory.StartNew(() => {
                    var c = button1.BackColor;
                    button1.BackColor = Color.Tomato;
                    Thread.Sleep(1000);
                    button1.BackColor = c;
                });
                count--;
            }
            if (count % 2 == 0 && button1.Text == "")
            {
                button1.Text = "X";
                if ((button4.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button3.Text == "X") ||
                    (button5.Text == "X" && button9.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if(count%2 == 1 && button1.Text == "")
                {
                    button1.Text = "0";
                    if ((button4.Text == "0" && button7.Text == "0") || (button2.Text == "0" && button3.Text == "0") ||
                    (button5.Text == "0" && button9.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if(count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (button2.Text == "X" || button2.Text == "0")
            {
                var c = button2.BackColor;
                var d = Task.Delay(1000);
                button2.BackColor = Color.Tomato;
                d.Wait();
                button2.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button2.Text == "")
            {
                button2.Text = "X";
                if ((button5.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button1.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button2.Text == "")
                {
                    button2.Text = "0";
                    if ((button5.Text == "0" && button8.Text == "0") || (button3.Text == "0" && button1.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (button3.Text == "X" || button3.Text == "0")
            {
                var c = button3.BackColor;
                var d = Task.Delay(1000);
                button3.BackColor = Color.Tomato;
                d.Wait();
                button3.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button3.Text == "")
            {
                button3.Text = "X";
                if ((button2.Text == "X" && button1.Text == "X") || (button5.Text == "X" && button7.Text == "X") ||
                    (button6.Text == "X" && button9.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button3.Text == "")
                {
                    button3.Text = "0";
                    if ((button2.Text == "0" && button1.Text == "0") || (button5.Text == "0" && button7.Text == "0") ||
                    (button6.Text == "0" && button9.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (button4.Text == "X" || button4.Text == "0")
            {
                var c = button4.BackColor;
                var d = Task.Delay(1000);
                button4.BackColor = Color.Tomato;
                d.Wait();
                button4.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button4.Text == "")
            {
                button4.Text = "X";
                if ((button1.Text == "X" && button7.Text == "X") || (button5.Text == "X" && button6.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button4.Text == "")
                {
                    button4.Text = "0";
                    if ((button1.Text == "0" && button7.Text == "0") || (button5.Text == "0" && button6.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (button5.Text == "X" || button5.Text == "0")
            {
                var c = button5.BackColor;
                var d = Task.Delay(1000);
                button5.BackColor = Color.Tomato;
                d.Wait();
                button5.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button5.Text == "")
            {
                button5.Text = "X";
                if ((button4.Text == "X" && button6.Text == "X") || (button2.Text == "X" && button8.Text == "X") ||
                    (button1.Text == "X" && button9.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button5.Text == "")
                {
                    button5.Text = "0";
                    if ((button4.Text == "0" && button6.Text == "0") || (button2.Text == "0" && button8.Text == "0") ||
                    (button1.Text == "0" && button9.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (button6.Text == "X" || button6.Text == "0")
            {
                var c = button6.BackColor;
                var d = Task.Delay(1000);
                button6.BackColor = Color.Tomato;
                d.Wait();
                button6.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button6.Text == "")
            {
                button6.Text = "X";
                if ((button3.Text == "X" && button9.Text == "X") || (button4.Text == "X" && button5.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button6.Text == "")
                {
                    button6.Text = "0";
                    if ((button3.Text == "0" && button9.Text == "0") || (button4.Text == "0" && button5.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (button7.Text == "X" || button7.Text == "0")
            {
                var c = button7.BackColor;
                var d = Task.Delay(1000);
                button7.BackColor = Color.Tomato;
                d.Wait();
                button7.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button7.Text == "")
            {
                button7.Text = "X";
                if ((button1.Text == "X" && button4.Text == "X") || (button5.Text == "X" && button3.Text == "X") ||
                    (button8.Text == "X" && button9.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button7.Text == "")
                {
                    button7.Text = "0";
                    if ((button1.Text == "0" && button4.Text == "0") || (button5.Text == "0" && button3.Text == "0") ||
                    (button8.Text == "0" && button9.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (button8.Text == "X" || button8.Text == "0")
            {
                var c = button8.BackColor;
                var d = Task.Delay(1000);
                button8.BackColor = Color.Tomato;
                d.Wait();
                button8.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button8.Text == "")
            {
                button8.Text = "X";
                if ((button7.Text == "X" && button9.Text == "X") || (button2.Text == "X" && button5.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button8.Text == "")
                {
                    button8.Text = "0";
                    if ((button7.Text == "0" && button9.Text == "0") || (button2.Text == "0" && button5.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            if (button9.Text == "X" || button9.Text == "0")
            {
                var c = button9.BackColor;
                var d = Task.Delay(1000);
                button9.BackColor = Color.Tomato;
                d.Wait();
                button9.BackColor = c;
                count--;
            }
            if (count % 2 == 0 && button9.Text == "")
            {
                button9.Text = "X";
                if ((button7.Text == "X" && button8.Text == "X") || (button3.Text == "X" && button6.Text == "X") ||
                    (button1.Text == "X" && button5.Text == "X"))
                {
                    MessageBox.Show("Winner - X", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                if (count % 2 == 1 && button9.Text == "")
                {
                    button9.Text = "0";
                    if ((button7.Text == "0" && button8.Text == "0") || (button3.Text == "0" && button6.Text == "0") ||
                    (button1.Text == "0" && button5.Text == "0"))
                    {
                        MessageBox.Show("Winner - 0", "You win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            count++;
            if (count == 9)
            {
                MessageBox.Show("Game over", "It's draw!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
