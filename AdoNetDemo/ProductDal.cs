using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
   public class ProductDal
    {
        public DataTable GetAll()
        {
            SqlConnection connection = new SqlConnection(
             @"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
            
            //bağlantımız kapalı ise sunucuya bağlantı aç dedik
            if (connection.State==ConnectionState.Closed)
            {
                connection.Open();
            }
            
            //benim string olarak yazdığım bir komutum var onu bağlantıya gönder dedik.
            SqlCommand command = new SqlCommand("Select * from Products",connection);

            //select komutunu çalıştırabilmek için execute reader kullandık
            //yani kodu çalıştırdık. ve onu reader a atadık.
            SqlDataReader reader = command.ExecuteReader();

            //datatable bizden IDataReader istiyor parametre olarak
            //IDataReader ise sqldatareaderin basesidir F12 ile gidip 
            //kontrol edebilirsin.
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            connection.Close();
            return dataTable;
        }
    }
}
