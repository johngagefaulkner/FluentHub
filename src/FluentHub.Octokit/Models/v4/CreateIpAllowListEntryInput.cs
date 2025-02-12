namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateIpAllowListEntry
    /// </summary>
    public class CreateIpAllowListEntryInput
    {
        /// <summary>
        /// The ID of the owner for which to create the new IP allow list entry.
        /// </summary>
        public ID OwnerId { get; set; }

        /// <summary>
        /// An IP address or range of addresses in CIDR notation.
        /// </summary>
        public string AllowListValue { get; set; }

        /// <summary>
        /// An optional name for the IP allow list entry.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Whether the IP allow list entry is active when an IP allow list is enabled.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}