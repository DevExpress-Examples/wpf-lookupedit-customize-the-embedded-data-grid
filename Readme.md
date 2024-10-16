<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128645178/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2648)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF LookUpEdit - Customize the Embedded Data Grid

This example illustrates how to customize the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) displayed within the DevExpress WPF [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)'s popup window.

1. Set the [LookUpEdit.AutoPopulateColumns](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit.AutoPopulateColumns) property to `false`.
1. Use the [PopupBaseEdit.PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate) property to specify a custom [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl).
2. Set the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s name to **PART_GridControl**.

![image](https://user-images.githubusercontent.com/65009440/186624388-6ae68b82-5db0-4313-9d53-a6021dab8310.png)

## Files to Look at

* [MainWindow.xaml](./CS/HowToCreateLookUpEdit/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/HowToCreateLookUpEdit/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/HowToCreateLookUpEdit/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/HowToCreateLookUpEdit/MainWindow.xaml.vb))

## Documentation

* [PopupBaseEdit.PopupContentTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupBaseEdit.PopupContentTemplate)
* [LookUpEdit](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.LookUp.LookUpEdit)

## More Examples

* [WPF LookUpEdit - Display a TreeList as Popup Content](https://github.com/DevExpress-Examples/wpf-lookupedit-display-treelist-as-popup-content)
* [WPF LookUpEdit - Process New Values](https://github.com/DevExpress-Examples/lookupedit-processing-new-values-e2646)
* [WPF LookUpEdit - Enable Multiple Selection Mode](https://github.com/DevExpress-Examples/wpf-lookupedit-enable-multiple-selection-mode)
* [WPF LookUpEdit - Filter by Multiple Columns](https://github.com/DevExpress-Examples/wpf-lookupedit-filter-by-multiple-columns)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-customize-the-embedded-data-grid&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-lookupedit-customize-the-embedded-data-grid&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
