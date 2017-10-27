using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Salon.Models
{
  public class Salon
  {
    //stylist info
    private string _stylistLastName;
    private string _stylistFirstName;
    private int _id


    public Salon(string stylistLastName, string stylistFirstName, int id = 0)
    {
        _stylistLastName = stylistLastName;
        _stylistFirstName = stylistFirstName;
        _id = id;
    }

    public override bool Equals(System.Object OtherSalon)
    {
      if (!(OtherSalon is Salon))
      {
        return false;
      }
      else
      {
        Salon newSalon = (Salon) other Salon;
        bool idEquality = this.GetId() == newSalon.GetId();
        bool stylistLastNameEquality = this.GetStylistLastName() == newSalon.GetStylistLastName();
        bool stylistFirstNameEquality = this.GetStylistFirstName() == newSalon.GetStylistFirstName();
      }
    }
    public override int GetHashCode()
    {
        return this.GetStylistLastName().GetHashCode();
    }





    public static void ClearAll()
      {
        MySqlConnection conn = DB.Connection();
        conn.Open();

        var cmd = conn.CreateCommand() as MySqlCommand;
        cmd.CommandText = @"DELETE FROM _database;";
        cmd.ExecuteNonQuery();

        conn.Close();
        if (conn != null)
        {
          conn.Dispose();
        }
      }
  }
}
