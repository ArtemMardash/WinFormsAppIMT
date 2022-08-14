namespace WinFormsAppIMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Вы запустили калькулятор ИМТ ", "Message", MessageBoxButtons.OK);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
                else
                {
                    Application.Exit();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBox5.Text))
            {
                if(Convert.ToInt16(textBox2.Text) > 40 && Convert.ToInt16(textBox2.Text) < 240)
                {
                    if(Convert.ToInt16(textBox1.Text) > 3 && Convert.ToInt16(textBox1.Text) < 200)
                    {
                        if((textBox3.Text == "М")  || (textBox3.Text == "Ж"))
                        {
                            if(Convert.ToInt16(textBox4.Text) > 0 && Convert.ToInt16(textBox4.Text) < 120)
                            {
                                IMT calculate = new IMT(textBox5.Text, Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox1.Text), textBox3.Text, Convert.ToInt16(textBox4.Text));
                                string recomendations = calculate.DoRecomendations();
                                Form frm = new Form2(recomendations);
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("insert error! Check Age it's must be > 0 and < 120", "Message", MessageBoxButtons.OK);
                            }
                        }
                        else
                        {
                            MessageBox.Show("insert error! Check Male it's must be М or Ж", "Message", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("insert error! Check Weight it's must be > 3 and < 200", "Message", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("insert error! Check High it's must be > 40 and < 240", "Message", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("insert error! Check Name it's must be not empty", "Message", MessageBoxButtons.OK);
            }
        }
    }
    }
