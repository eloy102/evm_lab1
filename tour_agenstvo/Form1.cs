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
            timer1.Interval = 1000;
        }
        int flag = -1;
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
            timer1.Enabled = true;
            timer1.Start();
            splitContainer1.Panel2.Enabled = false;          
            toolStripStatusLabel1.Text = "Не Подключено";
            ToolTip t = new ToolTip();
            t.SetToolTip(button1, "Отобразить базу клиентов");
            t.SetToolTip(button2, "Отобразить базу туров");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           toolStripStatusLabel2.Text="Время: "+ DateTime.Now.ToLongTimeString();
            
            if (flag == 1)
            {
                List<Clients> clients = DataBaseWork.ReadAllClients();
                dataGridView1.DataSource = clients;
                dataGridView1.Refresh();
            }
            if (flag ==2 )
            {
                List<Tours> tours = DataBaseWork.ReadAllTours();
                dataGridView1.DataSource = tours;
                dataGridView1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flag = 1;
            toolStripButton1.ToolTipText = "Добавить Клиента";
            splitContainer1.Panel2.Enabled = true;
            button1.Enabled = false;
            button2.Enabled = true;
            try
            {
                //listBox1.Items.Clear();
                List<Clients> clients = DataBaseWork.ReadAllClients();
                List<Tours> tours = DataBaseWork.ReadAllTours();

               
                dataGridView1.DataSource = clients;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = 2;
            toolStripButton1.ToolTipText = "Добавить Тур";
            button1.Enabled = true;
            button2.Enabled = false;
            try
            {

                List<Tours> tours = DataBaseWork.ReadAllTours();

                dataGridView1.DataSource = tours;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                Добавить_клиента f1 = new Добавить_клиента();
                f1.ShowDialog();
            }
            if (flag==2)
            {
                Добавить_Тур f2 = new Добавить_Тур();
                f2.ShowDialog();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }

        private void просмотрToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void добавитьТурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Добавить_Тур f2 = new Добавить_Тур();
            f2.ShowDialog();
        }
    }
}
