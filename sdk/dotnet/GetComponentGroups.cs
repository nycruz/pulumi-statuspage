// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Statuspage
{
    public static class GetComponentGroups
    {
        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Statuspage = Pulumi.Statuspage;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @default = Output.Create(Statuspage.GetComponentGroups.InvokeAsync(new Statuspage.GetComponentGroupsArgs
        ///         {
        ///             PageId = local.Page_id,
        ///             Filters = 
        ///             {
        ///                 new Statuspage.Inputs.GetComponentGroupsFilterArgs
        ///                 {
        ///                     Name = "name",
        ///                     Values = 
        ///                     {
        ///                         "value_1",
        ///                         "value_2",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetComponentGroupsResult> InvokeAsync(GetComponentGroupsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetComponentGroupsResult>("statuspage:index/getComponentGroups:getComponentGroups", args ?? new GetComponentGroupsArgs(), options.WithDefaults());

        /// <summary>
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Statuspage = Pulumi.Statuspage;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var @default = Output.Create(Statuspage.GetComponentGroups.InvokeAsync(new Statuspage.GetComponentGroupsArgs
        ///         {
        ///             PageId = local.Page_id,
        ///             Filters = 
        ///             {
        ///                 new Statuspage.Inputs.GetComponentGroupsFilterArgs
        ///                 {
        ///                     Name = "name",
        ///                     Values = 
        ///                     {
        ///                         "value_1",
        ///                         "value_2",
        ///                     },
        ///                 },
        ///             },
        ///         }));
        ///     }
        /// 
        /// }
        /// ```
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Output<GetComponentGroupsResult> Invoke(GetComponentGroupsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetComponentGroupsResult>("statuspage:index/getComponentGroups:getComponentGroups", args ?? new GetComponentGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetComponentGroupsArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetComponentGroupsFilterArgs>? _filters;
        public List<Inputs.GetComponentGroupsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetComponentGroupsFilterArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// the ID of the page this component belongs to
        /// </summary>
        [Input("pageId", required: true)]
        public string PageId { get; set; } = null!;

        public GetComponentGroupsArgs()
        {
        }
    }

    public sealed class GetComponentGroupsInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetComponentGroupsFilterInputArgs>? _filters;
        public InputList<Inputs.GetComponentGroupsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetComponentGroupsFilterInputArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// the ID of the page this component belongs to
        /// </summary>
        [Input("pageId", required: true)]
        public Input<string> PageId { get; set; } = null!;

        public GetComponentGroupsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetComponentGroupsResult
    {
        public readonly ImmutableArray<Outputs.GetComponentGroupsComponentGroupResult> ComponentGroups;
        public readonly ImmutableArray<Outputs.GetComponentGroupsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// the ID of the page this component belongs to
        /// </summary>
        public readonly string PageId;

        [OutputConstructor]
        private GetComponentGroupsResult(
            ImmutableArray<Outputs.GetComponentGroupsComponentGroupResult> componentGroups,

            ImmutableArray<Outputs.GetComponentGroupsFilterResult> filters,

            string id,

            string pageId)
        {
            ComponentGroups = componentGroups;
            Filters = filters;
            Id = id;
            PageId = pageId;
        }
    }
}
