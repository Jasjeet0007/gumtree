<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        Application["ctr"] = 0;
        Application["ctr1"] = 0;

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["ctr"] = Convert.ToInt32(Application["ctr"]) + 1;
        Application["ctr1"] = Convert.ToInt32(Application["ctr1"]) + 1;
        Application.UnLock();
      
    }

    void Session_End(object sender, EventArgs e) 
    {
        Application.Lock();
        Application["ctr1"] = Convert.ToInt32(Application["ctr1"]) - 1;
        Application.UnLock();
    }
       
</script>
