Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.ComponentModel

Imports DevExpress.ExpressApp

Namespace CustomMessaging.Module.Win
    <ToolboxItemFilter("Xaf.Platform.Win")> _
    Public NotInheritable Partial Class CustomMessagingWindowsFormsModule
        Inherits ModuleBase
        Public Sub New()
            InitializeComponent()
        End Sub
    End Class
End Namespace
