// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Statuspage.Outputs
{

    [OutputType]
    public sealed class GetComponentGroupsComponentGroupResult
    {
        public readonly ImmutableArray<string> Components;
        public readonly string Description;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly int Position;

        [OutputConstructor]
        private GetComponentGroupsComponentGroupResult(
            ImmutableArray<string> components,

            string description,

            string id,

            string name,

            int position)
        {
            Components = components;
            Description = description;
            Id = id;
            Name = name;
            Position = position;
        }
    }
}
