Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.ExpressApp
Imports DevExpress.XtraEditors
Imports DevExpress.ExpressApp.Win.Core

Namespace CustomMessaging.Module.Win
    Friend Class CustomXtraMessageBoxMessaging
        Inherits Messaging
        Public Sub New(ByVal application As XafApplication)
            MyBase.New(application)
        End Sub
        Public Overrides Overloads Function Show(ByVal message As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
            Dim result As DialogResult = XtraMessageBox.Show(message, caption, buttons, icon, MessageBoxDefaultButton.Button2)
            OnConfirmationDialogClosed(result)
            Return result
        End Function
    End Class
End Namespace
