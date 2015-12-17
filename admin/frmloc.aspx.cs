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
    protected void Button3_Click(object sender, EventArgs e)
    {
        nsgumtree.clsloc obj = new nsgumtree.clsloc();
        nsgumtree.clslocprp objprp = new nsgumtree.clslocprp();
        objprp.loccntcod = Convert.ToInt32(DropDownList1.SelectedValue);
        objprp.locnam = TextBox1.Text;
        if (Button3.Text == "submit")
            obj.save_rec(objprp);
        else
        {
            objprp.loccod = Convert.ToInt32(ViewState["cod"]);
            obj.update_rec(objprp);
            Button3.Text = "submit";
        }
        GridView1.DataBind();
        TextBox1.Text = string.Empty;

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
{
         Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsgumtree.clsloc obj = new nsgumtree.clsloc();
        List<nsgumtree.clslocprp> k = obj.find_rec(a);
        TextBox1.Text = k[0].locnam;
        Button3.Text = "update";
        ViewState["cod"] = a;
        e.Cancel = true;
}
protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
{
    nsgumtree.clsloc obj = new nsgumtree.clsloc();
        nsgumtree.clslocprp objprp = new nsgumtree.clslocprp();
        objprp.loccod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
}
protected void Button4_Click(object sender, EventArgs e)
{
    TextBox1.Text = string.Empty;
    DropDownList1.Focus();

}
}
    