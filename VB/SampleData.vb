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

Imports DevExpress.Mvvm
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel

Namespace ConditionalRowFormatting
	Public Class SimpleDataList
		Inherits ObservableCollection(Of SimpleData)

		Protected _InitCount As Integer
		Public Property InitCount() As Integer
			Get
				Return Me._InitCount
			End Get

			Set(ByVal value As Integer)
				If Me._InitCount <> value Then
					Me._InitCount = value
					Populate()
					OnPropertyChanged(New PropertyChangedEventArgs("InitCount"))
				End If
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
		Inherits BindableBase

		Protected _Text As String
		Public Property Text() As String
			Get
				Return Me._Text
			End Get
			Set(ByVal value As String)
				Me.SetProperty(Me._Text, value, "Text")
			End Set
		End Property

		Protected _Int As Integer
		Public Property Int() As Integer
			Get
				Return Me._Int
			End Get
			Set(ByVal value As Integer)
				Me.SetProperty(Me._Int, value, "Int")
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
