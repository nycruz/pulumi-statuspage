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
    public sealed class GetComponentsComponentResult
    {
        public readonly string AutomationEmail;
        public readonly string Description;
        public readonly string GroupId;
        /// <summary>
        /// The ID of this resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly int Position;

        [OutputConstructor]
        private GetComponentsComponentResult(
            string automationEmail,

            string description,

            string groupId,

            string id,

            string name,

            int position)
        {
            AutomationEmail = automationEmail;
            Description = description;
            GroupId = groupId;
            Id = id;
            Name = name;
            Position = position;
        }
    }
}
