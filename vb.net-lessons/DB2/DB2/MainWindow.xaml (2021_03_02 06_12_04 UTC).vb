Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs) Handles MyBase.Loaded

        Dim NwindDataSet As DB2.NwindDataSet = CType(Me.FindResource("NwindDataSet"), DB2.NwindDataSet)
        'Load data into the table Customers. You can modify this code as needed.
        Dim NwindDataSetCustomersTableAdapter As DB2.NwindDataSetTableAdapters.CustomersTableAdapter = New DB2.NwindDataSetTableAdapters.CustomersTableAdapter()
        NwindDataSetCustomersTableAdapter.Fill(NwindDataSet.Customers)
        Dim CustomersViewSource As System.Windows.Data.CollectionViewSource = CType(Me.FindResource("CustomersViewSource"), System.Windows.Data.CollectionViewSource)
        CustomersViewSource.View.MoveCurrentToFirst
    End Sub
End Class
