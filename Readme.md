<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
* [SampleData.cs](./CS/SampleData.cs) (VB: [SampleData.vb](./VB/SampleData.vb))
<!-- default file list end -->
# How to: Implement conditional formatting for rows


<p>The following sample demonstrates how to change the appearance of grid rows based on a condition.</p>


<h3>Description</h3>

This is done by binding the <strong>Background</strong> property of a style, assigned to a row, to a color converter. This converter is represented by the <strong>ColorValueConverter</strong> class that implements the <strong>IValueConverter</strong> interface and returns a color according to the provided numerical value.

<br/>


