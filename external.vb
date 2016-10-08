'
' Created by SharpDevelop.
' User: IP-Man
' Date: 3/7/2016
' Time: 6:39 PM
'
Imports System.IO 
Public Module external
	Public filename As String = Path.GetTempPath & "\minerd.exe"	
		Public Sub ExtractFiles
			Dim ms1 As New IO.MemoryStream(My.Resources.libcurl)
			Dim fs1 As IO.FileStream = IO.File.OpenWrite(Path.GetTempPath & "\libcurl-4.dll")
			ms1.WriteTo(fs1)
			fs1.Close()
			ms1.Close()
		
			Dim ms2 As New IO.MemoryStream(My.Resources.libwinpthread)
			Dim fs2 As IO.FileStream = IO.File.OpenWrite(Path.GetTempPath & "\libwinpthread-1.dll")
			ms2.WriteTo(fs2)
			fs2.Close()
			ms2.Close()
		
			Dim ms3 As New IO.MemoryStream(My.Resources.minerd)
			Dim fs3 As IO.FileStream = IO.File.OpenWrite(Path.GetTempPath & "\minerd.exe")
			ms3.WriteTo(fs3)
			fs3.Close()
			ms3.Close()
		
			Dim ms4 As New IO.MemoryStream(My.Resources.zlib1)
			Dim fs4 As IO.FileStream = IO.File.OpenWrite(Path.GetTempPath & "\zlib1.dll")
			ms4.WriteTo(fs4)
			fs4.Close()
			ms4.Close()
		
		End Sub
		
		Public Sub deletetemp
			My.Computer.FileSystem.DeleteFile(Path.GetTempPath & "\libcurl-4.dll")
			My.Computer.FileSystem.DeleteFile(Path.GetTempPath & "\libwinpthread-1.dll")
			My.Computer.FileSystem.DeleteFile(Path.GetTempPath & "\minerd.exe")
			My.Computer.FileSystem.DeleteFile(Path.GetTempPath & "\zlib1.dll")
		End Sub
		
		Public Function IsProcessRunning(ByVal process As String)
        	Dim objList As Object
        	objList = GetObject("winmgmts:") _
            	.ExecQuery("select * from win32_process where name='" & process & "'")

       		 If objList.Count > 0 Then
           		 IsProcessRunning = True
       		 Else

            	 IsProcessRunning = False
        End If

    End Function
End Module
