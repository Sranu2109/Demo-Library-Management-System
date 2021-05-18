using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibManagement
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void brnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthorName.Text != "" && txtPublication.Text != "" && txtBookPrice.Text != "" && txtBookQuantity.Text != "")
            {


                String bName = txtBookName.Text;
                String bAuthor = txtAuthorName.Text;
                String publication = txtPublication.Text;
                String pdate = dateTimePicker1.Text;
                Int64 price = Int64.Parse(txtBookPrice.Text);
                Int64 Quan = Int64.Parse(txtBookQuantity.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-UI4FHMJ\\SQLEXPRESS; database=libManagementDB; integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into NewBook1(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('" + bName + "','" + bAuthor + "','" + publication + "','" + pdate + "'," + price + "," + Quan + ")";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthorName.Clear();
                txtPublication.Clear();
                txtBookPrice.Clear();
                txtBookQuantity.Clear();
            }
            else
            {
                MessageBox.Show("Empty field NOT Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("This will DELETE your Unsaved DATA.","Are you Sure?",MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
            this.Close();
            }
        }
    }
}
