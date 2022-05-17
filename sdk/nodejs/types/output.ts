// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";

export interface GetComponentsComponent {
    automationEmail: string;
    description: string;
    groupId: string;
    /**
     * The ID of this resource.
     */
    id: string;
    name: string;
    position: number;
}

export interface GetComponentsFilter {
    name: string;
    regex?: boolean;
    values: string[];
}

