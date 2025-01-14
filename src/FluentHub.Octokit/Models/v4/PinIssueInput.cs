namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of PinIssue
    /// </summary>
    public class PinIssueInput
    {
        /// <summary>
        /// The ID of the issue to be pinned
        /// </summary>
        public ID IssueId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}