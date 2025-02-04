#ERROR REPORTING ALL
Set-StrictMode -Version latest
$path     = "C:\Users\mio.mk.gam\Documents\Avanade\Projects\TM CASE\Documents\LLD"
$files    = Get-Childitem $path -Include *.docx,*.doc -Recurse | Where-Object { !($_.psiscontainer) }
$output   = "C:\Users\mio.mk.gam\Avanade\CASE - Documents\To-Do\Development & Fixing\Internal Changes\Assessment Support\result.csv"
$application = New-Object -comobject word.application
$application.visible = $False
$findtext = "Case with Adjustment"
$charactersAround = 30
$results = @{}

Function getStringMatch
{
    clear
    # Loop through all *.doc files in the $path directory
    Foreach ($file In $files)
    {
        
        $document = $application.documents.open($file.FullName,$false,$true)
        $range = $document.content

        If($range.Text -match ".{$($charactersAround)}$($findtext).{$($charactersAround)}"){
             $properties = @{
                File = $file.FullName
                Match = $findtext
                TextAround = $Matches[0] 
             }
             $results += New-Object -TypeName PsCustomObject -Property $properties
             Write-Output $file.FullName
        }
    }

    If($results){
        $results | Export-Csv $output -NoTypeInformation
    }

    $document.close()
    $application.quit()
}

getStringMatch

import-csv $output