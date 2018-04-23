Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Media

Namespace ConditionalRowFormatting

	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class SimpleData
		Private privateColumn1 As String
		Public Property Column1() As String
			Get
				Return privateColumn1
			End Get
			Set(ByVal value As String)
				privateColumn1 = value
			End Set
		End Property
		Private privateColumn2 As Integer
		Public Property Column2() As Integer
			Get
				Return privateColumn2
			End Get
			Set(ByVal value As Integer)
				privateColumn2 = value
			End Set
		End Property

		Public Sub New()
		End Sub

		Public Sub New(ByVal str1 As String, ByVal int2 As Integer)
			Column1 = str1
			Column2 = int2
		End Sub
	End Class

	Public Class ColorValueConverter
		Inherits MarkupExtension
		Implements IValueConverter
		Private privateMaxValue As Integer
		Public Property MaxValue() As Integer
			Get
				Return privateMaxValue
			End Get
			Set(ByVal value As Integer)
				privateMaxValue = value
			End Set
		End Property

		#Region "IValueConverter Members"
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
			Dim count As Integer = MaxValue - CInt(Fix(value))

			Dim rStart As Integer = &Hff
			Dim gStart As Integer = &Had
			Dim bStart As Integer = &H5d

			Dim r As Integer = rStart + (&Hff - rStart) * count / MaxValue
			Dim g As Integer = gStart + (&Hff - gStart) * count / MaxValue
			Dim b As Integer = bStart + (&Hff - bStart) * count / MaxValue

			Return New SolidColorBrush(Color.FromArgb(255, CByte(r), CByte(g), CByte(b)))
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
		#End Region

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
	End Class
End Namespace
