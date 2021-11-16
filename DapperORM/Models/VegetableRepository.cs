using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DapperORM.Models
{
    public  class VegetableRepository
    {


        public SqlConnection con;

        public object SqlMapper { get; private set; }

        //To Handle connection related activities      
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["Vegetable"].ToString();
            con = new SqlConnection(constr);

        }
        //To Add Employee details      
        public void Vegetable_Add(Vegetable veg)
        {

            //Additing the employess      
            try
            {
                connection();
                con.Open();
                con.Execute("Vegetable_Add", veg, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Vegetable> Vegetable_ViewAll()
        {
            try
            {
                connection();
                con.Open();
                IList<Vegetable> vege = sqlmapper.Query<Vegetable>( con, "Vegetable_ViewAll").ToList();
                con.Close();
                return vege.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Vegetable_Update(Vegetable veget)
        {
            try
            {
                connection();
                con.Open();
                con.Execute("Vegetable_Update", veget, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool Vegetable_Delete(int Id)
        {
            try
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@Veg_id", Id);
                connection();
                con.Open();
                con.Execute("Vegetable_Delete", param, commandType: CommandType.StoredProcedure);
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                //Log error as per your need       
                throw ex;
            }
        }
    }
} 