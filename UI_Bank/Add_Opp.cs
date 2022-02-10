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
using MyBank;
namespace UI_Bank
{
    public partial class Add_Opp : Form
    {
        Client client;
        public Add_Opp(Client c)
        {
            this.client = c;
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lst_cpt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < this.client.lst_compte.Count; i++)
            {
                lst_cpt.Items.Add(this.client.lst_compte[i].id);
            }
            add_somme.Visible = true;
        }
        private int position_cpt(int id_c)
        {
            int ind=-1;
            for (int i = 0; i < this.client.lst_compte.Count; i++)
            {
                if (this.client.lst_compte[i].id==id_c) ind=i;
            }
            return ind;
        }

        private void valider_Click(object sender, EventArgs e)
        {
            if (lst_cpt.Text.Length != 0 && montant.Text.Length != 0)
            {
                int ind = this.position_cpt(int.Parse(lst_cpt.Text));
                this.client.lst_compte[ind].crediter(double.Parse(montant.Text));
                
                this.updateSolde(this.client.lst_compte[ind].solde, int.Parse(lst_cpt.Text));
                this.Close();
                EspaceClient.change(client);
            }
            else
                MessageBox.Show("vous devez remplir tous les champs");
        }

        private void updateSolde(double solde,int id_cpt)
        {
            
                SqlConnection c;
            String connString;
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyBank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            c = new SqlConnection(connString);
            c.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            string r = "UPDATE Compte SET solde="+ solde+"WHERE Id="+id_cpt+"";
            SqlCommand commande2 = new SqlCommand(r, c);
            adapter.UpdateCommand = commande2;
            adapter.UpdateCommand.ExecuteNonQuery();
            commande2.Dispose();
            c.Close();
            MessageBox.Show("Votre opération est bien efféctuée");
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void verser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            for (int i = 0; i < this.client.lst_compte.Count; i++)
            {
                mycpt.Items.Add(this.client.lst_compte[i].id);
            }
            SqlConnection conn;
            String connString;
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyBank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connString);
            conn.Open();
            string r0 = "select Id from Compte";
            SqlCommand commande = new SqlCommand(r0, conn);
            SqlDataReader reader = commande.ExecuteReader();
           while(reader.Read())
            {
                hiscpt.Items.Add(reader["Id"]);
            }
            conn.Close();
            vers.Visible = true;
        }

        private void ok_Click(object sender, EventArgs e)
        {
        if (mycpt.Text.Length != 0 && hiscpt.Text.Length != 0 && m_op.Text.Length != 0)
        {
            int ind = this.position_cpt(int.Parse(mycpt.Text));
            int id_des = int.Parse(hiscpt.Text);
            Compte des = chercher_client_bdd(id_des);
            if (des != null)
            {
                Boolean v = this.client.lst_compte[ind].verser(double.Parse(m_op.Text), des);
                    if (v) {
                        updateSolde(this.client.lst_compte[ind].solde, this.client.lst_compte[ind].id);
                        updateSolde(des.solde, des.id);
                    }
                    else MessageBox.Show("montant invalide");
            }
            else MessageBox.Show("destinataire invalide");
        }
        else
                MessageBox.Show("vous devez remplir tous les champs");
            this.Close();
            EspaceClient.change(client);
        }
        private Compte chercher_client_bdd(int id_c)
        {
            Compte c = null;
            SqlConnection conn;
            String connString;
            connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyBank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connString);
            conn.Open();
            string r0 = "select * from Compte where Id="+id_c+" ";
            SqlCommand commande = new SqlCommand(r0, conn);
            SqlDataReader reader = commande.ExecuteReader();
            if (reader.Read()) c = new Compte(int.Parse(reader["Id"].ToString()), double.Parse(reader["solde"].ToString()));

            conn.Close();
            return c;
        }

        private void Add_Opp_Load(object sender, EventArgs e)
        {
            nom.Text = client.Fname + " " + client.Lname;
        }
    }
}

