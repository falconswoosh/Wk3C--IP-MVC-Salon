using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Salon.Models
{
  public class Stylist
  {
    //stylist info
    private string _sLastName;
    private string _sFirstName;
    private int _sId


    public Stylist(string sLastName, string sFirstName, int sId = 0)
    {
        _sLastName = sLastName;
        _sFirstName = sFirstName;
        _sId = sId;
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
        bool idEquality = this.GetSId() == newStylist.GetSId();
        bool sLastNameEquality = this.GetsLastName() == newStylist.GetsLastName();
        bool sFirstNameEquality = this.GetsFirstName() == newStylist.GetsFirstName();
        return (sidEquality && slastNameEquality && sFirstNameEquality);
      }
    }
    public override int GetHashCode()
    {
        return this.GetsLastName().GetHashCode();
    }
    public string GetsLastName()
    {
        return _sLastName;
    }
    public string GetsFirstName()
    {
        return sFirstName;
    }
    public int GetSId()
    {
        return _sId;
    }
//ADD:  ClientID here

    public void Save()
    {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"INSERT INTO stylists (sLastName, sFirstName) VALUES (@sLastName, @sFirstName);";

        MySqlParameter description = new MySqlParameter();
        description.ParameterName = "@sLastName";
        sLastName.Value = this._sLastName;
        cmd.Parameters.Add(sLastName);

        MySqlParameter sFirstName = new MySqlParameter();
        dueDate.ParameterName = "@sFirstName";
        sFirstName.Value = this._sFirstName;
        cmd.Parameters.Add(sFirstName);

        cmd.ExecuteNonQuery();
        _sId = (int) cmd.LastInsertedsId;
        conn.Close();
        if (conn != null)
        {
            conn.Dispose();
        }
    }

    // public static NewSalon
    //
    //     Salon newSalon = new Salon(SalonSLastName, SalonSFirstName, SalonId);
    //
    //     return false;

    // public static void ClearAll()
    //   {
    //     MySqlConnection conn = DB.Connection();
    //     conn.Open();
    //
    //     var cmd = conn.CreateCommand() as MySqlCommand;
    //     cmd.CommandText = @"DELETE FROM _database;";
    //     cmd.ExecuteNonQuery();
    //
    //     conn.Close();
    //     if (conn != null)
    //     {
    //       conn.Dispose();
    //     }
    //   }
  }
}
