using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Geometry;

namespace DynaModel.PipeCreation
{
    public class PipeExit
    {
        public Point3d location { get; set; }
        public Boolean isTaken { get; set; }

        public PipeExit(Point3d location)
        {
            this.location = location;
            this.isTaken = false;
        }
    }
}
