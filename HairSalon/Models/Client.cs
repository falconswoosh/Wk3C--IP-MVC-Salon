using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HairSalon.Models
{
  public class Client
  {

    public string LastName {get; private set;}
    public string FirstName {get; private set;}
    public int Id {get; private set;}

    public Client(string lastname, string firstname, int id = 0)
    {
        LastName = lastname;
        FirstName = firstname;
        Id = id;
    }

    public override bool Equals(System.Object otherClient)
    {
      if (!(otherClient is Client))
      {
        return false;
      }
      else
      {
        Client newClient = (Client) otherClient;
        bool idEquality = (this.Id == newClient.Id);
        bool lastnameEquality = (this.LastName == newClient.LastName);
        bool firstnameEquality = (this.FirstName == newClient.FirstName);
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
        cmd.CommandText = @"INSERT INTO clients (lastname, firstname) VALUES (@lastname, @firstname);";

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
    public static List<Client> GetAll()
    {
      List<Client> allClient = new List<Client>();

      MySqlConnection conn = DB.Connection();
      conn.Open();
      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"SELECT * FROM clients;";
      MySqlDataReader rdr = cmd.ExecuteReader();
      while(rdr.Read())
      {
        int Id = rdr.GetInt32(0);
        string LastName = rdr.GetString(1);
        string FirstName = rdr.GetString(2);
        Client newClient = new Client(LastName, FirstName, Id);
        allClient.Add(newClient);
      }
      conn.Close();
      if(conn != null)
      {
        conn.Dispose();
      }
      return allClient;
    }
    public static void ClearAll()
    {
      MySqlConnection conn = DB.Connection();
      conn.Open();

      var cmd = conn.CreateCommand() as MySqlCommand;
      cmd.CommandText = @"DELETE FROM clients; ALTER TABLE clients AUTO_INCREMENT = 1;";
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
        cmd.CommandText = @"DELETE FROM clients WHERE id = @searchId;";
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
    public static Client Find(int id = 0)
    {
      if (id > 0)
      {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"SELECT * FROM clients WHERE id = @searchId;";
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

        Client foundClient = new Client(LastName, FirstName, id);

        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
        return foundClient;
      }
      Client errorClient = new Client("Error","Error",0);
      return errorClient;
    }

    public void UpdateClient(int id, string lastname, string firstname)
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;

        cmd.CommandText = @"UPDATE clients SET lastname = @newLastName, firstname = @newFirstName WHERE id = @searchId;";

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
