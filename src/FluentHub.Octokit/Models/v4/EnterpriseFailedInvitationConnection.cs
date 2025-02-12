namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// The connection type for OrganizationInvitation.
    /// </summary>
    public class EnterpriseFailedInvitationConnection
    {
        /// <summary>
        /// A list of edges.
        /// </summary>
        public List<EnterpriseFailedInvitationEdge> Edges { get; set; }

        /// <summary>
        /// A list of nodes.
        /// </summary>
        public List<OrganizationInvitation> Nodes { get; set; }

        /// <summary>
        /// Information to aid in pagination.
        /// </summary>
        public PageInfo PageInfo { get; set; }

        /// <summary>
        /// Identifies the total count of items in the connection.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Identifies the total count of unique users in the connection.
        /// </summary>
        public int TotalUniqueUserCount { get; set; }
    }
}