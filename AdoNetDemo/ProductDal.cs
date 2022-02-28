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
        SqlConnection _connection = new SqlConnection(
             @"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public DataTable GetAll()
        {
            
            //bağlantımız kapalı ise sunucuya bağlantı aç dedik
            if (_connection.State==ConnectionState.Closed)
            {
                _connection.Open();
            }
            
            //benim string olarak yazdığım bir komutum var onu bağlantıya gönder dedik.
            SqlCommand command = new SqlCommand("Select * from Products",_connection);

            //select komutunu çalıştırabilmek için execute reader kullandık
            //yani kodu çalıştırdık. ve onu reader a atadık.
            SqlDataReader reader = command.ExecuteReader();

            //datatable bizden IDataReader istiyor parametre olarak
            //IDataReader ise sqldatareaderin basesidir F12 ile gidip 
            //kontrol edebilirsin.
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        //listeli versiyon
        public List<Product> GetAll2()
        {
            ConnectionControl();

            //benim string olarak yazdığım bir komutum var onu bağlantıya gönder dedik.
            SqlCommand command = new SqlCommand("Select * from Products", _connection);

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
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StokAmount = Convert.ToInt32(reader["StokAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                };

                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            //bağlantımız kapalı ise sunucuya bağlantı aç dedik
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@StokAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stokAmount", product.StokAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Products set Name=@name,UnitPrice=@unitPrice,StokAmount=@stokAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stokAmount", product.StokAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }
        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Products where Id=@id", _connection);
           
            command.Parameters.AddWithValue("@id",Id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

    }
}
