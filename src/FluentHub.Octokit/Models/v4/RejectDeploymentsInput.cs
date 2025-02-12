namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Autogenerated input type of RejectDeployments
    /// </summary>
    public class RejectDeploymentsInput
    {
        /// <summary>
        /// The node ID of the workflow run containing the pending deployments.
        /// </summary>
        public ID WorkflowRunId { get; set; }

        /// <summary>
        /// The ids of environments to reject deployments
        /// </summary>
        public List<ID> EnvironmentIds { get; set; }

        /// <summary>
        /// Optional comment for rejecting deployments
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// A unique identifier for the client performing the mutation.
        /// </summary>
        public string ClientMutationId { get; set; }
    }
}