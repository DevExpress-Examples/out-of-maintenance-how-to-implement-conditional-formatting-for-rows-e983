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
