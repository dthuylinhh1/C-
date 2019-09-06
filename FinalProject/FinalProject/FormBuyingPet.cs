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
    public partial class FormBuyingPet : Form
    {
        public FormBuyingPet()
        {
            InitializeComponent();
        }

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yvese\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";
        SqlConnection con;

        int selectedrowid;

        private void PetsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.petsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);
            MessageBox.Show(database1DataSet.Tables[0].Rows[0][1].ToString());

            tableAdapterManager.petsTableAdapter.Update(database1DataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.pets' table. You can move, or remove it, as needed.
            this.petsTableAdapter.Fill(this.database1DataSet.pets);

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
        private void Btn_BUY_Click(object sender, EventArgs e)
        {
            DataRowView c =  petsBindingSource.Current as DataRowView;
            var id = c.Row[0];

            if (dataGridView1.SelectedRows[0].Index != -1)
            {

                var result = MessageBox.Show("Are you sure?", "confirm box", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                {
                    SqlCommand delcmd = new SqlCommand();

                    if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                    {
                        selectedrowid = dataGridView1.SelectedRows[0].Index + 1;
                        MessageBox.Show(selectedrowid.ToString() + " row selected");
                        delcmd.CommandText = " DELETE FROM pets WHERE pet_id =" +    dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
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
        }

        private void BACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void Btn_stuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stuff stuff = new Stuff();
            stuff.ShowDialog();
            this.Close();
        }

        private void Btn_hotel_Click(object sender, EventArgs e)
        {
            this.Hide();
            PetHotel petHotel= new PetHotel();
            petHotel.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home= new Home();
            home.ShowDialog();
            this.Close();
        }

        private void BACK_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
