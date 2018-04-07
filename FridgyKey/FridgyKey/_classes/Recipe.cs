using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgyKey
{
    public static class Recipe
    {
        public static string name;
        public static string text;
        public static string icon_path;
        public static int kkal;
        public static string notation;
        public static List<Ingredient> list_ingredients;

        //static public int Get_count()
        //{
        //    SqlConnection sqlCon = clsDB.Get_DB_Connection();
        //    try
        //    {
        //        DataTable dt2 = clsDB.Get_DataTable("select count(*) from [tblFrost] where [frostID]=" + User.FrostID + ";");
        //        int count = (int)dt2.Rows[0][0];
        //        return count;
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.MessageBox.Show(ex.Message);
        //        return 0;
        //    }
        //    finally
        //    {
        //        clsDB.Close_DB_Connection();
        //    }
        //}
        //static public string Get_recipe(int i)
        //{
        //    SqlConnection sqlCon = clsDB.Get_DB_Connection();
        //    try
        //    {
        //        DataTable dt1 = clsDB.Get_DataTable("select * from [tblFrost] where [frostID]=" + User.FrostID + ";");
        //        DataTable dt2 = clsDB.Get_DataTable("select * from [tblRecipeIn] where [productID]=" + (int)dt1.Rows[i]["productID"] + ";");
        //        DataTable dt3 = clsDB.Get_DataTable("select * from [tblRecipeMain] where [ingredientsID]=" + (int)dt2.Rows[i]["Id"] + ";");
                
        //        string s = (string)dt.Rows[0]["name"] + " (" + (int)dt.Rows[i]["amount"] + " " + (string)dt.Rows[i]["ei"] + " " + (String.Format("{0}.{1}.{2}", ((DateTime)dt.Rows[i]["valid"]).Day, ((DateTime)dt.Rows[i]["valid"]).Month, ((DateTime)dt.Rows[i]["valid"]).Year) + " )");
        //        return s;
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Windows.MessageBox.Show(ex.Message);
        //        return null;
        //    }
        //    finally
        //    {
        //        clsDB.Close_DB_Connection();
        //    }
        //}
    }
}
