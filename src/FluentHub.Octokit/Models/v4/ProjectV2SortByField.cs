namespace FluentHub.Octokit.Models.v4
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Represents a sort by field and direction.
    /// </summary>
    public class ProjectV2SortByField
    {
        /// <summary>
        /// The direction of the sorting. Possible values are ASC and DESC.
        /// </summary>
        public OrderDirection Direction { get; set; }

        /// <summary>
        /// The field by which items are sorted.
        /// </summary>
        public ProjectV2FieldConfiguration Field { get; set; }
    }
}