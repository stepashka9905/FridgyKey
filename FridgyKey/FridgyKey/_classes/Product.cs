using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgyKey
{
    public class Product
    {
        public string name;
        public string kkal;
        static public string Get_all_product(int i)
        {
            SqlConnection sqlCon = clsDB.Get_DB_Connection();
            try
            {
                DataTable dtf = clsDB.Get_DataTable("select * from [tblKkal];");

                string s = (string)dtf.Rows[i]["name"];
                return s;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                clsDB.Close_DB_Connection();
            }
        }
        static public int Get_count()
        {
            SqlConnection sqlCon = clsDB.Get_DB_Connection();
            try
            {
                DataTable dt2 = clsDB.Get_DataTable("select count(*) from [tblKkal];");
                int count = (int)dt2.Rows[0][0];
                return count;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                clsDB.Close_DB_Connection();
            }
        }
        static public void Set_product(int _amount, string name)
        {
            SqlConnection sqlCon = clsDB.Get_DB_Connection();
            try
            {
                clsDB.Execute_SQL("insert into [tblKkal] ([name], [kkal]) values ('" + name + "'," + _amount + ");");
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
            finally
            {
                clsDB.Close_DB_Connection();
            }
        }

    }
}
