﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    public class FastShiping : TemplateMethod
    {
        public override decimal ApplyShiping(decimal total)
        {
            return total + 20;
        }
    }
}
