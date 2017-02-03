Public Class Form1

    Dim MauveAttack As Integer
    Dim isWon As Boolean = True
    Dim highestWin As Boolean = True
    Dim isHighestWin As Integer
    Dim highestWinText As String

    Private Function calculateIfWon()

        isHighestWin = Int(Rnd() * 10) + 1

        If isHighestWin < 5 Then
            highestWin = False
            highestWinText = "The lowest number wins"
        Else
            highestWin = True
            highestWinText = "The highest number wins"

        End If



        MauveAttack = Int(Rnd() * 10) + 1

        If highestWin = True Then
            If NumericUpDown1.Value < MauveAttack Then
                isWon = False
            End If

            If NumericUpDown1.Value >= MauveAttack Then
                isWon = True
            End If
        End If

        If highestWin = False Then
            If NumericUpDown1.Value >= MauveAttack Then
                isWon = False
            End If

            If NumericUpDown1.Value < MauveAttack Then
                isWon = True
            End If
        End If

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        calculateIfWon()

        If isWon = False Then
            MessageBox.Show("Mr Mauve stole your seat!", highestWinText)
        Else
            MessageBox.Show("You got a seat!", highestWinText)
        End If

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub
End Class
