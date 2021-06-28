// -----------------------------------------------------------------------
//  <copyright file="FixFor.cs"
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
    public sealed partial class FixFor
    {
        /// <summary>
        ///   Gets the project.
        /// </summary>
        public Project Project
        {
            get { return IndexProject.HasValue ? FogBugzClient.GetProject(IndexProject.Value) : null; }
        }
    }
}
