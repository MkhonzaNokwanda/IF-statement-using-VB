Public Class Form1
    Private Sub btnGender_Click(sender As Object, e As EventArgs) Handles btnGender.Click
        Dim strGender As String
        Dim strName As String
        Dim iBirthYear As Integer
        Dim iThisYear As Integer
        Dim iAge As Integer
        Dim strHomeLanguage As String
        Dim strGreeting As String

        strGender = lstGender.SelectedItem
        strName = txtName.Text
        iBirthYear = txtBirthYear.Text
        iThisYear = Year(Today)
        iAge = iThisYear - iBirthYear
        strHomeLanguage = lslHomeLanguage.SelectedItem

        If strHomeLanguage = "IsiZulu" Then
            strGreeting = "Sawubona!"
        ElseIf strHomeLanguage = "English" Then
            strGreeting = "Hello!"
        Else
            strGreeting = "Ndaa!"
        End If
        If strGender = "Female" Then
            MsgBox(strGreeting & " " & "You are" & " " & strName & "," & iAge & " years old " & "and you are a lady")
        ElseIf strGender = "Other" Then
            MsgBox(strGreeting & " You are" & " " & strName & "," & iAge & " years old " & "and you do not want you gender to be disclosed")
        Else
            MsgBox(strGreeting & " You are" & " " & strName & "," & iAge & " years old " & "and you are a gentle man")
        End If

    End Sub

    Private Sub lstGender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGender.SelectedIndexChanged

    End Sub

    Private Sub lblGender_Click(sender As Object, e As EventArgs) Handles lblGender.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBirthYear.TextChanged

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lslHomeLanguage.SelectedIndexChanged

    End Sub
End Class
