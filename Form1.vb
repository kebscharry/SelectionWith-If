Public Class Form1
    Private Sub btnGreeting_Click(sender As Object, e As EventArgs) Handles btnGreeting.Click

        Dim stCountry As String
        stCountry = txtCountry.Text
        stCountry = stCountry.ToUpper

        If stCountry = "AUSTRALIA" Then
            MsgBox("goodday mate")
            MsgBox("good on yah")
            MsgBox("no worries")
            MsgBox("goodday mate")
        ElseIf stCountry = "FRANCE" Then
            MsgBox("bonjour")
            MsgBox("mucho gusto")
            MsgBox("commet tu appele")
        ElseIf stCountry = "JAPAN" Then
            MsgBox("konnichiwa")
            MsgBox("shi shi")
        Else
            MsgBox("hello there")
            MsgBox("i hope you are well")
        End If
    End Sub
End Class
