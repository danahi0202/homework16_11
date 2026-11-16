using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_forms_threads_app_2
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Email: {Email}";
        }
    }
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
    }
    public partial class Form1 : Form
    {
        private readonly string ConnectionString = @"Server=DESKTOP-S6BK4K0;Database=TestShop_P51;Integrated Security=True;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
            new Thread(() =>
            {
                ReadCustomers();
            }).Start();
        }
        public void ReadCustomers()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var sql = "SELECT * FROM Customers;";
                var customers = db.Query<Customer>(sql);

                if (list_box_users.IsHandleCreated)
                {
                    list_box_users.Invoke(new Action(() =>
                    {
                        list_box_users.Items.Clear();
                        list_box_users.Items.AddRange(customers.ToArray());
                    }));
                }
            }
        }
    }
}

