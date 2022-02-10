using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    abstract public class Operation
    {
        int id;
        string description;
        double montant;
        Compte compte;
        public Operation(int idb,string d, Compte c,double m)
        {
            id = idb;
            description = d;
            compte = c;
            montant = m;
        }
    }
}
