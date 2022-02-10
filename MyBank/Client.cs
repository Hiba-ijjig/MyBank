using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public  class Client
    {
        public int id;
        public string Fname;
        public string Lname;
        public string login;
        public string mdp;
        public List<Compte> lst_compte { get; set; }
        /******** constructeur*********/
        public Client(int id_n,string fn, string ln,string pwd)
        {
            id =id_n;
            Fname = fn;
            Lname = ln;
            login = Fname+"."+Lname+"@mybank";
            mdp = pwd;
            lst_compte = new List<Compte>();
        }
        /********* ajouter un compte **********/
        public void Add_compte(Compte c)
        {
            this.lst_compte.Add(c);
        }
    }
}
