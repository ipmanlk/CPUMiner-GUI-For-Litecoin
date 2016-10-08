'
' Created by SharpDevelop.
' Date: 3/7/2016
' Time: 5:40 PM
'
Public Partial Class MainForm
Dim code As String 	'This will be the arguments for cli application 
	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub MainFormFormClosed(sender As Object, e As FormClosedEventArgs)	
		 If IsProcessRunning("minerd.exe") = True Then 'Checking CLI version of miner is already running, if it is, this will kill it. 
		 	killminer()
		 Else
		 	Call deletetemp 'Otherwise this program will delete the cli miner from your temp
		 End If
		 
	End Sub
	
	Sub GOClick(sender As Object, e As EventArgs)
		If String.IsNullOrEmpty(GO.Text) Or String.IsNullOrEmpty(worker.text) Or String.IsNullOrEmpty(pass.Text) Then 'Cheking input details
			code = " --url stratum+tcp://litecoinpool.org:3333 -a scrypt --userpass ipman99.2:2" 'If input details are empty, mining will consider as a donation
			Call MiningBTNCheck()
		Else 
			code = " --url " & url.Text & " -a scrypt --userpass " & worker.Text & ":" & pass.Text 'Else program will start to mining for your account
			Call MiningBTNCheck()
		End If
	End Sub
	
	Sub MiningBTNCheck() 'Button text change and calling miner
		If GO.Text = "Start Mining" Then
			Call StartMining 'This will start the minerd.exe
			GO.Text = "Stop Mining"
		Else If GO.Text = "Stop Mining"
			Call killminer 'This will kill the minerd.exe
			GO.Text = "Start Mining"
		End If
	End Sub
	
	Sub killminer() 'Killing miner process
		Process.GetProcessesByName("minerd")(0).Kill()
	End Sub
	
	Delegate Sub UpdateTextBoxDelg(ByVal text As String)
    Public myDelegate As UpdateTextBoxDelg = New UpdateTextBoxDelg(AddressOf UpdateTextBox)

    Public Sub UpdateTextBox(ByVal text As String) 'This will update the listbox
    	Dim line As String
		Dim shares As Integer
      	output.Items.Add(text)
        output.TopIndex = output.Items.Count - 1	
        
        For i= 0 To (output.Items.Count - 1)
            line = CStr(output.Items(i))
            If line.Contains("yay!!!") Then
            	shares = shares + 1
            	acceptedshares.Text  = "Shares : " & shares & " accepted. - Last @ " & TimeOfDay 'Updating Shares count
            End If
        Next
    End Sub

    Public Sub proc_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        On Error Resume Next
        If Me.InvokeRequired = True Then
            Me.Invoke(myDelegate, e.Data)
        Else
            UpdateTextBox(e.Data)
        End If

    End Sub
    
    Private Sub StartMining()
        Dim Proc = New Process()
		
		Proc.StartInfo.FileName = filename
        Proc.StartInfo.Arguments = code

        Proc.StartInfo.RedirectStandardOutput = True
        Proc.StartInfo.RedirectStandardError = True
        Proc.EnableRaisingEvents = True
        Application.DoEvents()
        Proc.StartInfo.CreateNoWindow = True
        Proc.StartInfo.UseShellExecute = False

        AddHandler Proc.ErrorDataReceived, AddressOf proc_OutputDataReceived
        AddHandler Proc.OutputDataReceived, AddressOf proc_OutputDataReceived
        Proc.Start()
        Proc.BeginErrorReadLine()
        Proc.BeginOutputReadLine()
        'Proc.WaitForExit()
        End Sub 
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Call ExtractFiles 'Extracting cli files to temp
		
		If IsProcessRunning("minerd.exe") = True Then
		 	killminer() 'If miner is running, kill it
		 End If
	End Sub
	
	
	
	Sub AboutClick(sender As Object, e As EventArgs)
		MsgBox("cpuminer-2.4.3 is used for this program. All thanks must go to it's original developer for his hard work. " & vbNewLine & vbNewLine &
			"GUI Created By ipman_98.")
	End Sub
	
	Sub MainFormResize(sender As Object, e As EventArgs)
		If Me.WindowState = FormWindowState.Minimized Then 
        	Me.Visible = False
       		minericon.ShowBalloonTip(1000, "", "CPUMiner GUI is here!", ToolTipIcon.Info)
    	  End If
	End Sub
	

End Class
