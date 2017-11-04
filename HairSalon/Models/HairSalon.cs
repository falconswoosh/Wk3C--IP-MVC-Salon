using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HairSalon.Models
{
  public class Stylist
  {
    //stylist info Eq
    public string LastName {get; private set;}
    public string FirstName {get; private set;}
    public int Id {get; private set;}


    public Stylist(string lastname, string firstname, int id = 0)
    {
        LastName = lastname;
        FirstName = firstname;
        Id = id;
    }

    public override bool Equals(System.Object otherStylist)
    {
      if (!(otherStylist is Stylist))
      {
        return false;
      }
      else
      {
        Stylist newStylist = (Stylist) otherStylist;
        bool idEquality = (this.Id == newStylist.Id);
        bool lastnameEquality = (this.LastName == newStylist.LastName);
        bool firstnameEquality = (this.FirstName == newStylist.FirstName);
        return (idEquality && lastnameEquality && firstnameEquality);
      }
    }
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

//ADD:  ClientID here

    public void Save()
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"INSERT INTO stylists (lastname, firstname) VALUES (@lastname, @firstname);";

        MySqlParameter lastname = new MySqlParameter();
        lastname.ParameterName = "@lastname";
        lastname.Value = this.LastName;
        cmd.Parameters.Add(lastname);

        MySqlParameter firstname = new MySqlParameter();
        firstname.ParameterName = "@firstname";
        firstname.Value = FirstName;
        cmd.Parameters.Add(firstname);

        cmd.ExecuteNonQuery();
        Id = (int) cmd.LastInsertedId;

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

    public void Update(string lastname="", string firstname="")
    {
      if(!String.IsNullOrEmpty(lastname))
      {this.LastName = lastname;}
      if(!String.IsNullOrEmpty(firstname))
      {this.FirstName = firstname;}

      MySqlConnection conn = DB.Connection();
      conn.Open();

      MySqlCommand cmd = conn.CreateCommand();
      cmd.CommandText = @"SET @lastname, @firstname FROM stylists WHERE id = @thisId;";

      MySqlParameter thislastname = new MySqlParameter();
      thislastname.ParameterName = "@lastname";
      thislastname.Value = this.LastName;
      cmd.Parameters.Add(thislastname);

      MySqlParameter thisfirstname = new MySqlParameter();
      thisfirstname.ParameterName = "@firstname";
      thisfirstname.Value = this.FirstName;
      cmd.Parameters.Add(thisfirstname);

        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
      return;
    }

  }
}
