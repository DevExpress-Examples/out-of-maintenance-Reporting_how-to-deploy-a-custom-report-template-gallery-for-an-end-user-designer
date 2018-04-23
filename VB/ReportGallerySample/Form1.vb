Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace ReportGallerySample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btShowDesigner_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btShowDesigner.Click
			Dim report As New XtraReport1()
			Dim designTool As New ReportDesignTool(report)
			designTool.ShowDesignerDialog()
		End Sub
	End Class
End Namespace
