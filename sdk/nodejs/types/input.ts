// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";

export interface GetComponentsFilter {
    name: string;
    regex?: boolean;
    values: string[];
}

export interface GetComponentsFilterArgs {
    name: pulumi.Input<string>;
    regex?: pulumi.Input<boolean>;
    values: pulumi.Input<pulumi.Input<string>[]>;
}