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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            splitContainer1.Panel2.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           toolStripStatusLabel2.Text="Время: "+ DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            splitContainer1.Panel2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            try
            {
                List<Clients> clients = new List<Clients>();
                clients = DataBaseWork.ReadAllClients();
                //listBox1.DataSource = clients;
                dataGridView1.DataSource = clients;
                clients[0]
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ДобавитьСотрудника f1 = new ДобавитьСотрудника();
            f1.ShowDialog();
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_клиента f1 = new Добавить_клиента();
            f1.ShowDialog();
            
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (button1.Enabled==false)
            {
                Добавить_клиента f1 = new Добавить_клиента();
                f1.ShowDialog();
            }
            if (button2.Enabled==false)
            {
                Добавить_Тур f1 = new Добавить_Тур();
                f1.ShowDialog();
            }
        }

        private void просмотрToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Clients> clients = new List<Clients>();
            clients = DataBaseWork.ReadAllClients();
            dataGridView1.DataSource = clients;
        }
    }
}
