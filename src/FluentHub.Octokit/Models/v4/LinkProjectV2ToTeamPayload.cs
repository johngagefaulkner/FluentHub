namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of LinkProjectV2ToTeam
    /// </summary>
    public class LinkProjectV2ToTeamPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The team the project is linked to
        /// </summary>
        public Team Team { get; set; }
    }
}