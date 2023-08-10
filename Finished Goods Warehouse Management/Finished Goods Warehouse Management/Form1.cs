using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Finished_Goods_Warehouse_Management
{
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;

        private string myConnectionString = "server=localhost;uid=root;" +
                "pwd=Halapeti@1234;database= FinshedGoods";

        PickList PickListForm;

        List<Product> products1 = new List<Product>();

        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void RefreshOrders_Click(object sender, EventArgs e)
        {
            MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Fetching orders from database");
            Order order = new Order();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string query = "SELECT * FROM OrderDetails WHERE status <> 'Completed'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            OrderDataGridView.Rows.Clear();

            while (reader.Read())
            {
                order.orderId = reader.GetString("OrderID");
                order.customerId = reader.GetString("CustomerID");
                order.productTypeId = reader.GetString("ProductTypeID");
                order.quantity = reader.GetString("Quantity");
                order.date = reader.GetString("Date");
                order.dueDate = reader.GetString("DueDate");
                order.status = reader.GetString("Status");

                int RowIndex = OrderDataGridView.Rows.Add();
                OrderDataGridView.Rows[RowIndex].Cells["OrderID"].Value = order.orderId;
                OrderDataGridView.Rows[RowIndex].Cells["CustomerID"].Value = order.customerId;
                OrderDataGridView.Rows[RowIndex].Cells["ProductTypeID"].Value = order.productTypeId;
                OrderDataGridView.Rows[RowIndex].Cells["Quantity"].Value = order.quantity;
                OrderDataGridView.Rows[RowIndex].Cells["Date"].Value = order.date;
                OrderDataGridView.Rows[RowIndex].Cells["DueDate"].Value = order.dueDate;
                OrderDataGridView.Rows[RowIndex].Cells["Status"].Value = order.status;

            }
            reader.Close();
            conn.Close();
            MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Successful");
        }

        private void IncomingGoodsRefresh_Click(object sender, EventArgs e)
        {
            MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Fetching data from database");
            Product product = new Product();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string status = StatusComboBox.Text;
            string query = "SELECT * FROM ProductDetails WHERE  Status = " + "'" + status + "'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            IncomingOrdersDataGridView.Rows.Clear();

            while (reader.Read())
            {
                product.productId = reader.GetString("ProductID");
                product.typeId = reader.GetString("TypeID");
                product.storageLocation = reader.GetString("StorageLocation");
                product.status = reader.GetString("Status");

                int RowIndex = IncomingOrdersDataGridView.Rows.Add();
                IncomingOrdersDataGridView.Rows[RowIndex].Cells["ProductID"].Value = product.productId;
                IncomingOrdersDataGridView.Rows[RowIndex].Cells["TypeID"].Value = product.typeId;
                IncomingOrdersDataGridView.Rows[RowIndex].Cells["StorageLocation"].Value = product.storageLocation;
                IncomingOrdersDataGridView.Rows[RowIndex].Cells["ProductStatus"].Value = product.status;

            }
            reader.Close();
            conn.Close();
            MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Successful");
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void GeneratePickList_Click(object sender, EventArgs e)
        {
            string productTypeId = OrderDataGridView.Rows[OrderDataGridView.CurrentCell.RowIndex].Cells["ProductTypeID"].Value.ToString();
            string orderID = OrderDataGridView.Rows[OrderDataGridView.CurrentCell.RowIndex].Cells["OrderID"].Value.ToString();
            string q = OrderDataGridView.Rows[OrderDataGridView.CurrentCell.RowIndex].Cells["Quantity"].Value.ToString();
            if (!string.IsNullOrEmpty(q))
            {
                int quantity = int.Parse(q);
                List<Product> products = new List<Product>();
                products = queryForPickList(productTypeId, quantity);
                int productscount = products.Count();
                if (productscount >= quantity)
                {
                    for(int i = 0; i<quantity; i++)
                    {
                        products1.Add(products[i]);
                    }
                    PickListForm = new PickList(products1, orderID);
                    PickListForm.ShowDialog();
                    MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Picklist Generated");
                }
            }


        }

        private List<Product> queryForPickList(string productTypeId, int quantity)
        {
           
            List<Product> products = new List<Product>();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string status = StatusComboBox.Text;
            string query = "SELECT * FROM ProductDetails WHERE  TypeID = @ProductTypeId AND StorageLocation <> '' AND Status = @Status";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@ProductTypeId", productTypeId);
                command.Parameters.AddWithValue("@Status", "Consumable");

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product product = new Product
                        {
                            productId = reader.GetString("ProductID"),
                            typeId = reader.GetString("TypeID"),
                            storageLocation = reader.GetString("StorageLocation"),
                            status = reader.GetString("Status")
                    };
                        products.Add(product);
                       
                    }
                    reader.Close();
                }
            }
            return products;
        }

        private void IncomingOrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IncomingOrdersDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductMenuStrip.Show(IncomingOrdersDataGridView, 0, 0);

        }

        private void ProductMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }

        private void AssignStorageLocation_Click(object sender, EventArgs e)
        {
            if(IncomingOrdersDataGridView.Rows[IncomingOrdersDataGridView.CurrentCell.RowIndex].Cells["StorageLocation"].Value != null)
            {
                MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Assigning Location...");
                StorageLocation storageLocation = new StorageLocation();
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                string status = StatusComboBox.Text;
                string query = "SELECT * FROM WareHouseLocations WHERE  ProductID = ''";
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                string primarykey = "";

                while (reader.Read())
                {
                    storageLocation.Building = reader.GetInt16("Building");
                    storageLocation.Aisle = reader.GetString("Aisle");
                    storageLocation.Bay = reader.GetInt16("Bay");
                    storageLocation.Tier = reader.GetString("Tier");
                    storageLocation.Position = reader.GetInt16("Position");
                    storageLocation.createLocationId();
                    primarykey = storageLocation.getPrimaryKey();

                    IncomingOrdersDataGridView.Rows[IncomingOrdersDataGridView.CurrentCell.RowIndex].Cells["StorageLocation"].Value = primarykey;

                }
                reader.Close();
                conn.Close();

                string productid = IncomingOrdersDataGridView.Rows[IncomingOrdersDataGridView.CurrentCell.RowIndex].Cells["ProductID"].Value.ToString();
                updatestoragelocationtable(storageLocation, productid);
                updateproductdetailstable(productid, primarykey);
            }
            else
            {
                Console.WriteLine("Location already assigned");
            }
        }

        private void updatestoragelocationtable(StorageLocation storageLocation, string productid)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string query = "UPDATE WareHouseLocations SET ProductID = @Productid WHERE Building = @Building AND Aisle = @Aisle AND Bay = @Bay AND Tier = @Tier AND Position = @Position";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Productid", productid);
                command.Parameters.AddWithValue("@Building", storageLocation.Building);
                command.Parameters.AddWithValue("@Aisle", storageLocation.Aisle);
                command.Parameters.AddWithValue("@Bay", storageLocation.Bay);
                command.Parameters.AddWithValue("@Tier", storageLocation.Tier);
                command.Parameters.AddWithValue("@Position", storageLocation.Position);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Process the retrieved data
                        // For example, you can access columns using reader.GetInt32(), reader.GetString(), etc.
                        Console.WriteLine(reader.GetString(0));
                    }
                    reader.Close();
                }
                
            }
            conn.Close();
            MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Product assigned to storage location");
        }

        private void updateproductdetailstable(string productid, string primarykey)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string query = "UPDATE ProductDetails SET StorageLocation = @StorageLocation WHERE ProductID = @ProductID";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@StorageLocation", primarykey);
                command.Parameters.AddWithValue("@ProductID", productid);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Process the retrieved data
                        // For example, you can access columns using reader.GetInt32(), reader.GetString(), etc.
                        Console.WriteLine(reader.GetString(0));
                    }
                }
            }
            MessageBox_IncomingGoods.Items.Add(DateTime.Now.ToString() + "   " + "Product details updated");
        }

        private void MessageBox_IncomingGoods_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrderDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                string status = OrderDataGridView.Rows[OrderDataGridView.CurrentCell.RowIndex].Cells["Status"].Value.ToString();
                if(status =="In progress")
                {
                    contextMenuStrip1.Items["GeneratePicklist"].Enabled = true;
                    contextMenuStrip1.Items["SendForPackaging"].Enabled = false;
                    contextMenuStrip1.Items["SendForShipping"].Enabled = false;
                }
                else if(status == "Forward Picking")
                {
                    contextMenuStrip1.Items["GeneratePicklist"].Enabled = false;
                    contextMenuStrip1.Items["SendForPackaging"].Enabled = true;
                    contextMenuStrip1.Items["SendForShipping"].Enabled = false;
                }
                else if (status == "Packaging")
                {
                    contextMenuStrip1.Items["GeneratePicklist"].Enabled = false;
                    contextMenuStrip1.Items["SendForPackaging"].Enabled = false;
                    contextMenuStrip1.Items["SendForShipping"].Enabled = true;
                }
                else if(status == "Shipping")
                {
                    contextMenuStrip1.Items["GeneratePicklist"].Enabled = false;
                    contextMenuStrip1.Items["SendForPackaging"].Enabled = false;
                    contextMenuStrip1.Items["SendForShipping"].Enabled = false;
                }
                else
                {
                    contextMenuStrip1.Items["GeneratePicklist"].Enabled = false;
                    contextMenuStrip1.Items["SendForPackaging"].Enabled = false;
                    contextMenuStrip1.Items["SendForShipping"].Enabled = false;
                }
                contextMenuStrip1.Show(OrderDataGridView, 0, 0);
            }
        }

        private void SendForPackaging_Click(object sender, EventArgs e)
        {
            updateOrderDetailsTable_Packaging("Packaging");
            updateProductDetailsTable_Packaging();
        }

        private void updateOrderDetailsTable_Packaging(string status)
        {
            string orderID = OrderDataGridView.Rows[OrderDataGridView.CurrentCell.RowIndex].Cells["OrderID"].Value.ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string query = "UPDATE OrderDetails SET Status = @Status WHERE OrderID = @OrderID";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Status", status);
                command.Parameters.AddWithValue("@OrderID", orderID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            conn.Close();
        }

        private void updateProductDetailsTable_Packaging()
        {
            string orderID = OrderDataGridView.Rows[OrderDataGridView.CurrentCell.RowIndex].Cells["OrderID"].Value.ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();

            string query = "UPDATE ProductDetails SET Status = @Status WHERE OrderID = @OrderID";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Status", "Consumed");
                command.Parameters.AddWithValue("@OrderID", orderID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            
            conn.Close();
        }

        private void SendForShipping_Click(object sender, EventArgs e)
        {
            updateOrderDetailsTable_Packaging("Shipping");
        }
    }

}
