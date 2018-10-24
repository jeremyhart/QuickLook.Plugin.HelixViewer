Remove-Item ..\QuickLook.Plugin.FontViewer.qlplugin -ErrorAction SilentlyContinue

$files = Get-ChildItem -Path ..\bin\Release\ -Exclude *.pdb,*.xml
$files += "..\QuickLook.Plugin.Metadata.config"
Compress-Archive $files .\QuickLook.Plugin.FontViewer.zip
Move-Item .\QuickLook.Plugin.FontViewer.zip ..\QuickLook.Plugin.FontViewer.qlplugin