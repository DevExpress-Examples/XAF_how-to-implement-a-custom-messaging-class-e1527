Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Win.Core

Namespace CustomMessaging.Module.Win
    Public Class CustomWinFormsMessageBoxMessaging
        Inherits Messaging
        Public Sub New(ByVal application As XafApplication)
            MyBase.New(application)
        End Sub
        Protected Overloads Overrides Function ShowCore(ByVal message As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
            Dim result As DialogResult = MessageBox.Show(message, caption, buttons, icon)
            Return result
        End Function
    End Class
End Namespace
