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
    public partial class BOSS_STUFF : Form
    {
        public BOSS_STUFF()
        {
            InitializeComponent();
        }

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yvese\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        int selectedrowid;

        private void BOSS_STUFF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.stuffs' table. You can move, or remove it, as needed.
            this.stuffsTableAdapter.Fill(this.database1DataSet.stuffs);
            Binddata();

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ADD_Click(object sender, EventArgs e)
        {
            string Query = "insert into stuffs(stuff_name, price, quantity, category) values('" + NameTXT.Text + "','" + PriceTXT.Text + "', '" + QuantityTXT.Text + "', '" + CategoryTXT.Text + "');";
            con = new SqlConnection(connectionString);
            SqlCommand MyCommand2 = new SqlCommand(Query, con);
            SqlDataReader MyReader2;
            con.Open();

            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Data Saved");
            con.Close();
            Binddata();
            ClearData();
        }

        public void ClearData()
        {
            NameTXT.Text = "";
            PriceTXT.Text = "";
            QuantityTXT.Text = "";
            CategoryTXT.Text = "";
            
        }

        public void Binddata()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from stuffs", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Btn_DELETE_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index != -1)
            {
                SqlCommand delcmd = new SqlCommand();
                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    selectedrowid = dataGridView1.SelectedRows[0].Index + 1;
                    MessageBox.Show(selectedrowid.ToString() + " row selected");
                    delcmd.CommandText = " DELETE FROM stuffs WHERE stuff_id =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                    con.Open();
                    delcmd.Connection = con;
                    delcmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Record Deleted");
                }
                Binddata();
            }
        }

        private void Btn_EDIT_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows[0].Index != -1)
            {
                SqlCommand delcmd = new SqlCommand();
                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    selectedrowid = dataGridView1.SelectedRows[0].Index + 1;
                    MessageBox.Show(selectedrowid.ToString() + " row selected");


                    if (NameTXT.Text != "" && PriceTXT.Text != "" && QuantityTXT.Text != "" && CategoryTXT.Text != "")
                    {
                        cmd = new SqlCommand("update stuffs set stuff_name = @name, price = @price, quantity = @quantity, category = @category", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", selectedrowid);
                        cmd.Parameters.AddWithValue("@name", NameTXT.Text);
                        cmd.Parameters.AddWithValue("@price", PriceTXT.Text);
                        cmd.Parameters.AddWithValue("@quantity", QuantityTXT.Text);
                        cmd.Parameters.AddWithValue("@category", CategoryTXT.Text);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Update Successfully");
                        con.Close();
                        Binddata();

                        NameTXT.Text = "";
                        PriceTXT.Text = "";
                        QuantityTXT.Text = "";
                        CategoryTXT.Text = "";

                    }

                    else
                    {
                        if (dataGridView1.SelectedRows[0].Index != -1)
                        {
                            SqlCommand cmd = new SqlCommand();
                            if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                            {
                                selectedrowid = dataGridView1.SelectedRows[0].Index + 1;
                                MessageBox.Show(selectedrowid.ToString() + " row selected");
                                cmd.CommandText = " SELECT * FROM stuffs WHERE pet_id =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                                con.Open();
                                cmd.Connection = con;
                                // cmd = new SqlCommand("Select pet_price from pets where pet_id = @id", con);
                                // cmd.Parameters.AddWithValue("@id", id);
                                SqlDataReader rd = cmd.ExecuteReader();
                                while (rd.Read())
                                {
                                    NameTXT.Text = rd.GetValue(1).ToString();
                                    PriceTXT.Text = rd.GetValue(2).ToString();
                                    PriceTXT.Text = rd.GetValue(3).ToString();
                                    QuantityTXT.Text = rd.GetValue(4).ToString();
                                    CategoryTXT.Text = rd.GetValue(5).ToString();
                                }
                                cmd.Dispose();
                                con.Close();

                            }

                        }
                    }
                }
            }


        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
