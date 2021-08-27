<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128650974/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E983)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
* [Window1.xaml.cs](./CS/Window1.xaml.cs) (VB: [Window1.xaml.vb](./VB/Window1.xaml.vb))
<!-- default file list end -->
# How to: Implement conditional formatting for rows


<p>The following sample demonstrates how to change the appearance of grid rows based on a condition.</p>


<h3>Description</h3>

This is done by binding the <strong>Background</strong> property of a style, assigned to a row, to a color converter. This converter is represented by the <strong>ColorValueConverter</strong> class that implements the <strong>IValueConverter</strong> interface and returns a color according to the provided numerical value.

<br/>


