<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128530491/13.2.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5191)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# Apply different styles to ASPxComboBox items using server and client-side functionally
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5191/)**
<!-- run online end -->


<p>This example demonstrates how to apply different styles to different elements of the <strong>ASPxComboBox</strong>.<br />
To do so, you should handle the <strong>ASPxComboBox.DataBound</strong> event and manually modify the text of items whose style you need to change. Please note that <strong>ASPxComboBox </strong>must have at least one <strong>string </strong>column or have no columns at all.</p><p>In the first case, you should work with <strong>ASPxComboBoxItem.GetValue</strong> and<strong> ASPxComboBoxItem.SetValue</strong> methods and in the second one, with the <strong>ASPxComboBoxItem.Text</strong> property. In both cases, you should add 

```html
<span class="someClass">
```

   to the text of the target item and set <strong>ASPxComboBox.EncodeHtml</strong> property to false. If this property is true, html tags will be displayed like common text.</p><p>Finally, on the client side, you should change styles of elements marked by a specific class.</p><p>Please see this example for more details.</p>

<br/>


