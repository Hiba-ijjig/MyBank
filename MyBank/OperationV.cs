﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class OperationV:  Operation
    {
        public OperationV(int id,string d, Compte c, double m): base(id,d, c, m)
        {
            
        }
    }
}
