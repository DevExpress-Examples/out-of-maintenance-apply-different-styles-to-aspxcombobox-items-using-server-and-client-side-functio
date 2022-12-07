using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

public partial class _Default : Page
{
    const string itemStyleFormatString = "<span class=\"toFind\">{0}</span>";

    protected void ProductsCombo_DataBound(object sender, EventArgs e)
    {
        ProductsComboChangeStyle();
    }

    protected void CategoriesCombo_DataBound(object sender, EventArgs e)
    {
        CategoriesComboChangeStyle();
    }

    private void CategoriesComboChangeStyle()
    {
        for (int i = 0; i < CategoriesCombo.Items.Count; i++)
            if (CategoryNeedToChangeStyle(i))
                CategoriesCombo.Items[i].Text = String.Format(itemStyleFormatString, CategoriesCombo.Items[i].Text);
    }

    private void ProductsComboChangeStyle()
    {
        const string fieldName = "ProductName"; // here you can place any STRING field of your ComboBox
        for (int i = 0; i < ProductsCombo.Items.Count; i++)
            if (ProductNeedToChangeStyle((decimal)ProductsCombo.Items[i].GetValue("UnitPrice")))
                ProductsCombo.Items[i].SetValue(fieldName, String.Format(itemStyleFormatString, ProductsCombo.Items[i].GetValue(fieldName)));
    }

    private bool ProductNeedToChangeStyle(decimal price)
    {
        return price >= 30;
    }

    private bool CategoryNeedToChangeStyle(int index)
    {
        return index % 2 == 0;
    }
}