Imports Microsoft.VisualBasic
Imports System.Windows

Namespace HowToCreateLookUpEdit
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			lookUpEdit1.ItemsSource = New ProductList()
		End Sub
	End Class
End Namespace
