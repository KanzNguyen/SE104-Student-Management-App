using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABD
{
    internal class Database
    {
        private string connetionString = "Data Source=LAPTOP-B6MR34LM;Initial Catalog=QLSV;Integrated Security=True";
        private SqlConnection conn;
        private DataTable dt = new DataTable();
        private SqlCommand cmd;

        public Database()
        {
            try
            {
                conn = new SqlConnection(connetionString);


                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("connected failed:" + ex.Message);
            }
        }

        public DataTable SelectData(string sql, List<CustomParameter> firstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure; //set type cho
                foreach(var para in firstPara)
                {
                    cmd.Parameters.AddWithValue(para.key, para.value);
                }
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi load du lieu: " + ex.Message);
                return null;

            }
            finally
            {
                conn.Close();
            }
        }
        public DataRow Select(string sql)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                return dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load thông tin chi tiết: "+ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public int ExeCute(string sql, List<CustomParameter> firstPara)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                foreach (var p in firstPara)
                {
                    cmd.Parameters.AddWithValue(p.key, p.value);
                }
                var rs = cmd.ExecuteNonQuery();
                return (int)rs;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi thực thi câu lệnh: "+ex.Message);
                return -100;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

