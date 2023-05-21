﻿using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace GHClippingPlane
{
    public class GHClippingPlaneInfo : GH_AssemblyInfo
    {
        public override string Name => "GHClippingPlane";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("B4A63472-8379-4DE1-B0AD-D34B785262F1");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}