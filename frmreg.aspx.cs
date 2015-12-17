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
        nsgumtree.clsusrprp objprp = new nsgumtree.clsusrprp();
        objprp.usrnam = txtnam.Text;
        objprp.usreml = txteml.Text;
        objprp.usrpwd = txtpwd.Text;
        objprp.usrloccod = Convert.ToInt32(DropDownList2.SelectedValue);
        objprp.usrphn = txtphn.Text;
    //    objprp.usrpln =Convert.ToInt32(DropDownList3.SelectedValue);
       
        objprp.usrregdat = DateTime.Now;
        objprp.usrrol = 'u';
       try
        {
            obj.save_rec(objprp);
            txteml.Text = string.Empty;
            txtnam.Text = string.Empty;
            txtphn.Text = string.Empty;

            Label1.Text = "Registration Successfull";
        }
        catch(Exception exp)
        {
            Label1.Text="Email Id already Exists";
        }
    }
}