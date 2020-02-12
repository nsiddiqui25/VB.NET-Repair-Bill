Public Class frmRepairBill
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'First we declare variables for inputs labor, parts, total, and name that will hold the data and result
        Dim labor, parts, total As Double
        Dim name As String

        'this clears the List-Box when Display button is clicked so it populates new data everytime instead of appending to existing data
        lstDisplay.Items.Clear()

        'ensure user entered valid input; make sure Labor and Parts are numeric and Name is not left empty(i.e. entered)
        If IsNumeric(txtLabor.Text) And IsNumeric(txtParts.Text) And txtName.Text <> "" Then
            'explicit Conversion of labor And parts to Double
            labor = CDbl(txtLabor.Text)
            parts = CDbl(txtParts.Text)
            'this Is already a string so no need to convert
            name = txtName.Text

            'variable that holds the cost of labor
            Dim laborCost As Double = labor * 35
            'variable that holds the cost of parts
            Dim partsCost As Double = parts + (parts * 0.05)
            'total of labor and parts
            total = laborCost + partsCost

            'to add all the data to our List-Box
            lstDisplay.Items.Add("Customer: " & name)
            'FormatCurrency() will format like currency (dollar sign and double digit)
            lstDisplay.Items.Add("Labor Cost: " & FormatCurrency(laborCost))
            lstDisplay.Items.Add("Parts Cost: " & FormatCurrency(partsCost))
            lstDisplay.Items.Add("Total Cost: " & FormatCurrency(total))
        Else
            MessageBox.Show("Please enter valid input")
        End If
    End Sub
End Class
