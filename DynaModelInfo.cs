using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace DynaModel
{
    public class DynaModelInfo : GH_AssemblyInfo
    {
        public override string Name => "DynaModel";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("c2264575-9ac4-4264-97d9-64ede1cd616d");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}