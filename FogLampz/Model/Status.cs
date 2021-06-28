// -----------------------------------------------------------------------
//  <copyright file="Status.cs"
//             project="FogLampz"
//             assembly="FogLampz"
//             solution="FogLampz"
//             company="Ris Adams">
//      Copyright (c) 1996+. All rights reserved.
//  </copyright>
//  <author id="foglampz@risadams.com">Ris Adams</author>
//  <summary></summary>
// -----------------------------------------------------------------------

namespace FogLampz.Model
{
    public sealed partial class Status
    {
        /// <summary>
        ///   Gets the category.
        /// </summary>
        public Category Category
        {
            get { return IndexCategory.HasValue ? FogBugzClient.GetCategory(IndexCategory.Value) : null; }
        }
    }
}
