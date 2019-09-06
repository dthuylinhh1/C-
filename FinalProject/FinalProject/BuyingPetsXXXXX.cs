using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace FinalProject
{
    public partial class BuyingPetsXXXXX : Form
    {
        public BuyingPetsXXXXX()
        {
            InitializeComponent();
        }

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yvese\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";
        SqlConnection con;
      
        int selectedrowid;
       

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
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from pets", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void BuyingPets_Load(object sender, EventArgs e)
        {
            Binddata();
            pictureBox1.ImageLocation = @"C:\Users\yvese\Downloads\download.jpg";


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_buy_Click(object sender, EventArgs e)
        {
            

            if (dataGridView1.SelectedRows[0].Index != -1)
            {
                var result = MessageBox.Show("Do you sure?", "confirm box", MessageBoxButtons.YesNoCancel);

                SqlCommand delcmd = new SqlCommand();

                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    selectedrowid = dataGridView1.SelectedRows[0].Index + 1;
                    MessageBox.Show(selectedrowid.ToString() + " row selected");
                    delcmd.CommandText = " DELETE FROM pets WHERE pet_id =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    con.Open();
                    delcmd.Connection = con;
                    delcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");
                }
                Binddata();
            }
        }





      

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
