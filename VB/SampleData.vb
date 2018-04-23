' Developer Express Code Central Example:
' How to implement conditional formatting for rows
' 
' The following sample demonstrates how to change the appearance of grid rows
' based on some condition. For example, in this tutorial you can see that the
' background color of grid rows is gradually changed based on the value in the
' second data column.
' This is done by binding the Background property of a style,
' assigned to a row, to a color converter. This converter is represented by the
' ColorValueConverter class that implements the IValueConverter interface and
' returns a color according to the provided numerical value.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E983


Imports Microsoft.VisualBasic
Imports System.Collections.Generic

Namespace ConditionalRowFormatting
	Public Class SimpleDataList
		Inherits List(Of SimpleData)
		Private initCount_Renamed As Integer
		Public Property InitCount() As Integer
			Get
				Return Me.initCount_Renamed
			End Get
			Set(ByVal value As Integer)
				Me.initCount_Renamed = value
				Populate()
			End Set
		End Property
		Private Sub Populate()
			Clear()
			For i As Integer = 0 To InitCount - 1
				Add(New SimpleData("Row " & i, i))
			Next i
		End Sub
	End Class
	Public Class SimpleData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateInt As Integer
		Public Property Int() As Integer
			Get
				Return privateInt
			End Get
			Set(ByVal value As Integer)
				privateInt = value
			End Set
		End Property
		Public Sub New()
		End Sub
		Public Sub New(ByVal str As String, ByVal num As Integer)
			Text = str
			Int = num
		End Sub
	End Class
End Namespace
