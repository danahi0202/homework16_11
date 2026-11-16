
using Dapper;
using System;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace windows_forms_threads_App
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
        private readonly string ConnectionString =
            @"Server=DESKTOP-S6BK4K0;Database=TestShop_P51;Integrated Security=True;TrustServerCertificate=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadCustomers();
        }

        public void ReadCustomers()
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                var customers = db.Query<Customer>(
                    "SELECT * FROM Customers;");

                list_box_users.Items.Clear();
                list_box_users.Items.AddRange(customers.ToArray());
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            using (var db = new SqlConnection(ConnectionString))
            {
                db.Execute(
                    "INSERT INTO Customers (Name, Email) VALUES (@Name, @Email);",
                    new
                    {
                        Name = text_box_name.Text,
                        Email = text_box_email.Text
                    });
            }

            ReadCustomers();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var customer = list_box_users.SelectedItem as Customer;

            if (customer == null) return;

            using (var db = new SqlConnection(ConnectionString))
            {
                db.Execute(
                    "UPDATE Customers SET Name = @Name, Email = @Email WHERE Id = @Id;",
                    new
                    {
                        Name = text_box_name.Text,
                        Email = text_box_email.Text,
                        Id = customer.Id
                    });
            }

            ReadCustomers();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            var customer = list_box_users.SelectedItem as Customer;

            if (customer == null) return;

            using (var db = new SqlConnection(ConnectionString))
            {
                db.Execute(
                    @"DELETE FROM Orders WHERE CustomerId = @Id;
                      DELETE FROM Customers WHERE Id = @Id;",
                    new { Id = customer.Id });
            }

            ReadCustomers();
        }

        private void list_box_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = list_box_users.SelectedItem as Customer;

            if (customer == null) return;

            text_box_name.Text = customer.Name;
            text_box_email.Text = customer.Email;
        }

        private void btn_result_click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                while (true)
                {
                    Console.WriteLine("Hello");
                    Thread.Sleep(1000);
                }
            })
            {
                IsBackground = true
            }.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}