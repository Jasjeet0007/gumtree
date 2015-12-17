using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class user_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            TabContainer1.Tabs[1].Enabled = false;
            TabContainer1.ActiveTabIndex = 0;

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        nsgumtree.clsadv obj = new nsgumtree.clsadv();
        nsgumtree.clsadvprp objprp = new nsgumtree.clsadvprp();
        objprp.advdat = DateTime.Now;
        objprp.advdsc = txtdsc.Text;
        objprp.advitmtypcod = Convert.ToInt32(DropDownList3.SelectedValue);
        objprp.advmanpiccod = -1;
        objprp.advprc = Convert.ToInt32(txtprc.Text);
        objprp.advsts = 'N';
        objprp.advtit = txtadvtit.Text;
        objprp.advusrcod = Convert.ToInt32(Session["cod"]);

        Int32 a = obj.save_rec(objprp);
        ViewState["cod"] = a;
        TabContainer1.Tabs[0].Enabled = false;
        TabContainer1.Tabs[1].Enabled = true;
        TabContainer1.ActiveTabIndex = 1;


    }
    private void Bind()
    {
        nsgumtree.clsadvpic obj = new nsgumtree.clsadvpic();
        DataList1.DataSource = obj.disp_rec(Convert.ToInt32(ViewState["cod"]));
        DataList1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        nsgumtree.clsadvpic obj = new nsgumtree.clsadvpic();
        nsgumtree.clsadvpicprp objprp = new nsgumtree.clsadvpicprp();
        objprp.advpicadvcod = Convert.ToInt32(ViewState["cod"]);
        objprp.advpicdsc = TextBox1.Text;
        objprp.advpicsts = Convert.ToChar(RadioButtonList1.SelectedValue);
        string s = FileUpload1.PostedFile.FileName;
        if (s != " ")
            s = s.Substring(s.LastIndexOf('.'));
        objprp.advpicpic = s;
        Int32 a = obj.save_rec(objprp);
        if (s != " ")
        {
            FileUpload1.PostedFile.SaveAs(Server.MapPath("../advpics") + "//" + a.ToString() + s);

        }
        TextBox1.Text = string.Empty;
        Bind();

    }

}
