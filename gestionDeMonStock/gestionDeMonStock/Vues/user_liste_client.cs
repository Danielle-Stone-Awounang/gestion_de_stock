using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDeMonStock.Vues
{
    public partial class user_liste_client : UserControl
    {
        private static user_liste_client userClient;
        public static user_liste_client instance
        {
            get
            {
                if(userClient == null)
                {
                    userClient = new user_liste_client();
                }
                return userClient;
            }
        }
        public user_liste_client()
        {
            InitializeComponent();
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
               
        }

        private void txt_recherche_Enter(object sender, EventArgs e)
        {
            if(txt_recherche.Text == "Rechercher")
            {
                txt_recherche.Text = "";
                txt_recherche.ForeColor = Color.Black;
            }
        }

        private void txt_recherche_Leave(object sender, EventArgs e)
        {
            if(txt_recherche.Text == "")
            {
                txt_recherche.Text = "Rechercher";
                txt_recherche.ForeColor= Color.Silver;
            }
        }

        private void user_liste_client_Load(object sender, EventArgs e)
        {
            dgv_client.Rows.Add();
            dgv_client.Rows[0].Cells[1].Value = "awounang";
            dgv_client.Rows[0].Cells[2].Value = "danielle";
            dgv_client.Rows[0].Cells[3].Value = "stone@gmail.com";

        }
    }
}
