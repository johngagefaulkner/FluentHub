namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of StartOrganizationMigration
    /// </summary>
    public class StartOrganizationMigrationPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The new organization migration.
        /// </summary>
        public OrganizationMigration OrgMigration { get; set; }
    }
}