using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsgumtree.clspln obj = new nsgumtree.clspln();
        nsgumtree.clsplnprp objprp = new nsgumtree.clsplnprp();
        objprp.plnsubcatcod = Convert.ToInt32(DropDownList2.SelectedValue);
        objprp.plncst = Convert.ToSingle(TextBox1.Text);
        if (Button1.Text == "submit")
            obj.save_rec(objprp);
        else
        {

            objprp.plncod = Convert.ToInt32(ViewState["cod"]);
            obj.update_rec(objprp);
            Button1.Text = "submit";
        }
        TextBox1.Text = string.Empty;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsgumtree.clspln obj = new nsgumtree.clspln();
        List<nsgumtree.clsplnprp> k = obj.find_rec(a);
        DropDownList1.DataBind();
        DropDownList1.SelectedIndex = -1;
        nsgumtree.clssubcat obj1 = new nsgumtree.clssubcat();
        List<nsgumtree.clssubcatprp> k1 = obj1.find_rec(k[0].plnsubcatcod);
        DropDownList1.Items.FindByValue(k1[0].subcatcatcod.ToString()).Selected = true;
        DropDownList2.DataBind();
        DropDownList2.SelectedIndex = -1;
        DropDownList2.Items.FindByValue(k[0].plnsubcatcod.ToString()).Selected = true;
        TextBox1.Text = k[0].plncst.ToString();
        ViewState["cod"] = a;
        Button1.Text = "update";
        e.Cancel = true;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsgumtree.clspln obj = new nsgumtree.clspln();
        nsgumtree.clsplnprp objprp = new nsgumtree.clsplnprp();
        objprp.plncod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}