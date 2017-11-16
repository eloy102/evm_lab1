using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace tour_agenstvo
{
    public class ReportsCode
    {
        static public string stringCon = @"Data Source=DESKTOP-4HETE3A;Initial Catalog=tour_agenstvo;Persist Security Info=True;User ID=sa;Password=12708";
        public static List<HotelsForReport> ReadHotels()
        {
            using (SqlConnection sqlcon = new SqlConnection(stringCon))
            {
                var sql = "select Hotel,Country,Sity from tours";
                var result = sqlcon.Query<HotelsForReport>(sql);
                var result_list = result.ToList();
                return result_list;
            }
        }

        static public List<Country_Clients> Coutry_clients_report(int id_tour)
        {
            using (SqlConnection sqlcon = new SqlConnection(stringCon))
            {
                var sql = "select t.Name,c.FIO,c.Adult_Count,c.Children_Count,c.Summ" +
                    " from Tours t , Clients c where t.id_tour = @selected_tour and c.id_tour = @selected_tour";
                var result = sqlcon.Query<Country_Clients>(sql, new {selected_tour=id_tour } );
                List<Country_Clients> result_list = result.ToList();
                return result_list;
            }
        }

       // static public List<>
    }
}
