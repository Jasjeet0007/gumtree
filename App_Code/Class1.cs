using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;


namespace nsgumtree
{
    public interface intcnt
    {
        Int32 cntcod
        {
            get;
            set;
        }
        string cntnam
        {
            get;
            set;
        }
    }
    public interface intloc
    {
        Int32 loccod
        {
            get;
            set;
        }
        string locnam
        {
            get;
            set;
        }
        Int32 loccntcod
        {
            get;
            set;
        }
    }
    public interface intcat
    {
        Int32 catcod
        {
            get;
            set;
        }
        string catnam
        {
            get;
            set;
        }
    }
    public interface intsubcat
    {
        Int32 subcatcod
        {
            get;
            set;
        }
        string subcatnam
        {
            get;
            set;
        }
        Int32 subcatcatcod
        {
            get;
            set;
        }
    }
    public interface intitmtype
    {
        Int32 itmtypcod
        {
            get;
            set;
        }
        string itmtypnam
        {
            get;
            set;
        }
        Int32 itmsubcatcod
        {
            get;
            set;
        }

    }
    public interface intusr
    {
        Int32 usrcod
        {
            get;
            set;
        }
        string usrnam
        {
            get;
            set;
        }
        string usreml
        {
            get;
            set;
        }
        string usrpwd
        {
            get;
            set;
        }
        Int32 usrloccod
        {
            get;
            set;
        }
        string usrphn
        {
            get;
            set;
        }
        DateTime usrregdat
        {
            get;
            set;
        }
        char usrrol
        {
            get;
            set;
        }
        int usrpln
        {
            get;
            set;
        }
    }
    public interface intadv
    {
        Int32 advcod
        {
            get;
            set;
        }
        DateTime advdat
        {
            get;
            set;
        }
        Int32 advusrcod
        {
            get;
            set;
        }
        string advtit
        {
            get;
            set;
        }
        string advdsc
        {
            get;
            set;
        }
        float advprc
        {
            get;
            set;
        }
        Int32 advitmtypcod
        {
            get;
            set;
        }
        Int32 advmanpiccod
        {
            get;
            set;
        }
        char advsts
        {
            get;
            set;
        }
        Int32 advplncod
        {
            get;
            set;
        }
    }
    public interface intadvpic
    {
        Int32 advpiccod
        {
            get;
            set;
        }
        Int32 advpicadvcod
        {
            get;
            set;
        }
        string advpicpic
        {
            get;
            set;
        }
        string advpicdsc
        {
            get;
            set;
        }
        char advpicsts
        {
            get;
            set;
        }
    }
    public interface intpln
    {
        Int32 plncod
        {
            get;
            set;
        }
        Int32 plnsubcatcod
        {
            get;
            set;
        }
        float plncst
        {
            get;
            set;
        }
    }
    public interface intfavadv
    {
        Int32 favadvcod
        {
            get;
            set;
        }
        Int32 favadvadvcod
        {
            get;
            set;
        }
        Int32 favadvusrcod
        {
            get;
            set;
        }
        DateTime favadvdat
        {
            get;
            set;
        }
    }
    public interface intmsg
    {
        Int32 msgcod
        {
            get;
            set;
        }
        DateTime msgdat
        {
            get;
            set;
        }
        Int32 msgusrcod
        {
            get;
            set;
        }
        Int32 msgadvcod
        {
            get;
            set;
        }
        string msgdsc
        {
            get;
            set;
        }
    }

        


    public class clscntprp : intcnt
    {
        private Int32 prvcntcod;
        private string prvcntnam;
        public int cntcod
        {
            get
            {
                return prvcntcod;
            }
            set
            {
                prvcntcod = value;
            }
        }

