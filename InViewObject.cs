﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace DynaModel
{
    public class InViewObject
    {
        public Brep brep { get; set; }
        public Guid guid { get; set; }

        public string type { get; set; }

        public InViewObject() 
        {
            brep = new Brep();
            guid = Guid.Empty;
            type = string.Empty;

        }

        public InViewObject(Brep brep, Guid guid, string type) 
        {
            this.brep = brep.DuplicateBrep();
            this.guid = guid;
            this.type = type;
        }
    }
}
