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
                        dataGridView1.DataSource = tours_list;
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
                        listBox1.Dock = DockStyle.Fill;

                        break;
                    }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] s1 = comboBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<>
        }
    }
}
