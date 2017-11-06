using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HairSalon.Models
{
  public class Stylist
  {

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
        lastname.Value = LastName;
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
      List<Stylist> allStylists = new List<Stylist> {};

      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM stylists;";
      var rdr = cmd.ExecuteReader() as MySqlDataReader;
      while(rdr.Read())
      {
        int stylistId = rdr.GetInt32(0);
        string stylistLastName = rdr.GetString(1);
        string stylistFirstName = rdr.GetString(2);
        Stylist newStylist = new Stylist(stylistLastName, stylistFirstName, stylistId);
        allStylists.Add(newStylist);
      }

    //   cmd.ExecuteNonQuery();
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allStylists;
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
    public static void Delete(int id = 0)
    {
      if (id > 0)
      {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"DELETE FROM stylists WHERE id = @searchId;";
        cmd.ExecuteNonQuery();

        MySqlParameter searchId = new MySqlParameter();
        searchId.ParameterName = "@searchId";
        searchId.Value = id;
        cmd.Parameters.Add(searchId);

        var rdr = cmd.ExecuteNonQuery();
        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
      }
      return;
    }
    public static Stylist Find(int id = 0)
    {
      if (id > 0)
      {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM stylists WHERE id = @searchId;";
        cmd.ExecuteNonQuery();

        MySqlParameter searchId = new MySqlParameter();
        searchId.ParameterName = "@searchId";
        searchId.Value = id;
        cmd.Parameters.Add(searchId);

        var rdr = cmd.ExecuteReader() as MySqlDataReader;
        string LastName = "";
        string FirstName = "";

        while(rdr.Read())
        {
          id = rdr.GetInt32(0);
          LastName = rdr.GetString(1);
          FirstName = rdr.GetString(2);
        }

        Stylist foundStylist = new Stylist(LastName, FirstName, id);

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

    public void UpdateStylist(int id, string lastname, string firstname)
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;

        cmd.CommandText = @"UPDATE stylists SET lastname = @newLastName, firstname = @newFirstName WHERE id = @searchId;";

        MySqlParameter searchId = new MySqlParameter();
        searchId.ParameterName = "@searchId";
        searchId.Value = id;
        cmd.Parameters.Add(searchId);

        MySqlParameter newLastName = new MySqlParameter();
        newLastName.ParameterName = "@newLastName";
        newLastName.Value = lastname;
        cmd.Parameters.Add(newLastName);

        MySqlParameter newFirstName = new MySqlParameter();
        newFirstName.ParameterName = "@newFirstName";
        newFirstName.Value = firstname;
        cmd.Parameters.Add(newFirstName);

        var rdr = cmd.ExecuteNonQuery();
        conn.Close();

        if (conn != null)
        {
          conn.Dispose();
        }
        return;
    }

  }
}
