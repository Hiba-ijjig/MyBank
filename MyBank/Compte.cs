using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class Compte
    {
        public int id { get; }
        public double solde { get; set; }
        static double plafond=2000;
        public List<Operation> lst_op;
        /************ constructeur ************/
        public Compte(int id_c,double s)
        {
            id = id_c;
            solde = s;
            lst_op = new List<Operation>();
        }
        /***********Créditer******************/
        public void crediter(double m)
        {
            this.solde = this.solde + m;
            
        }

        /********************* debiter **********************/
        public bool debiter(double M)
        {
            if (this.solde >= M && M <= plafond)
            {
                this.solde = this.solde - M;
                return true;
            }
            return false;
        }
        /****************** verser ******************/
        public bool verser(double M, Compte C)
        {
            if (this.debiter(M) == true)
            {
                C.crediter(M);
                return true;
            }
            return false;
        }


    }
}
