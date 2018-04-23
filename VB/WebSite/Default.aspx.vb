Imports Microsoft.VisualBasic
Imports DevExpress.Web.ASPxEditors
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web.UI

Partial Public Class _Default
	Inherits Page
	Private Const itemStyleFormatString As String = "<span class=""toFind"">{0}</span>"

	Protected Sub ProductsCombo_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		ProductsComboChangeStyle()
	End Sub

	Protected Sub CategoriesCombo_DataBound(ByVal sender As Object, ByVal e As EventArgs)
		CategoriesComboChangeStyle()
	End Sub

	Private Sub CategoriesComboChangeStyle()
		For i As Integer = 0 To CategoriesCombo.Items.Count - 1
			If CategoryNeedToChangeStyle(i) Then
				CategoriesCombo.Items(i).Text = String.Format(itemStyleFormatString, CategoriesCombo.Items(i).Text)
			End If
		Next i
	End Sub

	Private Sub ProductsComboChangeStyle()
		Const fieldName As String = "ProductName" ' here you can place any STRING field of your ComboBox
		For i As Integer = 0 To ProductsCombo.Items.Count - 1
			If ProductNeedToChangeStyle(CDec(ProductsCombo.Items(i).GetValue("UnitPrice"))) Then
				ProductsCombo.Items(i).SetValue(fieldName, String.Format(itemStyleFormatString, ProductsCombo.Items(i).GetValue(fieldName)))
			End If
		Next i
	End Sub

	Private Function ProductNeedToChangeStyle(ByVal price As Decimal) As Boolean
		Return price >= 30
	End Function

	Private Function CategoryNeedToChangeStyle(ByVal index As Integer) As Boolean
		Return index Mod 2 = 0
	End Function
End Class