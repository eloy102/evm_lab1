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
    public partial class ListClients : Form
    {
        public ListClients()
        {
            InitializeComponent();
        }

        private void ListClients_Load(object sender, EventArgs e)
        {
             try
            {
                List<Clients> list = new List<Clients>();
                list = DataBaseWork.ReadAllClients();
                List<Tours> list_tours = new List<Tours>();
                foreach (var l in list)
                {
                    string name_tour="";
                    foreach (var t in list_tours)
                    {
                        if (l.id_tour == t.id_tour) name_tour = t.Name;
                    }
                    listBox1.Items.Add("ФИО:"+l.FIO+" Прописка:"+l.Registration+" Тур:"+ name_tour+" Количество взрослых:"+l.Adult_count+ " Количество детей:" +l.Children_Count+ "Итоговая сумма:"+l.Summ );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
