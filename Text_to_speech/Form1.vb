Imports System.Speech.Synthesis

Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button7.Click
        Dim SAPI As New Object
        Dim spn As New SpeechSynthesizer
        spn.Rate = TrackBar4.Value
        spn.Volume = TrackBar1.Value
        spn.SelectVoiceByHints(VoiceGender.Male)
        TextBox1.ForeColor = Color.Red
        If (TextBox1.Text = Nothing) Then
            MsgBox("textfield cannot be empty")
            TextBox1.Focus()

        End If

        'prompting user to increase volume '
        If (TrackBar1.Value = 0) Then
            MsgBox("Please increase the volume ")
            Exit Sub
        End If
        If (ComboBox2.Text = "MALE") Then
            spn.SelectVoiceByHints(VoiceGender.Male)
        Else
            spn.SelectVoiceByHints(VoiceGender.Female)
        End If
        spn.Speak(TextBox1.Text)
        TextBox1.ForeColor = Color.Black






    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = 70

    End Sub
End Class
