using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsgumtree.clsusr obj = new nsgumtree.clsusr();
        Int32 a;
        char rol;
        a = obj.logincheck(txteml.Text, txtpwd.Text, out rol);
        if (a == -1)
            Label1.Text = "Email/Password Incorrect";
          
        else
        {
            Session["cod"] = a;
            if (rol == 'a')
                Response.Redirect("admin/frmcat.aspx");
            else if (rol == 'u')
                Response.Redirect("user/frmpstadv.aspx");
        }
        txteml.Text = string.Empty;
        txtpwd.Text = string.Empty;
        txteml.Focus();
    }
}