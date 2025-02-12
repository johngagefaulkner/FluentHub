namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of CreateRepository
    /// </summary>
    public class CreateRepositoryInput
    {
        /// <summary>
        /// The name of the new repository.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The ID of the owner for the new repository.
        /// </summary>
        public ID? OwnerId { get; set; }

        /// <summary>
        /// A short description of the new repository.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indicates the repository's visibility level.
        /// </summary>
        public RepositoryVisibility Visibility { get; set; }

        /// <summary>
        /// Whether this repository should be marked as a template such that anyone who can access it can create new repositories with the same files and directory structure.
        /// </summary>
        public bool? Template { get; set; }

        /// <summary>
        /// The URL for a web page about this repository.
        /// </summary>
        public string HomepageUrl { get; set; }

        /// <summary>
        /// Indicates if the repository should have the wiki feature enabled.
        /// </summary>
        public bool? HasWikiEnabled { get; set; }

        /// <summary>
        /// Indicates if the repository should have the issues feature enabled.
        /// </summary>
        public bool? HasIssuesEnabled { get; set; }

        /// <summary>
        /// When an organization is specified as the owner, this ID identifies the team that should be granted access to the new repository.
        /// </summary>
        public ID? TeamId { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}