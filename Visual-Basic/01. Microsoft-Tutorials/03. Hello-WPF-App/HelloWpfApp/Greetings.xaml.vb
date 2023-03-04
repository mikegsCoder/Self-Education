Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If HelloButton.IsChecked = True Then
            MessageBox.Show("Hello.")
        ElseIf GoodbyeButton.IsChecked = True Then
            MessageBox.Show("Goodbye.")
        End If
    End Sub
End Class
