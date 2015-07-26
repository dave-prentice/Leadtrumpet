Get-ChildItem .\packages | Remove-Item -Recurse -Force

Get-Item .\Packages | Remove-Item

foreach($package in ls node_modules){npm uninstall $package}