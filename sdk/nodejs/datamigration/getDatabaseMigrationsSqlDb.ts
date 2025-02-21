// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Database Migration Resource for SQL Database.
 * API Version: 2022-03-30-preview.
 */
export function getDatabaseMigrationsSqlDb(args: GetDatabaseMigrationsSqlDbArgs, opts?: pulumi.InvokeOptions): Promise<GetDatabaseMigrationsSqlDbResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:datamigration:getDatabaseMigrationsSqlDb", {
        "expand": args.expand,
        "migrationOperationId": args.migrationOperationId,
        "resourceGroupName": args.resourceGroupName,
        "sqlDbInstanceName": args.sqlDbInstanceName,
        "targetDbName": args.targetDbName,
    }, opts);
}

export interface GetDatabaseMigrationsSqlDbArgs {
    /**
     * Complete migration details be included in the response.
     */
    expand?: string;
    /**
     * Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved.
     */
    migrationOperationId?: string;
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: string;
    sqlDbInstanceName: string;
    /**
     * The name of the target database.
     */
    targetDbName: string;
}

/**
 * Database Migration Resource for SQL Database.
 */
export interface GetDatabaseMigrationsSqlDbResult {
    readonly id: string;
    readonly name: string;
    /**
     * Database Migration Resource properties for SQL database.
     */
    readonly properties: outputs.datamigration.DatabaseMigrationPropertiesSqlDbResponse;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.datamigration.SystemDataResponse;
    readonly type: string;
}

export function getDatabaseMigrationsSqlDbOutput(args: GetDatabaseMigrationsSqlDbOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDatabaseMigrationsSqlDbResult> {
    return pulumi.output(args).apply(a => getDatabaseMigrationsSqlDb(a, opts))
}

export interface GetDatabaseMigrationsSqlDbOutputArgs {
    /**
     * Complete migration details be included in the response.
     */
    expand?: pulumi.Input<string>;
    /**
     * Optional migration operation ID. If this is provided, then details of migration operation for that ID are retrieved. If not provided (default), then details related to most recent or current operation are retrieved.
     */
    migrationOperationId?: pulumi.Input<string>;
    /**
     * Name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
    sqlDbInstanceName: pulumi.Input<string>;
    /**
     * The name of the target database.
     */
    targetDbName: pulumi.Input<string>;
}
