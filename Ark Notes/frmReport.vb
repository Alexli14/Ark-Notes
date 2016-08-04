Public Class frmReport
    ''' <summary>
    ''' Sends Document To Printer When Clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.Document = pdCustomerList
        PrintDialog1.PrinterSettings = pdCustomerList.PrinterSettings
        PrintDialog1.AllowSomePages = True
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            pdCustomerList.PrinterSettings = PrintDialog1.PrinterSettings
            pdCustomerList.Print()
        End If
        wbReport.ShowPrintDialog()
    End Sub
End Class