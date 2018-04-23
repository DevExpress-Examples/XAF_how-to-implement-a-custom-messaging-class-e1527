Imports Microsoft.VisualBasic
Imports System

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Data.Filtering

Namespace CustomMessaging.Module.Win
    Public Class Updater
        Inherits ModuleUpdater
        Public Sub New(ByVal objectSpace As ObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            Dim person1 As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Robert' && LastName == 'King'"))
            Dim person2 As Person = ObjectSpace.FindObject(Of Person)(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"))
            If person1 Is Nothing Then
                person1 = ObjectSpace.CreateObject(Of Person)()
                person1.FirstName = "Robert"
                person1.LastName = "King"
                person1.Save()
            End If
            If person2 Is Nothing Then
                person2 = ObjectSpace.CreateObject(Of Person)()
                person2.FirstName = "Mary"
                person2.LastName = "Tellitson"
                person2.Save()
            End If
        End Sub
    End Class
End Namespace
