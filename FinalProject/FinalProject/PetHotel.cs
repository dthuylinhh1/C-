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
    public partial class PetHotel : Form
    {
        public PetHotel()
        {
            InitializeComponent();
        }
        string value ="";
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\yvese\source\repos\FinalProject\FinalProject\Database1.mdf;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        int selectedrowid;
        int totalPrice;
        private void PetHotel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.pethotel' table. You can move, or remove it, as needed.
            this.pethotelTableAdapter.Fill(this.database1DataSet2.pethotel);
            // TODO: This line of code loads data into the 'database1DataSet2.pethotel' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'database1DataSet1.pethotel' table. You can move, or remove it, as needed.
            

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            MonthCalendar x = new MonthCalendar();
            x.Visible = true;
        }

        

        private void Btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void Btn_reset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        

        

        public void ClearData()
        {
            NameTXT.Text = "";
            SpeciesTXT.Text = "";
            DurationTXT.Text = "";
            value = "";
            OwnerNameTXT.Text = "";
            PriceTXT.Text = "";
        }

        public void Binddata()
        {
            con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from pethotel", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        

        private void PethotelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pethotelBindingSource.EndEdit();
           

        }

        private void PethotelBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.pethotelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet2);

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int duration = int.Parse(DurationTXT.Text);
            totalPrice = 20 * duration;
            PriceTXT.Text = "$" + totalPrice.ToString();
            OnePriceTXT.Text = "$20";

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int duration = int.Parse(DurationTXT.Text);
            totalPrice = 30 * duration;
            PriceTXT.Text = "$" + totalPrice.ToString();
            OnePriceTXT.Text = "$30";

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int duration = int.Parse(DurationTXT.Text);
            totalPrice = 100 * duration;
            PriceTXT.Text = "$" + totalPrice.ToString();
            OnePriceTXT.Text = "$100";
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            int duration = int.Parse(DurationTXT.Text);
            totalPrice = 110 * duration;
            PriceTXT.Text = "$"+totalPrice.ToString();
            OnePriceTXT.Text = "$110";
        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            bool isChecked = radioButton1.Checked;
            if (isChecked)
            {
                value = radioButton1.Text;

            }
            else if (isChecked = radioButton2.Checked)
            {
                value = radioButton2.Text;

            }
            else if (isChecked = radioButton3.Checked)
            {
                value = radioButton3.Text;

            }
            else
            {
                value = radioButton4.Text;

            }
            string Query = "insert into pethotel(pet_name, pet_species, duration_of_stay, service, start_date, owner_name, price) values('" + NameTXT.Text + "','" + SpeciesTXT.Text + "', '" + DurationTXT.Text + "', '" + value + "','" + dateTimePicker1.Value + "', '" + OwnerNameTXT.Text + "','" + PriceTXT.Text + "');";
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

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void OnePriceTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_pet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBuyingPet formBuyingPet= new FormBuyingPet();
            formBuyingPet.ShowDialog();
            this.Close();
        }

        private void Btn_stuff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stuff stuff= new Stuff();
            stuff.ShowDialog();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home= new Home();
            home.ShowDialog();
            this.Close();
        }
    }
}
