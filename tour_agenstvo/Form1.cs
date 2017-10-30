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
            
            toolStripStatusLabel1.Text = "Не Подключено";
           
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
                listBox1.Items.Clear();
                List<Clients> clients = DataBaseWork.ReadAllClients();
                List<Tours> tours = DataBaseWork.ReadAllTours();

                foreach (var c in clients)
                {
                    listBox1.Items.Add("ID: " + c.id + ",  ФИО:" + c.FIO + ",  Паспортные данные:" + c.pasport_serial + c.pasport_num + ",  Дата рождения:" + c.birthday + ",  Тур:" +tours[c.id_tour-1].Name+ ",  Сумма:"+ c.Summ);
                }
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
            try
            {
                listBox1.Items.Clear();
                List<Tours> tours = DataBaseWork.ReadAllTours();
                foreach (var t in tours)
                {
                    listBox1.Items.Add("ID: " +t.id_tour+",  Название:"+t.Name+",  Страна:"+t.Country+",  Город:"+t.Sity+
                }
            }
            catch(Exception ex)
            {

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


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                bool conState = DataBaseWork.checkCon();
                if (conState == true) toolStripStatusLabel1.Text = "Подключено";
                else toolStripStatusLabel1.Text = "Не Подключено";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            }
        }
    }
}
