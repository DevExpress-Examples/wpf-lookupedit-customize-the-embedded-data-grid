Imports System.Windows

Namespace HowToCreateLookUpEdit

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.lookUpEdit1.ItemsSource = New ProductList()
        End Sub
    End Class
End Namespace
