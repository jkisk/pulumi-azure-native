// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const BackupPolicyType = {
    Periodic: "Periodic",
    Continuous: "Continuous",
} as const;

/**
 * Describes the mode of backups.
 */
export type BackupPolicyType = (typeof BackupPolicyType)[keyof typeof BackupPolicyType];

export const CompositePathSortOrder = {
    Ascending: "ascending",
    Descending: "descending",
} as const;

/**
 * Sort order for composite paths.
 */
export type CompositePathSortOrder = (typeof CompositePathSortOrder)[keyof typeof CompositePathSortOrder];

export const ConflictResolutionMode = {
    LastWriterWins: "LastWriterWins",
    Custom: "Custom",
} as const;

/**
 * Indicates the conflict resolution mode.
 */
export type ConflictResolutionMode = (typeof ConflictResolutionMode)[keyof typeof ConflictResolutionMode];

export const ConnectorOffer = {
    Small: "Small",
} as const;

/**
 * The cassandra connector offer type for the Cosmos DB database C* account.
 */
export type ConnectorOffer = (typeof ConnectorOffer)[keyof typeof ConnectorOffer];

export const DataType = {
    String: "String",
    Number: "Number",
    Point: "Point",
    Polygon: "Polygon",
    LineString: "LineString",
    MultiPolygon: "MultiPolygon",
} as const;

/**
 * The datatype for which the indexing behavior is applied to.
 */
export type DataType = (typeof DataType)[keyof typeof DataType];

export const DatabaseAccountKind = {
    GlobalDocumentDB: "GlobalDocumentDB",
    MongoDB: "MongoDB",
    Parse: "Parse",
} as const;

/**
 * Indicates the type of database account. This can only be set at database account creation.
 */
export type DatabaseAccountKind = (typeof DatabaseAccountKind)[keyof typeof DatabaseAccountKind];

export const DatabaseAccountOfferType = {
    Standard: "Standard",
} as const;

/**
 * The offer type for the database
 */
export type DatabaseAccountOfferType = (typeof DatabaseAccountOfferType)[keyof typeof DatabaseAccountOfferType];

export const DefaultConsistencyLevel = {
    Eventual: "Eventual",
    Session: "Session",
    BoundedStaleness: "BoundedStaleness",
    Strong: "Strong",
    ConsistentPrefix: "ConsistentPrefix",
} as const;

/**
 * The default consistency level and configuration settings of the Cosmos DB account.
 */
export type DefaultConsistencyLevel = (typeof DefaultConsistencyLevel)[keyof typeof DefaultConsistencyLevel];

export const IndexKind = {
    Hash: "Hash",
    Range: "Range",
    Spatial: "Spatial",
} as const;

/**
 * Indicates the type of index.
 */
export type IndexKind = (typeof IndexKind)[keyof typeof IndexKind];

export const IndexingMode = {
    Consistent: "consistent",
    Lazy: "lazy",
    None: "none",
} as const;

/**
 * Indicates the indexing mode.
 */
export type IndexingMode = (typeof IndexingMode)[keyof typeof IndexingMode];

export const NetworkAclBypass = {
    None: "None",
    AzureServices: "AzureServices",
} as const;

/**
 * Indicates what services are allowed to bypass firewall checks.
 */
export type NetworkAclBypass = (typeof NetworkAclBypass)[keyof typeof NetworkAclBypass];

export const PartitionKind = {
    Hash: "Hash",
    Range: "Range",
    MultiHash: "MultiHash",
} as const;

/**
 * Indicates the kind of algorithm used for partitioning. For MultiHash, multiple partition keys (upto three maximum) are supported for container create
 */
export type PartitionKind = (typeof PartitionKind)[keyof typeof PartitionKind];

export const PublicNetworkAccess = {
    Enabled: "Enabled",
    Disabled: "Disabled",
} as const;

/**
 * Whether requests from Public Network are allowed
 */
export type PublicNetworkAccess = (typeof PublicNetworkAccess)[keyof typeof PublicNetworkAccess];

export const ResourceIdentityType = {
    SystemAssigned: "SystemAssigned",
    UserAssigned: "UserAssigned",
    SystemAssigned_UserAssigned: "SystemAssigned,UserAssigned",
    None: "None",
} as const;

/**
 * The type of identity used for the resource. The type 'SystemAssigned,UserAssigned' includes both an implicitly created identity and a set of user assigned identities. The type 'None' will remove any identities from the service.
 */
export type ResourceIdentityType = (typeof ResourceIdentityType)[keyof typeof ResourceIdentityType];

export const RoleDefinitionType = {
    BuiltInRole: "BuiltInRole",
    CustomRole: "CustomRole",
} as const;

/**
 * Indicates whether the Role Definition was built-in or user created.
 */
export type RoleDefinitionType = (typeof RoleDefinitionType)[keyof typeof RoleDefinitionType];

export const ServerVersion = {
    ServerVersion_3_2: "3.2",
    ServerVersion_3_6: "3.6",
    ServerVersion_4_0: "4.0",
} as const;

/**
 * Describes the ServerVersion of an a MongoDB account.
 */
export type ServerVersion = (typeof ServerVersion)[keyof typeof ServerVersion];

export const SpatialType = {
    Point: "Point",
    LineString: "LineString",
    Polygon: "Polygon",
    MultiPolygon: "MultiPolygon",
} as const;

/**
 * Indicates the spatial type of index.
 */
export type SpatialType = (typeof SpatialType)[keyof typeof SpatialType];

export const TriggerOperation = {
    All: "All",
    Create: "Create",
    Update: "Update",
    Delete: "Delete",
    Replace: "Replace",
} as const;

/**
 * The operation the trigger is associated with
 */
export type TriggerOperation = (typeof TriggerOperation)[keyof typeof TriggerOperation];

export const TriggerType = {
    Pre: "Pre",
    Post: "Post",
} as const;

/**
 * Type of the Trigger
 */
export type TriggerType = (typeof TriggerType)[keyof typeof TriggerType];
