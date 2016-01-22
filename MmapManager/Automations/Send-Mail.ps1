[CmdletBinding()]

param (
)

begin {
    $ErrorActionPreference = "Stop"

    $params = @{}
    $params.From = "mjohnson2@jjkeller.com"
    $params.To = @("mjohnson2@jjkeller.com", "mmaass@jjkeller.com", "scolligan@jjkeller.com", "dmcgill@jjkeller.com") 
    $params.Subject = "Test from Mmap Man"
    $params.Body = "Test from Mmap Man"
    $params.SMTPServer = "insidemail.corpr.jjkeller.local"

    Send-MailMessage @params
}

process {
}

end {
}