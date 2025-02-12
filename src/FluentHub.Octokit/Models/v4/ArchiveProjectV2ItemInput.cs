namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of ArchiveProjectV2Item
    /// </summary>
    public class ArchiveProjectV2ItemInput
    {
        /// <summary>
        /// The ID of the Project to archive the item from.
        /// </summary>
        public ID ProjectId { get; set; }

        /// <summary>
        /// The ID of the ProjectV2Item to archive.
        /// </summary>
        public ID ItemId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}