'Jonaris De la Cruz 
'Cpt 182
'Chapter 6
'This program let the user enter 10 values representing the number of minutes that 
'they completed the corn maze successfully

Public Class frmCornMaze

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'close the application
        Close()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'clear all text entered
        ListBox1.Items.Clear()
        lblaverage.Text = ""

    End Sub

    Private Sub btnEnterTime_Click(sender As Object, e As EventArgs) Handles btnEnterTime.Click
        'declaration of variables

        Dim dectotalTime As Decimal = 0D
        Dim strInputHeading As String = "completion times"


        Dim strbtnEnterTime As String
        Dim decEnterTime As Decimal
        Dim decaveragetime As Decimal
        Dim strInputMessage As String = "Please enter time #"
        Dim strnormalmessage As String = "please enter time #"
        Dim strNegativeError As String = "Error- enter a positive number "
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1
        'input
        strbtnEnterTime = InputBox(strInputMessage & intNumberOfEntries, "")
        'loop
        Do Until intNumberOfEntries > intMaxNumberOfEntries

            If IsNumeric(strbtnEnterTime) Then
                decEnterTime = Integer.Parse(strbtnEnterTime)
                If decEnterTime > 0 Then
                    ListBox1.Items.Add(decEnterTime)
                    dectotalTime += decEnterTime
                    intNumberOfEntries += 1
                    strInputMessage = strnormalmessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNegativeError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strbtnEnterTime = InputBox(strInputMessage & intNumberOfEntries, strInputHeading)
            End If
        Loop
        'output of the program
        If intNumberOfEntries > 1 Then
            lblaverage.Visible = True
            decaveragetime = dectotalTime / (intNumberOfEntries - 1)
            lblaverage.Text = "The Average Completion time is " & decaveragetime.ToString("f1") & " minutes"
        Else
            MsgBox("no time entered")

        End If

    End Sub
End Class
