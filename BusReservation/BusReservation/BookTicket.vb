Public Class BookTicket

    Dim x As Integer
    Dim seat() As Label
    Dim lb As Label
    Private Sub Seat1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Seat1.Click, Seat2.Click, Seat3.Click, Seat4.Click, Seat5.Click, Seat6.Click, Seat7.Click, Seat8.Click, Seat9.Click, Seat10.Click, Seat11.Click, Seat12.Click, Seat13.Click, Seat14.Click, Seat15.Click, Seat16.Click, Seat17.Click, Seat18.Click, Seat19.Click, Seat20.Click, Seat21.Click, Seat22.Click, Seat23.Click, Seat24.Click, Seat25.Click, Seat26.Click, Seat27.Click, Seat28.Click, Seat29.Click, Seat30.Click, Seat31.Click, Seat32.Click, Seat33.Click, Seat34.Click, Seat35.Click, Seat36.Click, Seat37.Click, Seat38.Click, Seat39.Click, Seat40.Click, Seat41.Click, Seat42.Click, Seat43.Click, Seat44.Click, Seat45.Click, Seat46.Click, Seat47.Click
        lb = sender
        For i = 0 To 46
            If lb.Text = seat(i).Text Then
                If seat(i).BackColor = Color.GreenYellow Then
                    txtSeatNumber.Text = ""
                    seat(i).BackColor = Color.White
                Else
                    seat(i).BackColor = Color.GreenYellow
                    txtSeatNumber.Text = lb.Text

                End If
            End If
        Next
    End Sub

    Private Sub BookTicket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        x = 0
        seat = New Label() {Seat1, Seat2, Seat3, Seat4, Seat5, Seat6, Seat7, Seat8, Seat9, Seat10, Seat11, Seat12, Seat13, Seat14, Seat15, Seat16, Seat17, Seat18, Seat19, Seat20, Seat21, Seat22, Seat23, Seat24, Seat25, Seat26, Seat27, Seat28, Seat29, Seat30, Seat31, Seat32, Seat33, Seat34, Seat35, Seat36, Seat37, Seat38, Seat39, Seat40, Seat41, Seat42, Seat43, Seat44, Seat45, Seat46, Seat47}
        For i = 0 To 46
            seat(i).BackColor = Color.White
        Next
    End Sub
End Class