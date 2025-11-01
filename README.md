# ClaimsViewerWebPart


This web part used to be published on codeplex and was made for SharePoint 2013. Since it was not working on newer versions of SharePoint I repacked it and made it available here.


back in 2013 a web part was published on Codeplex which was called “ClaimsViewerWebPart”. I do not know who the author was, but since I stiil find it a really useful web part I decompiled the code and made a new project to support SharePoint 2019 and Subscription Edition.

Installation

To install a solution you need to open SharePoint Management Shell and run commands

Add-SPSolution -LiteralPath c:\temp\Xnet.SP.ClaimsViewerWebPart.wsp
  
Install-SPSolution -Identity Xnet.SP.ClaimsViewerWebPart.wsp -GACDeployment -WebApplication http://[mywebapp]

Activation

Once solution is installed, you can activate the web part and add it to your page.

In site collection administration, you need to find “Xnet – ClaimsViewerWebPart” feature and activate it.


More info on
https://r0b3r70.com/2025/11/01/using-claimsviewerwebpart-for-user-claims-in-sharepoint/
