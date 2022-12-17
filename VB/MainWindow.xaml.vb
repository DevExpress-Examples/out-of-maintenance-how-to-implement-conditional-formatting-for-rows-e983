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
Imports System.Windows

Namespace ConditionalRowFormatting

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
