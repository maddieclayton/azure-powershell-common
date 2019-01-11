function New-AzureRmRoleAssignmentWithId
{
    [CmdletBinding()]
    param(
        [Guid]   [Parameter()] [alias("Id", "PrincipalId")] $ObjectId,
        [string] [Parameter()] $Scope,
        [Guid]   [Parameter()] $RoleDefinitionId,
        [switch] [Parameter()] $AllowDelegation,
        [Guid]   [Parameter()] $RoleAssignmentId
    )

    BEGIN {
        $context = Get-Context
        $client = Get-AuthorizationClient $context
    }
    PROCESS {
        $parameters = New-Object Microsoft.Azure.Management.Authorization.Version2015_07_01.Models.RoleAssignmentProperties -ArgumentList @($RoleDefinitionId, $ObjectId)
        $createParameters = New-Object Microsoft.Azure.Management.Authorization.Version2015_07_01.Models.RoleAssignmentCreateParameters -ArgumentList @($parameters)
        $createTask = $client.RoleAssignments.CreateWithHttpMessagesAsync($Scope, $RoleAssignmentId, $createParameters)
    }
    END {}
}

function New-AzureRmRoleDefinitionWithId
{
    [CmdletBinding()]
    param(
        [Microsoft.Azure.Commands.Resources.Models.Authorization.PSRoleDefinition] [Parameter()] $Role,
        [string] [Parameter()] $InputFile,
        [Guid]   [Parameter()] $RoleDefinitionId
    )

    $profile = [Microsoft.Azure.Commands.Common.Authentication.Abstractions.AzureRmProfileProvider]::Instance.Profile
    $cmdlet = New-Object -TypeName Microsoft.Azure.Commands.Resources.NewAzureRoleDefinitionCommand
    $cmdlet.DefaultProfile = $profile
	$cmdlet.CommandRuntime = $PSCmdlet.CommandRuntime

    if (-not ([string]::IsNullOrEmpty($InputFile)))
    {
        $cmdlet.InputFile = $InputFile
    }

    if ($Role -ne $null)
    {
        $cmdlet.Role = $Role
    }

    if ($RoleDefinitionId -ne $null -and $RoleDefinitionId -ne [System.Guid]::Empty)
    {
        $cmdlet.RoleDefinitionId = $RoleDefinitionId
    }

    $cmdlet.ExecuteCmdlet()
}

function Get-Context
{
      return [Microsoft.Azure.Commands.Common.Authentication.Abstractions.AzureRmProfileProvider]::Instance.Profile.DefaultContext
}

function Get-AuthorizationClient
{
  param([Microsoft.Azure.Commands.Common.Authentication.Abstractions.IAzureContext] $context)
  $factory = [Microsoft.Azure.Commands.Common.Authentication.AzureSession]::Instance.ClientFactory
  [System.Type[]]$types = [Microsoft.Azure.Commands.Common.Authentication.Abstractions.IAzureContext], [string]
  $method = [Microsoft.Azure.Commands.Common.Authentication.IClientFactory].GetMethod("CreateArmClient", $types)
  $closedMethod = $method.MakeGenericMethod([Microsoft.Azure.Management.Authorization.Version2015_07_01.AuthorizationManagementClient])
  $arguments = $context, [Microsoft.Azure.Commands.Common.Authentication.Abstractions.AzureEnvironment+Endpoint]::ResourceManager
  $client = $closedMethod.Invoke($factory, $arguments)
  return $client
}