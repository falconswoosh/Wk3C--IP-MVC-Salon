using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Salon.Models
{
  public class Stylist
  {
    //stylist info Eq
    private string sLastName {get; private set;}
    private string sFirstName {get; private set;}
    private int sId {get; private set;}


    public Stylist(string sLastName, string sFirstName, int sId = 0)
    {
        sLastName = slastname;
        sFirstName = sfirstname;
        sId = sid;
    }

    public override bool Equals(System.Object OtherStylist)
    {
      if (!(OtherStylist is Stylist))
      {
        return false;
      }
      else
      {
        Stylist newSalon = (Stylist) otherStylist;
        bool idEquality = (this.GetSId == newStylist.GetSId);
        bool slastnameEquality = (this.GetsLastName == newStylist.GetsLastName);
        bool sfirstnameEquality = (this.GetsFirstName == newStylist.GetsFirstName;
        return (sidEquality && slastnameEquality && sfirstnameEquality);
      }
    }
    public override int GetHashCode()
    {
        return this.sId.GetHashCode();
    }

//ADD:  ClientID here

    public void Save()
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"INSERT INTO stylists (slastname, sfirstname) VALUES (@slastname, @sfirstname);";

        MySqlParameter slastname = new MySqlParameter();
        slastname.ParameterName = "@slastname";
        slastname.Value = this.sLastName;
        cmd.Parameters.Add(slastname);

        MySqlParameter sfirstname = new MySqlParameter();
        sfirstname.ParameterName = "@sfirstname";
        sfirstname.Value = sFirstName;
        cmd.Parameters.Add(sfirstname);

        cmd.ExecuteNonQuery();
        sId = (int) cmd.LastInsertedsId;
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
    }
    public static List<Stylist> GetAll()
    {
      List<Stylist> aStylist = new List<Stylist>();

      MySqlConnection conn = DB.Connection();
      conn.Open();
      MySqlCommand cmd = conn.CreateCommand();
      cmd.CommandText = @"SELECT * FROM stylists;";
      MySqlDataReader rdr = cmd.ExecuteReader();
      while(rdr.Read())
      {
        int stylistId = rdr.GetInt32(0);
        string stylistLastName = rdr.GetString(1);
        string stylistFirstName = rdr.GetString(2);
        Stylist newStylist = new Stylist(stylistLastName, stylistFirstName, stylistId);
        aStylist.Add(newStylist);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return aStylist;
    }
    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM stylists; ALTER TABLE stylists AUTO_INCREMENT = 1;";
      cmd.ExecuteNonQuery();

      conn.Close();
      if (conn != null)
      {
        conn.Dispose();
      }
    }
    public static void Delete(int searchId = 0)
    {
      if (searchId > 0)
      {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = @"DELETE FROM stylists WHERE id = @thisId;";
        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
      }
      return;
    }
    public static Stylist Find(int searchId = 0)
    {
      if (searchId > 0)
      {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        MySqlCommand cmd = conn.CreateCommand();
        cmd.CommandText = @"SELECT * FROM stylists WHERE id = @thisId;";

        MySqlParameter thisId = new MySqlParameter();
        thisId.ParameterName = "@thisId";
        thisId.Value = searchId;
        cmd.Parameters.Add(thisId);

        string sLastName = "";
        string sFirstName = "";

        var rdr = cmd.ExecuteReader() as MySqlDataReader;
        while(rdr.Read())
        {
          searchId = rdr.GetInt32(0);
          sLastName = rdr.GetString(1);
          sFirstName = rdr.GetString(2);
        }

        Stylist foundStylist = new Stylist(sLastName, sFirstName, searchId);

        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
        return foundStylist;
      }
      Stylist errorStylist = new Stylist("Error","Error",0);
      return errorStylist;
    }

    public void Update(string slastname="", string sfirstname="")
    {
      if(!String.IsNullOrEmpty(slastname))
      {this.sLastName = slastname;}
      if(!String.IsNullOrEmpty(sfirstname))
      {this.sFirstName = sfirstname;}

      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand();
      cmd.CommandText = @"SET @slastname, @sfirstname FROM stylists WHERE id = @thisId;";

      MySqlParameter thisLastName = new MySqlParameter();
      thisLastName.ParameterName = "@slastname";
      thisLastName.Value = this.sLastName;
      cmd.Parameters.Add(thisLastName);

      MySqlParameter thisFirstName = new MySqlParameter();
      thisFirstName.ParameterName = "@sfirstname";
      thisFirstName.Value = this.sFirstName;
      cmd.Parameters.Add(thisFirstName);

        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
      return;
    }

  }
}
