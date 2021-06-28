// -----------------------------------------------------------------------
//  <copyright file="Area.cs"
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
    public sealed partial class Area
    {
        /// <summary>
        ///   Gets the project.
        /// </summary>
        public Project Project
        {
            get { return IndexProject.HasValue ? FogBugzClient.GetProject(IndexProject.Value) : null; }
        }

        /// <summary>
        ///   Gets the owner.
        /// </summary>
        public Person Owner
        {
            get { return IndexPersonOwner.HasValue ? FogBugzClient.GetPerson(IndexPersonOwner.Value) : null; }
        }
    }
}
