using MyBank;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace UI_Bank
{
    public partial class Auth : Form
    {
        static Auth AT=null;

        private Auth()
        {
            InitializeComponent();
        }
        public static Auth creer_auth()
        {
            if (AT == null) AT = new Auth();
            return AT;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void firstPage_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void creer_Click(object sender, EventArgs e)
        {
            if (pwd.Text.Length == 0 || ln.Text.Length == 0 || fn.Text.Length == 0)
            {
                MessageBox.Show("vous devez remplir tous les champs");
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
                string r0= "select max(id) as max from Client ";
                SqlCommand commande= new SqlCommand(r0, c);
                SqlDataReader reader= commande.ExecuteReader();
                int id=1;
                if (reader.Read()) id = int.Parse(reader["max"].ToString())+1;
                //creation d'un nouveau client
                Client client = new Client(id, fn.Text, ln.Text, pwd.Text);
                commande.Dispose();
                reader.Close();
                //insertion
                SqlDataAdapter adapter = new SqlDataAdapter();
                string r = "insert into Client ( Id, Fname , Lname , login , mdp ) values (" + client.id + ",'" + client.Fname + "','" + client.Lname + "','" + client.login + "','" + client.mdp + "')";
                SqlCommand commande2 = new SqlCommand(r, c);
                adapter.InsertCommand = commande2;
                adapter.InsertCommand.ExecuteNonQuery();
                commande2.Dispose();
                c.Close();
                MessageBox.Show("Votre profil a été bien cru, connecter vous pour créer votre compte");
            }
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            if (mdp.Text.Length == 0 || login.Text.Length == 0)
            {
                MessageBox.Show("vous devez remplir tous les champs");
            }
            else
            {
                
                SqlConnection c;
                String connString;
                connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyBank;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                c = new SqlConnection(connString);
                c.Open();
                SqlCommand commande;
                SqlDataReader reader;
                string qr = "select * from Client where login='"+login.Text + "'";
                commande = new SqlCommand(qr, c);
                reader = commande.ExecuteReader();
                
                if (reader.Read())
                {
                    if (reader["mdp"].ToString() == mdp.Text)
                    {
                        Client client;
                        client = new Client(int.Parse(reader["id"].ToString()), reader["Fname"].ToString(), reader["Lname"].ToString(), reader["mdp"].ToString());
                        reader.Close();
                        commande.Dispose();
                        //ajouter à ce clients ses comptes
                        string rq = "select * from Compte where id_client=" + client.id + "";
                        commande = new SqlCommand(rq, c);
                        reader = commande.ExecuteReader();
                        while(reader.Read())
                        {
                            Compte cpt = new Compte(int.Parse(reader["id"].ToString()), double.Parse(reader["solde"].ToString()));
                            client.Add_compte(cpt);
                        }
                        EspaceClient ec = EspaceClient.creerEspaceClient(client);
                        ec.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("mdp incorrect");
                }
                else MessageBox.Show("Ce compte n'existe pas");
            }

        }

        private void creation_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
