$logFilePath = 'c:\users\t000257\desktop\log.txt'
"[$(Get-Date -f 'yyyy-MM-dd HH:mm:ss')] - Message: This is a test" | Out-File -Encoding utf8 -FilePath $logFilePath -Append

read-host