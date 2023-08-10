using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace Finished_Goods_Warehouse_Management
{
    public partial class PickList: Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;

        private string myConnectionString = "server=localhost;uid=root;" +
                "pwd=Halapeti@1234;database= FinshedGoods";

        private static Random random = new Random();
        private string picklistId;
        private string ORDERID;
        List<Product> products1;
        public PickList(List<Product> products, string orderID)
        {
            InitializeComponent();
            products1 = products;
            ORDERID = orderID;
            DisplayPicklist();
            addToListView(products);
        }

        private void addToListView(List<Product> products)
        { 
            foreach (Product product in products)
            {
                int RowIndex = PickListDataGridView.Rows.Add();
                PickListDataGridView.Rows[RowIndex].Cells["Sl_no"].Value = RowIndex+1;
                PickListDataGridView.Rows[RowIndex].Cells["ProductID"].Value = product.productId;
                PickListDataGridView.Rows[RowIndex].Cells["StorageLocation"].Value = product.storageLocation;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PickListListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayPicklist()
        {
            picklistId = GeneratePicklistId();
            PickListIdLabel.Text = picklistId;
        }

        public static string GeneratePicklistId()
        {
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string allowedDigits = "0123456789";

            StringBuilder picklistId = new StringBuilder();

            // Append 3 random characters (letters) from allowedChars
            for (int i = 0; i < 3; i++)
            {
                picklistId.Append(allowedChars[random.Next(allowedChars.Length)]);
            }

            // Append a hyphen "-"
            picklistId.Append("-");

            // Append 3 random digits from allowedDigits
            for (int i = 0; i < 3; i++)
            {
                picklistId.Append(allowedDigits[random.Next(allowedDigits.Length)]);
            }

            return picklistId.ToString();
        }

        private void PickList_Load(object sender, EventArgs e)
        {

        }

        private void SendToForwardPicking_Click(object sender, EventArgs e)
        {
            updateOrderDetailsTable();
            updateProductDetailsTable(products1);
            this.Close();
        }

        private void CreatePDF(string productsString)
        {
            Document doc = new Document();
            try
            {
                string outputPath = "PickLists/" + picklistId + ".pdf";
                PdfWriter.GetInstance(doc, new FileStream(outputPath, FileMode.Create));
                doc.Open();
                doc.NewPage();
                Paragraph paragraph = new Paragraph(productsString);
                doc.Add(paragraph);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating PDF: " + ex.Message);
            }
            finally
            {
                doc.Close();
            }
        }

        private void create_pdf_Click(object sender, EventArgs e)
        {
            string productsString = convertProductsToString(products1, picklistId);
            CreatePDF(productsString);
        }

        private string convertProductsToString(List<Product> products, string picklistId)
        {
            StringBuilder productString = new StringBuilder();
            productString.Append("PickList ID: " + picklistId + "\n");
            productString.Append("---------------------------------\n");
            productString.Append("ProductId -- Storage Location\n");
            foreach (Product product in products)
            {
                int i = 1;
                productString.Append(i + ". " + product.productId.ToString() + " -- [ " + product.storageLocation.ToString() + " ]\n" );
                i++;
            }
            return productString.ToString();
        }

        private void updateOrderDetailsTable()
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            string query = "UPDATE OrderDetails SET Status = @Status WHERE OrderID = @OrderID";
            using (MySqlCommand command = new MySqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Status", "Forward Picking");
                command.Parameters.AddWithValue("@OrderID", ORDERID);

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

        private void updateProductDetailsTable(List<Product> products)
        {
            conn = new MySql.Data.MySqlClient.MySqlConnection();
            conn.ConnectionString = myConnectionString;
            conn.Open();
            foreach (Product product in products)
            {
                string query = "UPDATE ProductDetails SET Status = @Status, OrderID = @OrderID WHERE ProductID = @ProductID";
                using (MySqlCommand command = new MySqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Status", "Blocked");
                    command.Parameters.AddWithValue("@OrderID", ORDERID);
                    command.Parameters.AddWithValue("@ProductID", product.productId);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(0));
                        }
                        reader.Close();
                    }
                }
            }
            conn.Close();
        }
    }
}
