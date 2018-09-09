'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/7/2016
' Time: 5:40 PM
'
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' This file controls the behaviour of the application.
    Partial Friend Class MyApplication
        Public Sub New()
            MyBase.New(AuthenticationMode.Windows)
            Me.IsSingleInstance = False
            Me.EnableVisualStyles = True
            Me.SaveMySettingsOnExit = True
            Me.ShutdownStyle = ShutdownMode.AfterMainFormCloses
        End Sub

        Protected Overrides Sub OnCreateMainForm()
            Me.MainForm = My.Forms.MainForm
        End Sub
    End Class
End Namespace
