Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Markup
Imports System.Windows.Media

Namespace ConditionalRowFormatting

	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
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
			Return New SolidColorBrush(GetGradientColor(count))
		End Function
		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
		#End Region
		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return Me
		End Function
		Private Function GetGradientColor(ByVal count As Integer) As Color
			Dim color As Color = Color.FromRgb(&Hff, &Had, &H5d)
			Dim r As Byte = CByte(color.R + (&Hff - color.R) * count / MaxValue)
			Dim g As Byte = CByte(color.G + (&Hff - color.G) * count / MaxValue)
			Dim b As Byte = CByte(color.B + (&Hff - color.B) * count / MaxValue)
			Return Color.FromArgb(255, r, g, b)
		End Function
	End Class
End Namespace