        public string cntnam
        {
            get
            {
                return prvcntnam;
            }
            set
            {
                prvcntnam = value;
            }
        }
    }
    public class clslocprp:intloc
    {
        private Int32 prvloccod;
        private string prvlocnam;
        private Int32 prvloccntcod;
        public int loccod
        {
            get
            {
                return prvloccod;
            }
            set
            {
                prvloccod=value;
            }
        }
        public string locnam
        {
            get
            {
                return prvlocnam;
            }
            set
            {
                prvlocnam = value;
            }
         }
        public int loccntcod
        {
            get
            {
                return prvloccntcod;
            }
            set
            {
                prvloccntcod = value;
            }
        }
        }
    public class clscatprp :intcat
    {
        private Int32 prvcatcod;
        private string prvcatnam;
        public int catcod
        {
            get
            {
                return prvcatcod;
            }
            set
            {
                prvcatcod = value;
            }
        }
        public string catnam
        {
            get
            {
                return prvcatnam;
            }
            set
            {
                prvcatnam = value;
            }
        }
    }
    public class clssubcatprp : intsubcat
    {
        private Int32 prvsubcatcod;
        private string prvsubcatnam;
        private Int32 prvsubcatcatcod;
        public int subcatcod
        {
            get
            {
                return prvsubcatcod;
            }
            set
            {
                prvsubcatcod = value;
            }
        }
        public string subcatnam
        {
            get
            {
                return prvsubcatnam;
            }
            set
            {
                prvsubcatnam = value;
            }
        }
        public int subcatcatcod
        {
            get
            {
                return prvsubcatcatcod;
            }
            set
            {
                prvsubcatcatcod = value;
            }
        }
    }
    public class clsitmtypeprp : intitmtype
    {
        private Int32 prvitmtypcod;
        private string prvitmtypnam;
        private Int32 prvitmsubcatcod;
        public int itmtypcod
        {
            get
            {
                return prvitmtypcod;
            }
            set
            {
                prvitmtypcod = value;
            }
        }
        public string itmtypnam
        {
            get
            {
                return prvitmtypnam;
            }
            set
            {
                prvitmtypnam = value;
            }
        }
        public int itmsubcatcod
        {
            get
            {
                return prvitmsubcatcod;
            }
            set
            {
                prvitmsubcatcod = value;
            }
        }
    }
    public class clsusrprp : intusr
    {
        private Int32 prvusrcod;
        private string prvusrnam;
        private string prvusreml;
        private string prvusrpwd;
        private Int32 prvusrloccod;
        private string prvusrphn;
        private DateTime prvusrregdat;
        private char prvusrrol;
        private int prvusrpln;
        public int usrcod
        {
            get
            {
                return prvusrcod;
            }
            set
            {
                prvusrcod = value;
            }
        }
        public string usrnam
        {
            get
            {
                return prvusrnam;
            }
            set
            {
                prvusrnam = value;
            }
        }
        public string usreml
        {
            get
            {
                return prvusreml;
            }
            set
            {
                prvusreml = value;
            }
        }
        public string usrpwd
        {
            get
            {
                return prvusrpwd;
            }
            set
            {
                prvusrpwd = value;
            }
        }
        public int usrloccod
        {
            get
            {
                return prvusrloccod;
            }
            set
            {
                prvusrloccod = value;
            }
        }
        public string usrphn
        {
            get
            {
                return prvusrphn;
            }
            set
            {
                prvusrphn = value;
            }
        }
        public DateTime usrregdat
        {
            get
            {
                return prvusrregdat;
            }
            set
            {
                prvusrregdat = value;
            }
        }
        public char usrrol
        {
            get
            {
                return prvusrrol;
            }
            set
            {
                prvusrrol = value;
            }

        }
        public int usrpln
        {
            get
            {
                return prvusrpln;
            }
            set
            {
                prvusrpln = value;
            }

        }
    }
    public class clsadvprp : intadv
    {
        private Int32 prvadvcod;
        private DateTime prvadvdat;
        private Int32 prvadvusrcod;
        private string prvadvtit;
        private string prvadvdsc;
        private float prvadvprc;
        private Int32 prvadvitmtypcod;
        private Int32 prvadvmanpiccod;
        private char prvadvsts;
        private Int32 prvadvplncod;
        public int advcod
        {
            get
            {
                return prvadvcod;
            }
            set
            {
                prvadvcod = value;
            }
        }
        public DateTime advdat
        {
            get
            {
                return prvadvdat;
            }
            set
            {
                prvadvdat = value;
            }
        }
        public int advusrcod
        {
            get
            {
                return prvadvusrcod;
            }
            set
            {
                prvadvusrcod = value;
            }
        }
        public string advtit
        {
            get
            {
                return prvadvtit;
            }
            set
            {
                prvadvtit = value;
            }
        }
        public string advdsc
        {
            get
            {
                return prvadvdsc;
            }
            set
            {
                prvadvdsc = value;
            }
        }
        public float advprc
        {
            get
            {
                return prvadvprc;
            }
            set
            {
                prvadvprc = value;
            }
        }
        public int advitmtypcod
        {
            get
            {
                return prvadvitmtypcod;
            }
            set
            {
                prvadvitmtypcod = value;
            }
        }
        public int advmanpiccod
        {
            get
            {
                return prvadvmanpiccod;
            }
            set
            {
                prvadvmanpiccod = value;
            }
        }
        public char advsts
        {
            get
            {
                return prvadvsts;
            }
            set
            {
                prvadvsts = value;
            }
        }
        public int advplncod
        {
            get
            {
                return prvadvplncod;
            }
            set
            {
                prvadvplncod = value;
            }
        }
    }
    public class clsadvpicprp : intadvpic
    {
        private Int32 prvadvpiccod;
        private Int32 prvadvpicadvcod;
        private string prvadvpicpic;
        private string prvadvpicdsc;
        private char prvadvpicsts;
        public int advpiccod
        {
            get
            {
                return prvadvpiccod;
            }
            set
            {
                prvadvpiccod = value;
            }
        }
        public int advpicadvcod
        {
            get
            {
                return prvadvpicadvcod;
            }
            set
            {
                prvadvpicadvcod = value;
            }
        }
        public string advpicpic
        {
            get
            {
                return prvadvpicpic;
            }
            set
            {
                prvadvpicpic = value;
            }
        }
        public string advpicdsc
        {
            get
            {
                return prvadvpicdsc;
            }
            set
            {
                prvadvpicdsc = value;
            }
        }
        public char advpicsts
        {
            get
            {
                return prvadvpicsts;
            }
            set
            {
                prvadvpicsts = value;
            }
        }
    }
    public class clsplnprp : intpln
    {
        private Int32 prvplncod;
        private Int32 prvplnsubcatcod;
        private float prvplncst;
        public int plncod
        {
            get
            {
                return prvplncod;
            }
            set
            {
                prvplncod = value;
            }
        }
        public int plnsubcatcod
        {
            get
            {
                return prvplnsubcatcod;
            }
            set
            {
                prvplnsubcatcod = value;
            }
        }
        public float plncst
        {
            get
            {
                return prvplncst;
            }
            set
            {
                prvplncst = value;
            }
        }
    }
    public class clsfavadvprp : intfavadv
    {
        private Int32 prvfavadvcod;
        private Int32 prvfavadvadvcod;
        private Int32 prvfavadvusrcod;
        private DateTime prvfavadvdat;
        public int favadvcod
        {
            get
            {
                return prvfavadvcod;
            }
            set
            {
                prvfavadvcod = value;
            }
        }
        public int favadvadvcod
        {
            get
            {
                return prvfavadvadvcod;
            }
            set
            {
                prvfavadvadvcod = value;
            }
        }
        public int favadvusrcod
        {
            get
            {
                return prvfavadvusrcod;
            }
            set
            {
                prvfavadvusrcod = value;
            }
        }
        public DateTime favadvdat
        {
            get
            {
                return prvfavadvdat;
            }
            set
            {
                prvfavadvdat = value;
            }
        }
    }
    public class clsmsgprp : intmsg
    {
        private Int32 prvmsgcod;
        private DateTime prvmsgdat;
        private Int32 prvmsgusrcod;
        private Int32 prvmsgadvcod;
        private string prvmsgdsc;
        public int msgcod
        {
            get
            {
                return prvmsgcod;
            }
            set
            {
                prvmsgcod = value;
            }
        }
        public DateTime msgdat
        {
            get
            {
                return prvmsgdat;
            }
            set
            {
                prvmsgdat = value;
            }
        }
        public int msgusrcod
        {
            get
            {
                return prvmsgusrcod;
            }
            set
            {
                prvmsgusrcod = value;
            }
        }
        public int msgadvcod
        {
            get
            {
                return prvmsgadvcod;
            }
            set
            {
                prvmsgadvcod = value;
            }
        }
        public string msgdsc
        {
            get
            {
                return prvmsgdsc;
            }
            set
            {
                prvmsgdsc = value;
            }
        }
    }



