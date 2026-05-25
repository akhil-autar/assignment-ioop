using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gr8FoodSystem_Final
{
    public partial class BrowseMenuFinal : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=GR8Food;Integrated Security=True;TrustServerCertificate=True";
        public BrowseMenuFinal()
        {
            InitializeComponent();
        }

        private void BrowseMenuFinal_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Add("All");
            cmbCategory.Items.Add("Breakfast");
            cmbCategory.Items.Add("Lunch");
            cmbCategory.Items.Add("Dinner");
            cmbCategory.Items.Add("Snacks");

            cmbCategory.SelectedIndex = 0;
            LoadMenu();
           
        }
        private void LoadMenu(string search = "", string category = "All")
        {
            flowLayoutPanel1.Controls.Clear();

            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            string query = "SELECT * FROM menu_table WHERE MenuName LIKE @search";

            if (category != "All")
            {
                query += " AND Category = @category";
            }

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@search", "%" + search + "%");

            if (category != "All")
            {
                cmd.Parameters.AddWithValue("@category", category);
            }
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = reader["MenuName"].ToString();

                string menuCategory = reader["Category"].ToString();

                decimal price = Convert.ToDecimal(reader["Price"]);
                byte[] img = (byte[])reader["MenuPic"];

                flowLayoutPanel1.Controls.Add(
                    CreateFoodCard(name, menuCategory, price, img));

            }

            con.Close();
        }
        
        private Panel CreateFoodCard(
        string name,
        string menuCategory,
        decimal price,
         byte[] imageData)
        {
            Panel card = new Panel();

            card.Size = new Size(230, 220);

            card.BackColor = Color.White;

            card.BorderStyle = BorderStyle.FixedSingle;

            card.Margin = new Padding(10);

            PictureBox pic = new PictureBox();
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    MemoryStream ms = new MemoryStream(imageData);

                    pic.Image = Image.FromStream(ms);
                }
                catch
                {
                    pic.BackColor = Color.LightGray;
                }
            }
            else
            {
                pic.BackColor = Color.LightGray;
            }
            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            pic.Size = new Size(220, 90);

            pic.Location = new Point(10, 10);

            pic.BackColor = Color.LightGray;

            pic.SizeMode =
                PictureBoxSizeMode.StretchImage;

            Label lblName = new Label();

            lblName.Text = name;

            lblName.Font =
                new Font("Segoe UI", 11, FontStyle.Bold);

            lblName.Location = new Point(10, 110);

            lblName.AutoSize = true;

            Label lblCategory = new Label();

            lblCategory.Text = menuCategory;

            lblCategory.Location =
                new Point(10, 135);

            lblCategory.ForeColor = Color.Gray;

            Label lblPrice = new Label();

            lblPrice.Text = "RM " + price;

            lblPrice.ForeColor = Color.Green;

            lblPrice.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            lblPrice.Location =
                new Point(10, 155);

            Button btnAdd = new Button();

            btnAdd.Text = "+ Add";

            btnAdd.Size = new Size(180, 30);

            btnAdd.Location = new Point(20, 180);


            btnAdd.BackColor = Color.Crimson;

            btnAdd.ForeColor = Color.White;

            btnAdd.FlatStyle = FlatStyle.Flat;

            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Click += (sender, e) =>
            {
                Cart.AddItem(name);
                MessageBox.Show(name + "added to cart!");
            };

            card.Controls.Add(pic);

            card.Controls.Add(lblName);

            card.Controls.Add(lblCategory);

            card.Controls.Add(lblPrice);

            card.Controls.Add(btnAdd);

            return card;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadMenu(txtSearch.Text, cmbCategory.Text);
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMenu(txtSearch.Text, cmbCategory.Text);
        }
    }

}
