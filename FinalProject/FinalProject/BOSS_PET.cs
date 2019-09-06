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
using System.Xml.Serialization;

namespace FinalProject
{
    public partial class BOSS_PET : Form
    {
        public BOSS_PET()
        {
            InitializeComponent();
        }


        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yvese\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        int selectedrowid;

        private void Btn_add_Click(object sender, EventArgs e)
        {
            string Query = "insert into pets(pet_name, pet_price, pet_species, pet_breed, pet_age, pet_gender, stock) values('" + NameTXT.Text +"','"+ PriceTXT.Text +"', '"+SpeciesTXT.Text+"', '"+BreedTXT.Text+"','"+AgeTXT.Text+"', '"+GenderTXT.Text+"','"+ StockTXT.Text+"');";
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
            SpeciesTXT.Text = "";
            BreedTXT.Text = "";
            AgeTXT.Text = "";
            GenderTXT.Text = "";
            StockTXT.Text = "";
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

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index != -1)
            {
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

        private void BOSS_PET_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.pets' table. You can move, or remove it, as needed.
            this.petsTableAdapter.Fill(this.database1DataSet.pets);

            Binddata();
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].Index != -1)
            {

                if (dataGridView1.Rows.Count > 1 && dataGridView1.SelectedRows[0].Index != dataGridView1.Rows.Count - 1)
                {
                    if (NameTXT.Text != "" && PriceTXT.Text != "" && SpeciesTXT.Text != "" && BreedTXT.Text != "" && AgeTXT.Text != "" && GenderTXT.Text != "" && StockTXT.Text != "")
                    {
                        cmd = new SqlCommand("update pets set pet_name = @name, pet_price = @price, pet_species = @species, pet_breed = @breed, pet_age = @age, pet_gender = @gender, stock = @stock where pet_id = @id", con);
                        con.Open();
                        cmd.Parameters.AddWithValue("@id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("@name", NameTXT.Text);
                        cmd.Parameters.AddWithValue("@price", PriceTXT.Text);
                        cmd.Parameters.AddWithValue("@species", SpeciesTXT.Text);
                        cmd.Parameters.AddWithValue("@breed", BreedTXT.Text);
                        cmd.Parameters.AddWithValue("@age", AgeTXT.Text);
                        cmd.Parameters.AddWithValue("@gender", GenderTXT.Text);
                        cmd.Parameters.AddWithValue("@stock", StockTXT.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Update Successfully");
                        con.Close();
                        Binddata();

                        ClearData();
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
                                cmd.CommandText = " SELECT * FROM pets WHERE pet_id =" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "";
                                con.Open();
                                cmd.Connection = con;
                                // cmd = new SqlCommand("Select pet_price from pets where pet_id = @id", con);
                                // cmd.Parameters.AddWithValue("@id", id);
                                SqlDataReader rd = cmd.ExecuteReader();
                                while (rd.Read())
                                {
                                    NameTXT.Text = rd.GetValue(1).ToString(); 
                                    PriceTXT.Text = rd.GetValue(2).ToString();
                                    SpeciesTXT.Text = rd.GetValue(3).ToString();
                                    BreedTXT.Text = rd.GetValue(4).ToString();
                                    AgeTXT.Text = rd.GetValue(5).ToString();
                                    GenderTXT.Text = rd.GetValue(6).ToString();
                                    StockTXT.Text = rd.GetValue(7).ToString();
                                }
                                cmd.Dispose();
                                con.Close();
                            }
                        }
                    }
                }
               

            }
            

        }

        private void Btn_upload_Click(object sender, EventArgs e)
        {
          DialogResult d = openFileDialog1.ShowDialog();
            if (d==DialogResult.OK)
            {
                //string fileName = openFileDialog1.FileName;
                //System.IO.FileStream fileStream = new System.IO.FileStream(fileName);

                //update pet set picture = 
            }
        }

        private void PetsBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            MessageBox.Show("XX");
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Btn_serialize_Click(object sender, EventArgs e)
        {
            string name = NameTXT.Text;
            string price = PriceTXT.Text;
            string species = SpeciesTXT.Text;
            string breed = BreedTXT.Text;
            string age = AgeTXT.Text;
            string gender = GenderTXT.Text;
            string stock = StockTXT.Text;
            // get the information from the text boxes and 
            //Xml Serialization
            Pet obj = new Pet() { name = name, price = price, species = species,  breed = breed, age = age, gender = gender, stock=stock};
            XmlSerializer serObj = new XmlSerializer(typeof(Pet));
            StreamWriter write = new StreamWriter(@"C:\Users\yvese\Desktop\C#FINAL\Pet.xml");
            serObj.Serialize(write, obj);
            write.Close();
        }

        public class Pet
        {
            public string name { get; set; }
            public string price { get; set; }
            public string species { get; set; }
            public string breed { get; set; }
            public string age { get; set; }
            public string gender { get; set; }
            public string stock { get; set; }

        }


    }
}
