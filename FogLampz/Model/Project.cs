// -----------------------------------------------------------------------
//  <copyright file="Project.cs"
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
    public sealed partial class Project
    {
        /// <summary>
        ///   Gets the owner.
        /// </summary>
        public Person Owner
        {
            get { return IndexOwner.HasValue ? FogBugzClient.GetPerson(IndexOwner.Value) : null; }
        }
    }
}
