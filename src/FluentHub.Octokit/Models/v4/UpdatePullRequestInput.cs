namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of UpdatePullRequest
    /// </summary>
    public class UpdatePullRequestInput
    {        /// <summary>
        /// The Node ID of the pull request.
        /// </summary>
        public ID PullRequestId { get; set; }

        /// <summary>
        /// The name of the branch you want your changes pulled into. This should be an existing branch
        /// on the current repository.
        /// </summary>
        public string BaseRefName { get; set; }

        /// <summary>
        /// The title of the pull request.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The contents of the pull request.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The target state of the pull request.
        /// </summary>
        public PullRequestUpdateState? State { get; set; }

        /// <summary>
        /// Indicates whether maintainers can modify the pull request.
        /// </summary>
        public bool? MaintainerCanModify { get; set; }

        /// <summary>
        /// An array of Node IDs of users for this pull request.
        /// </summary>
        public List<ID> AssigneeIds { get; set; }

        /// <summary>
        /// The Node ID of the milestone for this pull request.
        /// </summary>
        public ID? MilestoneId { get; set; }

        /// <summary>
        /// An array of Node IDs of labels for this pull request.
        /// </summary>
        public List<ID> LabelIds { get; set; }

        /// <summary>
        /// An array of Node IDs for projects associated with this pull request.
        /// </summary>
        public List<ID> ProjectIds { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}