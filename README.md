[![NuGet](https://buildstats.info/nuget/Pulumi.Azure.Constants)](https://www.nuget.org/packages/Pulumi.Azure.Constants)

# Pulumi.Azure.Constants
Additional constants for creating and configuring Microsoft Azure resources with [Pulumi Azure](https://github.com/pulumi/pulumi-azure).

## Usage

### Current
Instead of using custom strings when creating an 
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
    AccountReplicationType = AccountReplicationTypes.LocallyRedundantStorage, // You can now use a constant string here
    AccountTier = AccountTiers.Standard // You can now use a constant string here
});
```

***

# Constants
Constants are defined for the following resources:
- AppServicePlan
- Blob
- ConfigurationStore (AppConfiguration)
- Container
- FunctionApp
- Insights (ApplicationInsights)
- Storage