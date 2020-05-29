using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Stock stock = new Stock();
        Random rnd= new Random();
        List<Client> clients = new List<Client>();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 10000;
            timer.Tick += Timer_Tick;
            timer.Start();
            comboBox1.DataSource = clients;
            comboBox1.DisplayMember = "Login";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            stock.BTCCourse = rnd.Next(8000, 8600);
            stock.Notify();
            label9.Text = stock.BTCCourse.ToString();
            ShowClientInfo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double temp = 0;
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("You must enter name!");
                return;
            }
            Client client = new Client();
            client.Login  = textBoxName.Text;
            if (double.TryParse(textBoxBTC.Text, out temp))
            {
                client.BTC = temp;
            }
            else
            {
                MessageBox.Show("You must enter sum of BTC!");
                return;
            }
            if (double.TryParse(textBoxUSD.Text, out temp))
            {
                client.USD = temp;
            }
            else
            {
                MessageBox.Show("You must enter sum of USD!");
                return;
            }
            if (double.TryParse(textBoxCourseForBuy.Text, out temp))
                client.CourseForBuy = temp;
            else
            {
                MessageBox.Show("You must enter course for buy!");
                return;
            }
            if (double.TryParse(textBoxSumForBuy.Text, out temp))
                client.SumForBuy = temp;
            else
            {
                MessageBox.Show("You must enter sum for buy!");
                return;
            }
            if (double.TryParse(textBoxCourseForSell.Text, out temp))
            {
                client.CourseForSell = temp;
            }
            else
            {
                MessageBox.Show("You must enter course for sell");
                return;
            }
            if (double.TryParse(textBoxSumForSell.Text, out temp))
                client.SumForSell = temp;
            else
            {
                MessageBox.Show("You must enter sum for sell!");
                return;
            }

            clients.Add(client);
            stock.AddObserver(client);
            UpdateBinding();
          
        }
         void UpdateBinding()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = clients;
            comboBox1.DisplayMember = "Login";
        }

        void ShowClientInfo()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                Client client = comboBox1.SelectedItem as Client;
                textBoxName.Text = client.Login;
                textBoxBTC.Text = client.BTC.ToString();
                textBoxUSD.Text = client.USD.ToString();
                textBoxCourseForBuy.Text = client.CourseForBuy.ToString();
                textBoxSumForBuy.Text = client.SumForBuy.ToString();
                textBoxCourseForSell.Text = client.CourseForSell.ToString();
                textBoxSumForSell.Text = client.SumForSell.ToString();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Client client = comboBox1.SelectedItem as Client;
            double tmp = 0;
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("You need to enter name!");
                return;
            }
            client.Login = textBoxName.Text;
            if (double.TryParse(textBoxBTC.Text, out tmp))
            {
                client.BTC = tmp;
            }
            else
            {
                MessageBox.Show("You need to enter summary of BTC!");
                return;
            }
            if (double.TryParse(textBoxUSD.Text, out tmp))
            {
                client.USD = tmp;
            }
            else
            {
                MessageBox.Show("You need to enter summary of USD!");
                return;
            }
            if (double.TryParse(textBoxCourseForBuy.Text, out tmp))
            {
                client.CourseForBuy = tmp;
            }
            else
            {
                MessageBox.Show("You need to enter course for buy!");
                return;
            }
            if (double.TryParse(textBoxCourseForSell.Text, out tmp))
            {
                client.CourseForSell = tmp;
            }
            else
            {
                MessageBox.Show("You need to enter summary for sale!");
                return;
            }
            if (double.TryParse(textBoxSumForBuy.Text, out tmp))
            {
                client.SumForBuy = tmp;
            }
            else
            {
                MessageBox.Show("You need to enter summary for buy");
                return;
            }
            if (double.TryParse(textBoxSumForSell.Text, out tmp))
            {
                client.SumForSell = tmp;
            }
            else
            {
                MessageBox.Show("You need to enter summary for sale");
                return;
            }
            clients.Remove(client);
            clients.Add(client);
            stock.RemoveObserver(client);
            stock.AddObserver(client);
            UpdateBinding();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowClientInfo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                var clients = comboBox1.DataSource as List<Client>;
                clients.Remove(comboBox1.SelectedItem as Client);
                comboBox1.DataSource = null;
                comboBox1.DataSource = clients;
                this.comboBox1.DisplayMember = "Login";
                comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                textBoxName.Clear();
                textBoxBTC.Clear();
                textBoxUSD.Clear();
                textBoxCourseForBuy.Clear();
                textBoxSumForBuy.Clear();
                textBoxCourseForSell.Clear();
                textBoxSumForSell.Clear();
            }
        }
    }
}
