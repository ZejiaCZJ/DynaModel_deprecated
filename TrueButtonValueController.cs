﻿using System;
using System.Collections.Generic;
using System.Threading;
using Grasshopper.Kernel;
using Rhino.Geometry;

namespace DynaModel
{
    public class TrueButtonValueController : GH_Component
    {
        public static int finished = 1; //0 = false, 1 = true, 2 = in progress

        /// <summary>
        /// Initializes a new instance of the TrueButtonValueController class.
        /// </summary>
        public TrueButtonValueController()
          : base("TrueButtonValueController", "TBVC",
              "This component control the true button value",
              "DynaModel", "UI")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddBooleanParameter("True Button Value", "TB value", "The true button value", GH_ParamAccess.item, false);
            //pManager.AddTextParameter("Windows Status", "S", "The status of the windows", GH_ParamAccess.item, "Hidden");
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddBooleanParameter("Start Button", "B", "The start button value", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            bool buttonClicked = false;
            if (!DA.GetData(0, ref buttonClicked))
                return;


            if (buttonClicked)
                DA.SetData(0, true);
            else
                DA.SetData(0, false);
        }

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon
        {
            get
            {
                //You can add image files to your project resources and access them like this:
                // return Resources.IconForThisComponent;
                return null;
            }
        }

        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid
        {
            get { return new Guid("DAACC50E-6542-43AD-BA39-571178F5C13C"); }
        }
    }
}