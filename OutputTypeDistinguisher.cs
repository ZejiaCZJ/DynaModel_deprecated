using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Grasshopper.Kernel;
using Rhino.Geometry;

namespace DynaModel
{
    public class OutputTypeDistinguisher : GH_Component
    {
        /// <summary>
        /// Initializes a new instance of the OutputTypeDistinguisher class.
        /// </summary>
        public OutputTypeDistinguisher()
          : base("OutputTypeDistinguisher", "Output",
              "This component distinguishes the output type and assign the corresponding function to modify the model and the UI window",
              "DynaModel", "UI")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_Component.GH_InputParamManager pManager)
        {
            pManager.AddBooleanParameter("Start Button", "SB", "The button if user want to create a parameter", GH_ParamAccess.item);
            pManager.AddGenericParameter("Output Type", "Output", "The output of the parameter", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_Component.GH_OutputParamManager pManager)
        {
            pManager.AddGenericParameter("Output Type", "Output", "The output of the parameter", GH_ParamAccess.item);
            pManager.AddBooleanParameter("LED Light", "Light", "Show elements for light", GH_ParamAccess.item);
            pManager.AddBooleanParameter("Rotational motion", "rotation", "Show elements for rotational motion", GH_ParamAccess.item);
            pManager.AddBooleanParameter("Translational motion", "translation", "Show elements for translational motion", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="DA">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess DA)
        {
            bool startButtonClicked = false;
            string outputType = "NA";

            if (!DA.GetData(0, ref startButtonClicked))
                return;
            if (!DA.GetData(1, ref outputType))
                return;

            if(startButtonClicked && outputType.Equals("LED Light"))
            {
                DA.SetData(0, outputType);
                DA.SetData(1, true);
                DA.SetData(2, false);
                DA.SetData(3, false);
            }
            else if (startButtonClicked && outputType.Equals("Vibration"))
            {
                DA.SetData(0, outputType);
                DA.SetData(1, false);
                DA.SetData(2, false);
                DA.SetData(3, true);
            }
            else if (startButtonClicked && outputType.Equals("Rotational Motion"))
            {
                DA.SetData(0, outputType);
                DA.SetData(1, false);
                DA.SetData(2, true);
                DA.SetData(3, false);
            }
            else if (startButtonClicked && outputType.Equals("Translational Motion"))
            {
                DA.SetData(0, outputType);
                DA.SetData(1, false);
                DA.SetData(2, true);
                DA.SetData(3, false);
            }


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
            get { return new Guid("6B5212ED-70EC-4462-A3A0-0588A30BBDC3"); }
        }
    }
}