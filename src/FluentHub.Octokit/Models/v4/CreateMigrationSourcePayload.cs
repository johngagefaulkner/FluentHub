namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of CreateMigrationSource
    /// </summary>
    public class CreateMigrationSourcePayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// The created migration source.
        /// </summary>
        public MigrationSource MigrationSource { get; set; }
    }
}