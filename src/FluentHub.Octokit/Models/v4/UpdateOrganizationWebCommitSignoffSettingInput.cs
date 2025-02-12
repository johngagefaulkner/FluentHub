namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdateOrganizationWebCommitSignoffSetting
    /// </summary>
    public class UpdateOrganizationWebCommitSignoffSettingInput
    {
        /// <summary>
        /// The ID of the organization on which to set the web commit signoff setting.
        /// </summary>
        public ID OrganizationId { get; set; }

        /// <summary>
        /// Enable signoff on web-based commits for repositories in the organization?
        /// </summary>
        public bool WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}