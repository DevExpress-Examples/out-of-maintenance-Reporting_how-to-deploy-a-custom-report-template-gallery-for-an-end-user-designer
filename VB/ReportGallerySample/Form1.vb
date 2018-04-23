Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
' ...

Namespace ReportGallerySample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btShowDesigner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btShowDesigner.Click
			Dim report As New XtraReport1()
			report.ShowDesignerDialog()
		End Sub
	End Class
End Namespace
