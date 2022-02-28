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

        //listeli versiyon
        public List<Product> GetAll2()
        {
            SqlConnection connection = new SqlConnection(
             @"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

            //bağlantımız kapalı ise sunucuya bağlantı aç dedik
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }

            //benim string olarak yazdığım bir komutum var onu bağlantıya gönder dedik.
            SqlCommand command = new SqlCommand("Select * from Products", connection);

            //select komutunu çalıştırabilmek için execute reader kullandık
            //yani kodu çalıştırdık. ve onu reader a atadık.
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            //gelen kayıtları tek tek oku ve okuyabildiğin sürece
            //kod içinde çalıştır demek
            while (reader.Read())
            {
                Product product = new Product
                {
                    //burdaki amac readerden gelen id obje türünde olduğundan
                    //conver.toint32 yaparak inte döndürdük.
                    Id=Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StokAmount = Convert.ToInt32(reader["StokAmount"]),
                    UnitPrice= Convert.ToDecimal(reader["UnitPrice"]),
                };

                products.Add(product);
            }

            reader.Close();
            connection.Close();
            return products;
        }
    }
}
