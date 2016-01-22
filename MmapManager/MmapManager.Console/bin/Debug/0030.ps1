[CmdletBinding()]

param (
)

begin {
    $ErrorActionPreference = "Stop"

    Get-ChildItem -Path "$env:USERPROFILE\Desktop\source" | Copy-Item -Destination "$env:USERPROFILE\Desktop\destination"
}

process {
}

end {
}