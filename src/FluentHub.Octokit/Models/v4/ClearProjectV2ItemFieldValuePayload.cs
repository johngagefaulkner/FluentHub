namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of ClearProjectV2ItemFieldValue
    /// </summary>
    public class ClearProjectV2ItemFieldValuePayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The updated item.
        /// </summary>
        public ProjectV2Item ProjectV2Item { get; set; }
    }
}