Imports Microsoft.VisualBasic
Imports System
Namespace ReportGallerySample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.btShowDesigner = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' btShowDesigner
			' 
			Me.btShowDesigner.Location = New System.Drawing.Point(25, 90)
			Me.btShowDesigner.Name = "btShowDesigner"
			Me.btShowDesigner.Size = New System.Drawing.Size(225, 52)
			Me.btShowDesigner.TabIndex = 0
			Me.btShowDesigner.Text = "Show Designer"
			Me.btShowDesigner.UseVisualStyleBackColor = True
'			Me.btShowDesigner.Click += New System.EventHandler(Me.btShowDesigner_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.btShowDesigner)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btShowDesigner As System.Windows.Forms.Button
	End Class
End Namespace

