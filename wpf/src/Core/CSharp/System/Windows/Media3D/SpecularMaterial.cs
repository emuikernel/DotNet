//---------------------------------------------------------------------------
//
// <copyright file="SpecularMaterial.cs" company="Microsoft">
//    Copyright (C) Microsoft Corporation.  All rights reserved.
// </copyright>
//
//
// Description: 3D specular material
//
//              See spec at *** FILL IN LATER ***
//
//---------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Composition;
using MS.Internal;

namespace System.Windows.Media.Media3D
{
    /// <summary>
    ///     SpecularMaterial allows a 2d brush to be used on a 3d model that has been lit
    ///     with a specular lighting model
    /// </summary>
    public sealed partial class SpecularMaterial : Material
    {
        //------------------------------------------------------
        //
        //  Constructors
        //
        //------------------------------------------------------

        #region Constructors

        /// <summary>
        ///     Constructs a SpecularMaterial
        /// </summary>
        public SpecularMaterial()
        {

        }

        /// <summary>
        ///     Constructor that sets the initial values
        /// </summary>
        /// <param name="brush">The new material's brush</param>
        /// <param name="specularPower">The specular exponent.</param>
        public SpecularMaterial(Brush brush, double specularPower)
        {
            Brush = brush;
            SpecularPower = specularPower;
        }

        #endregion Constructors

    }
}
