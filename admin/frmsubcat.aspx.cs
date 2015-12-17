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
        nsgumtree.clssubcat obj = new nsgumtree.clssubcat();
        nsgumtree.clssubcatprp objprp = new nsgumtree.clssubcatprp();
        objprp.subcatcatcod = Convert.ToInt32(DropDownList1.SelectedValue);
        objprp.subcatnam = TextBox1.Text;
        if (Button1.Text == "submit")
            obj.save_rec(objprp);
        else
        {
            objprp.subcatcod = Convert.ToInt32(ViewState["cod"]);
            obj.update_rec(objprp);
            Button1.Text = "submit";
        }
        GridView1.DataBind();
        TextBox1.Text = string.Empty;

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsgumtree.clssubcat obj = new nsgumtree.clssubcat();
        List<nsgumtree.clssubcatprp> k = obj.find_rec(a);
        TextBox1.Text = k[0].subcatnam;
        Button1.Text = "update";
        ViewState["cod"] = a;
        e.Cancel = true;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsgumtree.clssubcat obj = new nsgumtree.clssubcat();
        nsgumtree.clssubcatprp objprp = new nsgumtree.clssubcatprp();
        objprp.subcatcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}