using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBank;
namespace UI_Bank
{
    public partial class EspaceClient : Form
    {
        Client c;
        static EspaceClient ec=null;
        private EspaceClient(Client cl)
        {
            c = cl;
            InitializeComponent();
        }
        public static EspaceClient creerEspaceClient(Client cl)
        {
            if (ec == null) ec = new EspaceClient(cl);
            return ec;
        }

        private void EspaceClient_Load(object sender, EventArgs e)
        {
            Cname.Text = c.Fname +" "+ c.Lname;
            MesComptes.AutoSize = false;
            MesComptes.DataSource = c.lst_compte;
            

        }
        static public void change(Client c)
        {
            ec.Close();
            ec = null;
            ec = creerEspaceClient(c);
            ec.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            ec = null;
            
            Auth a = Auth.creer_auth();
            a.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Add = new AddCompte(c);
            Add.Show();
            
        }

        private void MesComptes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Add = new Add_Opp(c);
            Add.Show();
        }

        private void Cname_Click(object sender, EventArgs e)
        {

        }
    }
}
