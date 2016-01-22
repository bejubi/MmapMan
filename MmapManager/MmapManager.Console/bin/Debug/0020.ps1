[CmdletBinding()]

param (
)

begin {
    $ErrorActionPreference = "Stop"
    
    (New-Object System.Net.WebClient).DownloadFile('http://www.iftach.org/taxmatrix/charts/4Q2015.txt', "$env:USERPROFILE\Desktop\source\4Q2015.txt")
}

process {
}

end {
}