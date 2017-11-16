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
    public partial class OtchetForm : Form
    {
        public OtchetForm(int buff_X)
        {
            InitializeComponent();
            this.x = buff_X;
        }
        int x;

        private void OtchetForm_Load(object sender, EventArgs e)
        {
            //если х==1 вывод базы клиентов
            //если х=2 вывод базы туров
            //если х=3 вывод базы отелей
            //если х=4 вывод отчета клиентов по странам
            //если х=5 вывод отчета клиентов по турам
            panel1.Visible = false;
            dataGridView1.Visible = false;


            switch (x)
            {
                case 1:
                    {
                        List<Clients> clients_list = new List<Clients>();
                        clients_list = DataBaseWork.ReadAllClients();
                        dataGridView1.Visible = true;
                        dataGridView1.Dock = DockStyle.Fill;
                        dataGridView1.DataSource = clients_list;
                        break;
                    }
                case 2:
                    {
                        List<Tours> tours_list = new List<Tours>();
                        dataGridView1.Visible = true;
                        dataGridView1.Dock = DockStyle.Fill;
                        tours_list = DataBaseWork.ReadAllTours();
                        dataGridView1.DataSource = tours_list;
                        break;
                    }
                case 3:
                    {
                        List<HotelsForReport> list = new List<HotelsForReport>();
                        list = ReportsCode.ReadHotels();
                        dataGridView1.DataSource = list;
                        dataGridView1.Visible = true;
                        dataGridView1.Dock = DockStyle.Fill;
                        break;
                    }

                case 4:
                    {
                        List<Tours> tour_list = DataBaseWork.ReadAllTours();
                        foreach (var t in tour_list)
                        {
                            comboBox1.Items.Add(t.id_tour + " " + t.Name);
                        }
                        panel1.Visible = true;
                        panel1.Dock = DockStyle.Fill;
                        listBox1.Visible = true;
                       // listBox1.Dock = DockStyle.Fill;

                        break;
                    }
                case 5:
                    {
                        List<Employers> list = new List<Employers>();
                        list = DataBaseWork.ReadAllEmployers();
                        dataGridView1.DataSource = list;
                        dataGridView1.Visible = true;
                        dataGridView1.Dock = DockStyle.Fill;
                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s1 = comboBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<Tours_Clients> list = ReportsCode.Tours_clients_report(Convert.ToInt32(s1[0]));
            foreach(var l in list)
            {
                listBox1.Items.Add("Название тура:" + l.Name + "  ФИО клиента:" + l.FIO + "  Страна:" + l.Country + "  Количество взрослых" + l.Adult_Count + "  Количество детей:" + l.Children_count + "  Сумма:" + l.Summ);
            }
        }
    }
}
