// -----------------------------------------------------------------------
//  <copyright file="Filter.cs"
//             project="FogLampz"
//             assembly="FogLampz"
//             solution="FogLampz"
//             company="Ris Adams">
//      Copyright (c) 1996+. All rights reserved.
//  </copyright>
//  <author id="foglampz@risadams.com">Ris Adams</author>
//  <summary></summary>
// -----------------------------------------------------------------------

#region References

using System;

#endregion

namespace FogLampz.Model
{
    public sealed partial class Filter
    {
        /// <summary>
        ///   Gets the type of the filter.
        /// </summary>
        /// <value> The type of the filter. </value>
        public FilterType FilterType
        {
            get { return (FilterType)Enum.Parse(typeof(FilterType), FilterTypeName); }
        }
    }
}
