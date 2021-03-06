﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;
using Dapper;



namespace tour_agenstvo
{

    public class DataBaseWork
    {
        //static public string stringCon = @"Data Source=ILYA-ПК\SQLSERVER;Initial Catalog=tour_agenstvo;Persist Security Info=True;User ID=sa;Password=1111";
        static public string stringCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=tour_agenstvo;Persist Security Info=True;User ID=sa;Password=12708";
        static public async void add_client(Clients clients)
        {
            
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(stringCon))
                {
                    await sqlcon.OpenAsync();
                    SqlCommand sqlcom = new SqlCommand("Insert into [Clients] (FIO, pasport_serial, pasport_num, birthday, Registration,id_tour,summ) values (@FIO, @pasport_serial, @pasport_num, @birthday, @Registration, @id_tour, @Summ)", sqlcon);
                    sqlcom.Parameters.AddWithValue("FIO", clients.FIO);
                    sqlcom.Parameters.AddWithValue("pasport_serial", clients.pasport_serial);
                    sqlcom.Parameters.AddWithValue("pasport_num", clients.pasport_num);
                    sqlcom.Parameters.AddWithValue("birthday", clients.birthday);
                    sqlcom.Parameters.AddWithValue("Registration", clients.Registration);
                    sqlcom.Parameters.AddWithValue("id_tour", clients.id_tour);
                    sqlcom.Parameters.AddWithValue("Summ", clients.Summ);
                    await sqlcom.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        static public async void add_tour(Tours tours)
        {
            //string stringCon = @"Data Source=.\SQLSERVER;Initial Catalog=tour_agenstvo;Integrated Security=True";
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(stringCon))
                {
                    await sqlcon.OpenAsync();
                    SqlCommand sqlcom = new SqlCommand("Insert into [Tours] (Name, Country, Sity, Hotel, Summ) values (@Name, @Country, @Sity, @Hotel, @Summ)", sqlcon);
                    sqlcom.Parameters.AddWithValue("Name", tours.Name);
                    sqlcom.Parameters.AddWithValue("Country", tours.Country);
                    sqlcom.Parameters.AddWithValue("Sity", tours.Sity);
                    sqlcom.Parameters.AddWithValue("Hotel", tours.Hotel);
                    sqlcom.Parameters.AddWithValue("Summ", tours.Summ);
                    await sqlcom.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        static public async void add_employer(Employers employers)
        {
            //string stringCon = @"Data Source=.\SQLSERVER;Initial Catalog=tour_agenstvo;Integrated Security=True";
            try
            {
                using (SqlConnection sqlcon = new SqlConnection(stringCon))
                {
                    await sqlcon.OpenAsync();
                    SqlCommand sqlcom = new SqlCommand("Insert into [Employers] (FIO, pasport_serial, pasport_num, birthday, Registration,Position,Salary) values (@FIO, @pasport_serial, @pasport_num, @birthday, @Registration, @Position, @Salary)", sqlcon);
                    sqlcom.Parameters.AddWithValue("FIO", employers.FIO);
                    sqlcom.Parameters.AddWithValue("pasport_serial", employers.pasport_serial);
                    sqlcom.Parameters.AddWithValue("pasport_num", employers.pasport_num);
                    sqlcom.Parameters.AddWithValue("birthday", employers.birthday);
                    sqlcom.Parameters.AddWithValue("Registration", employers.Registration);
                    sqlcom.Parameters.AddWithValue("Position", employers.Position);
                    sqlcom.Parameters.AddWithValue("Salary", employers.Salary);
                    await sqlcom.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
        }

        static public List<Tours> ReadAllTours()
        {
            //string stringCon = @"Data Source=.\SQLSERVER;Initial Catalog=tour_agenstvo;Integrated Security=True";
                
                using (SqlConnection sqlcon = new SqlConnection(stringCon))
                {
                    sqlcon.Open();
                    var AllTours = sqlcon.GetAll<Tours>().ToList();
                    return AllTours;
                }
        }

        static public List<Clients> ReadAllClients()
        {
            //string stringCon = @"Data Source=.\SQLSERVER;Initial Catalog=tour_agenstvo;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(stringCon))
            {
                sqlcon.Open();
                var AllClients = sqlcon.GetAll<Clients>().ToList();
                return AllClients;
            }
        }
        static public List<Employers> ReadAllEmployers()
        {
            //string stringCon = @"Data Source=.\SQLSERVER;Initial Catalog=tour_agenstvo;Integrated Security=True";
            using (SqlConnection sqlcon = new SqlConnection(stringCon))
            {
                sqlcon.Open();
                return sqlcon.GetAll<Employers>().ToList();
            }
        }
        static public bool checkCon()
        {

            using (SqlConnection sqlcon = new SqlConnection(stringCon))
            {
                sqlcon.Open();
                if (sqlcon.State == System.Data.ConnectionState.Open) return true;
                else return false;
            }
        }

        static public decimal find_summ(int id)
        {
            using (SqlConnection sqlcon = new SqlConnection(stringCon))
            {
                var sql = "use tour_agenstvo" +
                    " select id_tour,Name, Country,Sity,Hotel,Summ from Tours where id_tour=@id_tour";
                var result = sqlcon.Query<Tours>(sql, new { id_tour = id });
                List<Tours> list = result.ToList();
                return list[0].Summ;
            }
         }
    }
}
