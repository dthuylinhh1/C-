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

namespace FinalProject
{
    public partial class Stuff : Form
    {
        public Stuff()
        {
            InitializeComponent();
        }
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yvese\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";
        SqlConnection con;

        int selectedrowid;
        public int buyQuantity = 0;

        private void Stuff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.stuffs' table. You can move, or remove it, as needed.
            this.stuffsTableAdapter.Fill(this.database1DataSet.stuffs);

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        

        public void Binddata()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from stuffs", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            stuffsDataGridView.DataSource = dt;
            con.Close();
        }
        private void Btn_buy_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "confirm box", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlCommand delcmd = new SqlCommand();

                if (stuffsDataGridView.Rows.Count > 1 && stuffsDataGridView.SelectedRows[0].Index != stuffsDataGridView.Rows.Count - 1)
                {
                    selectedrowid = stuffsDataGridView.SelectedRows[0].Index + 1;
                    MessageBox.Show(selectedrowid.ToString() + " row selected");
                    delcmd.CommandText = " DELETE FROM stuffs WHERE stuff_id =" + stuffsDataGridView.SelectedRows[0].Cells[0].Value.ToString() + "";
                    con = new SqlConnection(connectionString);
                    con.Open();
                    delcmd.Connection = con;
                    delcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");
                }
            }

            Binddata();
        }
        private void QuantityTXT_TextChanged(object sender, EventArgs e)
        {
            DataRowView c = stuffsBindingSource.Current as DataRowView;
            var quantity = c.Row[3];
            var price = c.Row[2];
            int quantityNumber = int.Parse(QuantityTXT.Text);
            int quantityData = int.Parse(quantity.ToString());
            
            if (quantityNumber > quantityData)
            {
                MessageBox.Show("You can not purchase more than what we have");
                QuantityTXT.Text = quantity.ToString();
            }           
            
        }

        private void Btn_pet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuyingPet formBuyingPet = new FormBuyingPet();
            formBuyingPet.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void Btn_hotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetHotel petHotel = new PetHotel();
            petHotel.ShowDialog();
            this.Close();
        }
    }
}