    public abstract class clscon
    {
        protected SqlConnection con = new SqlConnection();
        public clscon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
        }
    }
    public class clscnt : clscon
    {
        public void save_rec(clscntprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("inscnt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@cntcod", SqlDbType.Int).Value = p.cntcod;
            cmd.Parameters.Add("@cntnam", SqlDbType.VarChar, 50).Value = p.cntnam;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clscntprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcnt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cntcod", SqlDbType.Int).Value = p.cntcod;
            cmd.Parameters.Add("@cntnam", SqlDbType.VarChar, 50).Value = p.cntnam;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clscntprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcnt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cntcod", SqlDbType.Int).Value = p.cntcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clscntprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispcnt", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clscntprp> obj = new List<clscntprp>();
                while (dr.Read())
                {
                    clscntprp k = new clscntprp();
                    k.cntcod = Convert.ToInt32(dr[0]);
                    k.cntnam = dr[1].ToString();
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clscntprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findcnt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cntcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clscntprp> obj = new List<clscntprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clscntprp k = new clscntprp();
                k.cntcod = Convert.ToInt32(dr[0]);
                k.cntnam = dr[1].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clsloc : clscon
    {
        public void save_rec(clslocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insloc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@locnam", SqlDbType.VarChar, 100).Value = p.locnam;
            cmd.Parameters.Add("@loccntcod", SqlDbType.Int).Value = p.loccntcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clslocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updloc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@locnam", SqlDbType.VarChar, 100).Value = p.locnam;
            cmd.Parameters.Add("@loccntcod", SqlDbType.Int).Value = p.loccntcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clslocprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delloc", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clslocprp> disp_rec(Int32 cntcod)
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("disploc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cntcod", SqlDbType.Int).Value = cntcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clslocprp> obj = new List<clslocprp>();
                while (dr.Read())
                {
                    clslocprp k = new clslocprp();
                    k.loccod = Convert.ToInt32(dr[0]);
                    k.locnam = dr[1].ToString();
                    k.loccntcod = Convert.ToInt32(dr[2]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clslocprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findloc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clslocprp> obj = new List<clslocprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clslocprp k = new clslocprp();
                k.loccod = Convert.ToInt32(dr[0]);
                k.locnam = dr[1].ToString();
                k.loccntcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clscat : clscon
    {
        public void save_rec(clscatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("inscat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@catnam", SqlDbType.VarChar, 100).Value = p.catnam;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clscatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
    
           cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = p.catcod;
            cmd.Parameters.Add("@catnam", SqlDbType.VarChar, 100).Value = p.catnam;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clscatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delcat", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = p.catcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clscatprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispcat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clscatprp> obj = new List<clscatprp>();
                while (dr.Read())
                {
                    clscatprp k = new clscatprp();
                    k.catcod = Convert.ToInt32(dr[0]);
                    k.catnam = dr[1].ToString();
                   // k.loccntcod = Convert.ToInt32(dr[2]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clscatprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clscatprp> obj = new List<clscatprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clscatprp k = new clscatprp();
            //    k.catcod = Convert.ToInt32(dr[0]);
                k.catnam = dr[1].ToString();
              //  k.loccntcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clssubcat : clscon
    {
        public void save_rec(clssubcatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("inssubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //  cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@subcatnam", SqlDbType.VarChar, 100).Value = p.subcatnam;
             cmd.Parameters.Add("@subcatcatcod", SqlDbType.Int).Value = p.subcatcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clssubcatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = p.subcatcod;
            cmd.Parameters.Add("@subcatnam", SqlDbType.VarChar, 100).Value = p.subcatnam;
            cmd.Parameters.Add("@subcatcatcod", SqlDbType.Int).Value = p.subcatcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clssubcatprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = p.subcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clssubcatprp> disp_rec(Int32 catcod)
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispsubcat", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@catcod", SqlDbType.Int).Value = catcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clssubcatprp> obj = new List<clssubcatprp>();
                while (dr.Read())
                {
                    clssubcatprp k = new clssubcatprp();
                    k.subcatcod = Convert.ToInt32(dr[0]);
                    k.subcatnam = dr[1].ToString();
                    k.subcatcatcod = Convert.ToInt32(dr[2]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clssubcatprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findsubcat", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clssubcatprp> obj = new List<clssubcatprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clssubcatprp k = new clssubcatprp();
                k.subcatcod = Convert.ToInt32(dr[0]);
                k.subcatnam = dr[1].ToString();
                k.subcatcatcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clsitmtype : clscon
    {
        public void save_rec(clsitmtypeprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insitmtype", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@itmtypnam", SqlDbType.VarChar, 100).Value = p.itmtypnam;
            cmd.Parameters.Add("@itmsubcatcod", SqlDbType.Int).Value = p.itmsubcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsitmtypeprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("upditmtype", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@itmtypcod", SqlDbType.Int).Value = p.itmtypcod;
            cmd.Parameters.Add("@itmtypnam", SqlDbType.VarChar, 100).Value = p.itmtypnam;
            cmd.Parameters.Add("@itmsubcatcod", SqlDbType.Int).Value = p.itmsubcatcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsitmtypeprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delitmtyp", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@itmtypcod", SqlDbType.Int).Value = p.itmtypcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsitmtypeprp> disp_rec(Int32 subcatcod)
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispitmtype", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@subcatcod", SqlDbType.Int).Value = subcatcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsitmtypeprp> obj = new List<clsitmtypeprp>();
                while (dr.Read())
                {
                    clsitmtypeprp k = new clsitmtypeprp();
                    k.itmtypcod = Convert.ToInt32(dr[0]);
                    k.itmtypnam = dr[1].ToString();
                    k.itmsubcatcod = Convert.ToInt32(dr[2]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsitmtypeprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("finditmtype", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@itmtypcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsitmtypeprp> obj = new List<clsitmtypeprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsitmtypeprp k = new clsitmtypeprp();
                k.itmtypcod = Convert.ToInt32(dr[0]);
                k.itmtypnam = dr[1].ToString();
                k.itmsubcatcod = Convert.ToInt32(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clsusr:clscon
    {
        public Int32 logincheck(string eml, string pwd, out char rol)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = new SqlCommand("logincheck", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@eml", SqlDbType.VarChar, 50).Value = eml;
            cmd.Parameters.Add("@pwd", SqlDbType.VarChar, 50).Value = pwd;
            cmd.Parameters.Add("@cod", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@rol", SqlDbType.Char, 1).Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@cod"].Value);
            rol = Convert.ToChar(cmd.Parameters["@rol"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void save_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@usrnam", SqlDbType.VarChar, 100).Value = p.usrnam;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 50).Value = p.usreml;
             cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 50).Value = p.usrpwd;
            cmd.Parameters.Add("@usrloccod", SqlDbType.Int).Value = p.usrloccod;
             cmd.Parameters.Add("@usrphn", SqlDbType.VarChar, 50).Value = p.usrphn;
             cmd.Parameters.Add("@usrregdat", SqlDbType.DateTime).Value=p.usrregdat;
             cmd.Parameters.Add("@usrrol", SqlDbType.Char,1).Value = p.usrrol;
          //   cmd.Parameters.Add("@usrpln", SqlDbType.Int).Value = p.usrpln;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("usrcod",SqlDbType.Int).Value=p.usrcod;
             cmd.Parameters.Add("@usrnam", SqlDbType.VarChar, 100).Value = p.usrnam;
            cmd.Parameters.Add("@usreml", SqlDbType.VarChar, 50).Value = p.usreml;
             cmd.Parameters.Add("@usrpwd", SqlDbType.VarChar, 50).Value = p.usrpwd;
            cmd.Parameters.Add("@usrloccod", SqlDbType.Int).Value = p.usrloccod;
             cmd.Parameters.Add("@usrphn", SqlDbType.VarChar, 50).Value = p.usrphn;
             cmd.Parameters.Add("@usrregdat", SqlDbType.DateTime).Value=p.usrregdat;
             cmd.Parameters.Add("@usrrol", SqlDbType.Char,1).Value = p.usrrol;
         //    cmd.Parameters.Add("@usrpln", SqlDbType.Int).Value = p.usrpln;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsusrprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.Add("usrcod",SqlDbType.Int).Value=p.usrcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsusrprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispusr", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsusrprp> obj = new List<clsusrprp>();
                while (dr.Read())
                {
                    clsusrprp k = new clsusrprp();
                    k.usrcod = Convert.ToInt32(dr[0]);
                    k.usrnam = dr[1].ToString();
                     k.usreml = dr[2].ToString();
                     k.usrpwd = dr[3].ToString();
                    k.usrloccod = Convert.ToInt32(dr[4]);
                     k.usrphn = dr[5].ToString();
                    k.usrregdat=Convert.ToDateTime(dr[6]);
                    k.usrrol=Convert.ToChar(dr[7]);
                  //  k.usrpln = Convert.ToInt32(dr[8]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsusrprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findusr", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usrcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsusrprp> obj = new List<clsusrprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsusrprp k = new clsusrprp();
               k.usrcod = Convert.ToInt32(dr[0]);
                    k.usrnam = dr[1].ToString();
                     k.usreml = dr[2].ToString();
                     k.usrpwd = dr[3].ToString();
                    k.usrloccod = Convert.ToInt32(dr[4]);
                     k.usrphn = dr[5].ToString();
                    k.usrregdat=Convert.ToDateTime(dr[6]);
                    k.usrrol=Convert.ToChar(dr[7]);
                 //   k.usrpln = Convert.ToInt32(dr[8]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clsadv : clscon
    {
        public Int32 save_rec(clsadvprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.Add("@loccod", SqlDbType.Int).Value = p.loccod;
            cmd.Parameters.Add("@advdat", SqlDbType.DateTime).Value = p.advdat;
            cmd.Parameters.Add("@advusrcod", SqlDbType.Int).Value = p.advusrcod;
            cmd.Parameters.Add("@advtit", SqlDbType.VarChar, 200).Value = p.advtit;
            cmd.Parameters.Add("@advdsc", SqlDbType.NVarChar, 20000).Value = p.advdsc;
            cmd.Parameters.Add("@advprc", SqlDbType.Float).Value = p.advprc;
            cmd.Parameters.Add("@advitmtypcod", SqlDbType.Int).Value = p.advitmtypcod;
          //  cmd.Parameters.Add("@advmanpiccod", SqlDbType.Int).Value = p.advmanpiccod;
            cmd.Parameters.Add("@advsts", SqlDbType.Char, 1).Value = p.advsts;
          //  cmd.Parameters.Add("@advplncod", SqlDbType.Int).Value = p.advplncod;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            Int32 a=Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clsadvprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advcod", SqlDbType.Int).Value = p.advcod;
            cmd.Parameters.Add("@advdat", SqlDbType.DateTime).Value = p.advdat;
            cmd.Parameters.Add("@advusrcod", SqlDbType.Int).Value = p.advusrcod;
            cmd.Parameters.Add("@advtit", SqlDbType.VarChar, 200).Value = p.advtit;
            cmd.Parameters.Add("@advdsc", SqlDbType.NVarChar, 20000).Value = p.advdsc;
            cmd.Parameters.Add("@advprc", SqlDbType.Float).Value = p.advprc;
            cmd.Parameters.Add("@advitmtypcod", SqlDbType.Int).Value = p.advitmtypcod;
            //cmd.Parameters.Add("@advmanpiccod", SqlDbType.Int).Value = p.advmanpiccod;
            cmd.Parameters.Add("@advsts", SqlDbType.Char, 1).Value = p.advsts;
           // cmd.Parameters.Add("@advplncod", SqlDbType.Int).Value = p.advplncod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsadvprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("deladv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advcod", SqlDbType.Int).Value = p.advcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsadvprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispadv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsadvprp> obj = new List<clsadvprp>();
                while (dr.Read())
                {
                    clsadvprp k = new clsadvprp();
                    k.advcod = Convert.ToInt32(dr[0]);
                    k.advdat = Convert.ToDateTime(dr[1]);
                    k.advusrcod = Convert.ToInt32(dr[2]);
                    k.advtit = dr[3].ToString();
                    k.advdsc = dr[4].ToString();
                    k.advprc = Convert.ToInt32(dr[5]);
                    k.advitmtypcod = Convert.ToInt32(dr[6]);
             //       k.advmanpiccod = Convert.ToInt32(dr[7]);
                    k.advsts = Convert.ToChar(dr[7]);
               //     k.advplncod = Convert.ToInt32(dr[9]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsadvprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsadvprp> obj = new List<clsadvprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsadvprp k = new clsadvprp();
                k.advcod = Convert.ToInt32(dr[0]);
                k.advdat = Convert.ToDateTime(dr[1]);
                k.advusrcod = Convert.ToInt32(dr[2]);
                k.advtit = dr[3].ToString();
                k.advdsc = dr[4].ToString();
                k.advprc = Convert.ToInt32(dr[5]);
                k.advitmtypcod = Convert.ToInt32(dr[6]);
             //   k.advmanpiccod = Convert.ToInt32(dr[7]);
                k.advsts = Convert.ToChar(dr[7]);
               // k.advplncod = Convert.ToInt32(dr[9]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clsadvpic:clscon
    {
        public Int32 save_rec(clsadvpicprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insadvpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advpicadvcod", SqlDbType.Int).Value = p.advpicadvcod;
            cmd.Parameters.Add("@advpicpic", SqlDbType.VarChar, 50).Value = p.advpicpic;
            cmd.Parameters.Add("@advpicdsc", SqlDbType.VarChar, 1000).Value = p.advpicdsc;
            cmd.Parameters.Add("@advpicsts", SqlDbType.Char).Value = p.advpicsts;
            cmd.Parameters.Add("@r", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            Int32 a = Convert.ToInt32(cmd.Parameters["@r"].Value);
            cmd.Dispose();
            con.Close();
            return a;
        }
        public void update_rec(clsadvpicprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updadvpic",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advpiccod", SqlDbType.Int).Value = p.advpiccod;
            cmd.Parameters.Add("@advpicadvcod", SqlDbType.Int).Value = p.advpicadvcod;
            cmd.Parameters.Add("@advpicpic", SqlDbType.VarChar, 50).Value = p.advpicpic;
            cmd.Parameters.Add("@advpicdsc", SqlDbType.VarChar, 1000).Value = p.advpicdsc;
            cmd.Parameters.Add("@advpicsts", SqlDbType.Char).Value = p.advpicsts;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsadvpicprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("deladvpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advpiccod", SqlDbType.Int).Value = p.advpiccod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsadvpicprp> disp_rec(Int32 advcod)
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispadvpic", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@advcod", SqlDbType.Int).Value = advcod;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsadvpicprp> obj = new List<clsadvpicprp>();
                while (dr.Read())
                {
                    clsadvpicprp k = new clsadvpicprp();
                    k.advpiccod = Convert.ToInt32(dr[0]);
                    k.advpicadvcod = Convert.ToInt32(dr[1]);
                    k.advpicpic = dr[2].ToString();
                    k.advpicdsc = dr[3].ToString();
                    k.advpicsts = Convert.ToChar(dr[4]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsadvpicprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findadvpic", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@advpiccod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsadvpicprp> obj = new List<clsadvpicprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsadvpicprp k = new clsadvpicprp();
                k.advpiccod = Convert.ToInt32(dr[0]);
                k.advpicadvcod = Convert.ToInt32(dr[1]);
                k.advpicpic = dr[2].ToString();
                k.advpicdsc = dr[3].ToString();
                k.advpicsts = Convert.ToChar(dr[4]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clspln : clscon
    {
        public void save_rec(clsplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("inspln", con);
            cmd.CommandType = CommandType.StoredProcedure;
          //  cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = p.plncod;
           cmd.Parameters.Add("@plnsubcatcod", SqlDbType.Int).Value = p.plnsubcatcod;
            cmd.Parameters.Add("@plncst", SqlDbType.Float).Value = p.plncst;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updpln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = p.plncod;
            cmd.Parameters.Add("@plnsubcatcod", SqlDbType.Int).Value = p.plnsubcatcod;
            cmd.Parameters.Add("@plncst", SqlDbType.Float).Value = p.plncst;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsplnprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delpln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = p.plncod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
      /*  public List<clsplnprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("disppln", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsplnprp> obj = new List<clsplnprp>();
                while (dr.Read())
                {
                    clsplnprp k = new clsplnprp();
                    k.plncod = Convert.ToInt32(dr[0]);
                    k.plnsubcatcod = Convert.ToInt32(dr[1]);
                    k.plncst = Convert.ToSingle(dr[2]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }*/
        public List<clsplnprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findpln", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@plncod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsplnprp> obj = new List<clsplnprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsplnprp k = new clsplnprp();
                k.plncod = Convert.ToInt32(dr[0]);
                k.plnsubcatcod = Convert.ToInt32(dr[1]);
                k.plncst = Convert.ToSingle(dr[2]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }
        public DataSet disp_rec()
        {
            SqlDataAdapter adp = new SqlDataAdapter("disppln", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adp.Fill(ds);
            return ds;
        }
    }
    public class clsfavadv:clscon
    {
        public void save_rec(clsfavadvprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insfavadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
        //   cmd.Parameters.Add("@favadvcod", SqlDbType.Int).Value = p.favadvcod;
            cmd.Parameters.Add("@favadvadvcod", SqlDbType.Int).Value = p.favadvadvcod;
            cmd.Parameters.Add("@favadvusrcod", SqlDbType.Int).Value = p.favadvusrcod;
            cmd.Parameters.Add("@favadvdat", SqlDbType.DateTime).Value = p.favadvdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsfavadvprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updfavadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favadvcod", SqlDbType.Int).Value = p.favadvcod;
            cmd.Parameters.Add("@favadvadvcod", SqlDbType.Int).Value = p.favadvadvcod;
            cmd.Parameters.Add("@favadvusrcod", SqlDbType.Int).Value = p.favadvusrcod;
            cmd.Parameters.Add("@favadvdat", SqlDbType.DateTime).Value = p.favadvdat;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsfavadvprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delfavadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favadvcod", SqlDbType.Int).Value = p.favadvcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsfavadvprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispfavadv", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsfavadvprp> obj = new List<clsfavadvprp>();
                while (dr.Read())
                {
                    clsfavadvprp k = new clsfavadvprp();
                    k.favadvcod = Convert.ToInt32(dr[0]);
                    k.favadvadvcod = Convert.ToInt32(dr[1]);
                    k.favadvusrcod = Convert.ToInt32(dr[2]);
                    k.favadvdat = Convert.ToDateTime(dr[3]);
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsfavadvprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findfavadv", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@favadvcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsfavadvprp> obj = new List<clsfavadvprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsfavadvprp k = new clsfavadvprp();

                k.favadvcod = Convert.ToInt32(dr[0]);
                k.favadvadvcod = Convert.ToInt32(dr[1]);
                k.favadvusrcod = Convert.ToInt32(dr[2]);
                k.favadvdat = Convert.ToDateTime(dr[3]);
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }
    public class clsmsg:clscon
    {
        public void save_rec(clsmsgprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("insmsg", con);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.Add("@msgcod", SqlDbType.Int).Value = p.msgcod;
            cmd.Parameters.Add("@msgdat", SqlDbType.DateTime).Value = p.msgdat;
            cmd.Parameters.Add("@msgusrcod", SqlDbType.Int).Value = p.msgusrcod;
            cmd.Parameters.Add("@msgadvcod", SqlDbType.Int).Value = p.msgadvcod;
            cmd.Parameters.Add("@msgdsc", SqlDbType.VarChar, 2000).Value = p.msgdsc;
            
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void update_rec(clsmsgprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("updmsg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@msgcod", SqlDbType.Int).Value = p.msgcod;
            cmd.Parameters.Add("@msgdat", SqlDbType.DateTime).Value = p.msgdat;
            cmd.Parameters.Add("@msgusrcod", SqlDbType.Int).Value = p.msgusrcod;
            cmd.Parameters.Add("@msgadvcod", SqlDbType.Int).Value = p.msgadvcod;
            cmd.Parameters.Add("@msgdsc", SqlDbType.VarChar, 2000).Value = p.msgdsc;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public void delete_rec(clsmsgprp p)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("delmsg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@msgcod", SqlDbType.Int).Value = p.msgcod;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        public List<clsmsgprp> disp_rec()
        {

            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("dispmsg", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                List<clsmsgprp> obj = new List<clsmsgprp>();
                while (dr.Read())
                {
                    clsmsgprp k = new clsmsgprp();
                    k.msgcod = Convert.ToInt32(dr[0]);
                    k.msgdat = Convert.ToDateTime(dr[1]);
                    k.msgusrcod = Convert.ToInt32(dr[2]);
                    k.msgadvcod = Convert.ToInt32(dr[3]);
                    k.msgdsc = dr[4].ToString();
                    obj.Add(k);
                }
                dr.Close();
                cmd.Dispose();
                con.Close();
                return obj;
            }
        }
        public List<clsmsgprp> find_rec(Int32 cno)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("findmsg", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@msgcod", SqlDbType.Int).Value = cno;
            SqlDataReader dr = cmd.ExecuteReader();

            List<clsmsgprp> obj = new List<clsmsgprp>();
            if (dr.HasRows)
            {
                dr.Read();
                clsmsgprp k = new clsmsgprp();

                k.msgcod = Convert.ToInt32(dr[0]);
                k.msgdat = Convert.ToDateTime(dr[1]);
                k.msgusrcod = Convert.ToInt32(dr[2]);
                k.msgadvcod = Convert.ToInt32(dr[3]);
                k.msgdsc = dr[4].ToString();
                obj.Add(k);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return obj;

        }

    }

}
        
