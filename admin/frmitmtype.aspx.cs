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
        nsgumtree.clsitmtype obj = new nsgumtree.clsitmtype();
        nsgumtree.clsitmtypeprp objprp = new nsgumtree.clsitmtypeprp();
  
        objprp.itmsubcatcod = Convert.ToInt32(DropDownList2.SelectedValue);
        objprp.itmtypnam = TextBox1.Text;
        if (Button1.Text == "submit")
            obj.save_rec(objprp);
        else
        {
            objprp.itmtypcod = Convert.ToInt32(ViewState["cod"]);
            obj.update_rec(objprp);
            Button1.Text = "Submit";
        }
        GridView1.DataBind();
        TextBox1.Text = string.Empty;
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsgumtree.clsitmtype obj = new nsgumtree.clsitmtype();
        List<nsgumtree.clsitmtypeprp> k = obj.find_rec(a);
        TextBox1.Text = k[0].itmtypnam;
        Button1.Text = "Update";
        ViewState["cod"] = a;
        e.Cancel = true;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsgumtree.clsitmtype obj = new nsgumtree.clsitmtype();
        nsgumtree.clsitmtypeprp objprp = new nsgumtree.clsitmtypeprp();
        objprp.itmtypcod=Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel=true;
    }
}