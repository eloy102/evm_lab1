using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tour_agenstvo
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main1_Load(object sender, EventArgs e)
        {
            ToursflowLayoutPanel5.Visible = false;
            ClientflowLayoutPanel3.Visible = false;
            OtchflowLayoutPanel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToursflowLayoutPanel5.Visible = false;
            OtchflowLayoutPanel4.Visible = false;
            ClientflowLayoutPanel3.Visible = true;
            ClientflowLayoutPanel3.Dock = DockStyle.Fill;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ToursflowLayoutPanel5.Visible = true;
            OtchflowLayoutPanel4.Visible = false;
            ClientflowLayoutPanel3.Visible = false;
            ToursflowLayoutPanel5.Dock = DockStyle.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ToursflowLayoutPanel5.Visible = false;
            ClientflowLayoutPanel3.Visible = false;
            OtchflowLayoutPanel4.Visible = true;
            OtchflowLayoutPanel4.Dock = DockStyle.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Добавить_клиента добавить_Клиента = new Добавить_клиента();
                добавить_Клиента.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();
            listForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Добавить_Тур добавить_Тур = new Добавить_Тур();
            добавить_Тур.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();
            listForm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ListClients listClients = new ListClients();
            listClients.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Добавить_клиента добавить_Клиента = new Добавить_клиента();
            добавить_Клиента.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OtchetForm otchetForm = new OtchetForm(1);
            otchetForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OtchetForm otchetForm = new OtchetForm(2);
            otchetForm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OtchetForm otchetForm = new OtchetForm(3);
            otchetForm.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OtchetForm otchetForm = new OtchetForm(4);
            otchetForm.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OtchetForm otchetForm = new OtchetForm(5);
            otchetForm.Show();
        }
    }
}
