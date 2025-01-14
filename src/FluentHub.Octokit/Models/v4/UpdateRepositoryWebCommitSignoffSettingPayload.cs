namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Autogenerated return type of UpdateRepositoryWebCommitSignoffSetting
    /// </summary>
    public class UpdateRepositoryWebCommitSignoffSettingPayload
    {
        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }

        /// <summary>
        /// A message confirming the result of updating the web commit signoff setting.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The updated repository.
        /// </summary>
        public Repository Repository { get; set; }
    }
}