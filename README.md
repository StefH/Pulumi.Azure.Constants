[![NuGet](https://buildstats.info/nuget/Pulumi.Azure.Constants)](https://www.nuget.org/packages/Pulumi.Azure.Constants)

# Pulumi.Azure.Constants
Additional constants for creating and configuring Microsoft Azure resources with [Pulumi Azure](https://github.com/pulumi/pulumi-azure).

## Usage

### Current
Instead of using custom strings when creating a resource:
``` c#
var storageAccount = new Account("test", new AccountArgs
{
    ResourceGroupName = resourceGroup.Name,
    AccountReplicationType = "LRS", // You need to specify the correct string here
    AccountTier = "Standard" // You need to specify the correct string here
});
```

### New
With this package, you can easily use constants:
``` c#
var storageAccount = new Account("test", new AccountArgs
{
    ResourceGroupName = resourceGroup.Name,
    AccountReplicationType = StorageAccountReplicationTypes.LocallyRedundantStorage, // You can now use a constant here
    AccountTier = StorageAccountTiers.Standard // You can now use a constant here
});
```

***

# Constants
Constants are defined for the following resources:
- AppServicePlan
- Blob
- ConfigurationStore (AppConfiguration)
- Cognitive (CognitiveServices)
- Container
- Core (ResourceGroup)
- FunctionApp
- Insights (ApplicationInsights)
- Storage