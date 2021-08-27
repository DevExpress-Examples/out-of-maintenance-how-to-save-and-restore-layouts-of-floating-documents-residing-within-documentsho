<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128617536/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T146388)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Main.cs](./CS/DXApplication2/Main.cs) (VB: [Main.vb](./VB/DXApplication2/Main.vb))
* [MyUserSettings.cs](./CS/DXApplication2/MyUserSettings.cs) (VB: [MyUserSettings.vb](./VB/DXApplication2/MyUserSettings.vb))
* [Program.cs](./CS/DXApplication2/Program.cs) (VB: [Program.vb](./VB/DXApplication2/Program.vb))
<!-- default file list end -->
# How to save and restore layouts of floating documents residing within DocumentsHost


<p>When you set the <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraBarsDocking2010ViewsBaseView_FloatingDocumentContainertopic">BaseView.FloatingDocumentContainer property</a> to <strong>DocumentsHost</strong>, floating documents are hosted within a container to which other documents can be docked. Thus, this floating container contains its own <a href="https://documentation.devexpress.com/windowsforms/clsDevExpressXtraBarsDocking2010DocumentManagertopic.aspx">DocumentManager</a>. As a result, if you wish to save layouts of floating documents residing within such a floating container, you need to access their own <strong>DocumentManagers</strong>. You can do this in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDocking2010ViewsBaseView_RegisterDocumentsHostWindowtopic">BaseView.RegisterDocumentsHostWindow</a> event handler. Finally, obtain a corresponding <strong>View</strong> via the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDocking2010DocumentManager_Viewtopic">DocumentManager.View property</a>, and use its <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraBarsDocking2010ViewsBaseView_SaveLayoutToXmltopic">BaseView.SaveLayoutToXml</a> and <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraBarsDocking2010ViewsBaseView_RestoreLayoutFromXmltopic">BaseView.RestoreLayoutFromXml</a> or <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraBarsDocking2010ViewsBaseView_SaveLayoutToStreamtopic">BaseView.SaveLayoutToStream</a> and <a href="https://documentation.devexpress.com/#windowsforms/DevExpressXtraBarsDocking2010ViewsBaseView_RestoreLayoutFromStreamtopic">BaseView.RestoreLayoutFromStream</a> methods. <br /><br />This example illustrates how to collect all the Views associated with floating containers, and save and restore their layouts. In short, we create a list of Views where we add a new View in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDocking2010ViewsBaseView_RegisterDocumentsHostWindowtopic">BaseView.RegisterDocumentsHostWindow</a> event handler. We also delete a View after its floating container is destroyed in the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDocking2010ViewsBaseView_UnregisterDocumentsHostWindowtopic">BaseView.UnregisterDocumentsHostWindow</a> event handler. </p>

<br/>


