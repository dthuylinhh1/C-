using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public Home(bool isBoss=false)
        {
            InitializeComponent();
                btn_BOSSPET.Visible = isBoss;
                btn_BOSSSTUFF.Visible = isBoss;
                btn_only.Visible = false;
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

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
            PetHotel petHotel = new PetHotel();
            petHotel.ShowDialog();
            this.Close();
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
            Login login = new Login();
            login.ShowDialog();
            this.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            BOSS_PET boss_pet = new BOSS_PET();
            boss_pet.ShowDialog();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void Btn_BOSSSTUFF_Click(object sender, EventArgs e)
        {
            this.Hide();
            BOSS_STUFF boss_stuff = new BOSS_STUFF();
            boss_stuff.ShowDialog();
            this.Close();
        }
    }
}
