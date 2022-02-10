using MyBank;
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

namespace UI_Bank
{
    public partial class AddCompte : Form
    {
        Client client;
        public AddCompte(Client c)
        {
            client = c;
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void valider_Click(object sender, EventArgs e)
        {
            if (solde.Text.Length == 0 )
            {
                MessageBox.Show("vous devez donner le solde initial");
            }
            else
            {
                /***************chaine de connection******************/
                SqlConnection c;
                String connString;
                connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyBank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                c = new SqlConnection(connString);
                c.Open();
                /********selection de l'id pour eviter la répitition *****************/
                string r0 = "select max(id) as max from Compte ";
                SqlCommand commande = new SqlCommand(r0, c);
                SqlDataReader reader = commande.ExecuteReader();
                int id = 1;
                if (reader.Read()) id = int.Parse(reader["max"].ToString()) + 1;
                //creation d'un nouveau client
                Compte compte= new Compte(id, double.Parse(solde.Text));
                client.Add_compte(compte);
                commande.Dispose();
                reader.Close();
                //insertion
                SqlDataAdapter adapter = new SqlDataAdapter();
                string r = "insert into Compte ( id, id_client , solde ) values (" + compte.id + "," + client.id + "," + compte.solde + ")";
                SqlCommand commande2 = new SqlCommand(r, c);
                adapter.InsertCommand = commande2;
                adapter.InsertCommand.ExecuteNonQuery();
                commande2.Dispose();
                c.Close();
                MessageBox.Show("Votre compte a été bien cru");
                this.Close();
                EspaceClient.change(client);
            }
        }
    }
}
