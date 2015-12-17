using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsgumtree.clscat obj = new nsgumtree.clscat();
        nsgumtree.clscatprp objprp = new nsgumtree.clscatprp();
        objprp.catnam = TextBox1.Text;
        if (Button1.Text == "submit")
            obj.save_rec(objprp);
        else
        {
            objprp.catcod = Convert.ToInt32(ViewState["cod"]);
            obj.update_rec(objprp);
            Button1.Text = "submit";
        }
        GridView1.DataBind();
        TextBox1.Text = string.Empty;
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        Int32 a = Convert.ToInt32(GridView1.DataKeys[e.NewEditIndex][0]);
        nsgumtree.clscat obj = new nsgumtree.clscat();
        List<nsgumtree.clscatprp> k = obj.find_rec(a);
        TextBox1.Text = k[0].catnam;
        Button1.Text = "update";
        ViewState["cod"] = a;
        e.Cancel = true;
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        nsgumtree.clscat obj = new nsgumtree.clscat();
        nsgumtree.clscatprp objprp = new nsgumtree.clscatprp();
        objprp.catcod = Convert.ToInt32(GridView1.DataKeys[e.RowIndex][0]);
        obj.delete_rec(objprp);
        GridView1.DataBind();
        e.Cancel = true;
    }
}