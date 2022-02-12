using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;

public class lookUpPlantInfoFromDB : MonoBehaviour
{
    // name the db -> Plants
    // and set location of db
    private string dbName = "URI=file:Plants.db";
    public InputField iField;
    public Text latNameText;
    public RawImage plantImage;
    public Texture[] imageTextures = new Texture[3];

    /// <summary>
    /// Die Methode sucht - mit Hilfe des Inhalts des Inputfelds als Namen der Pflanzenart - in der Datenbank nach dem lateinischen Namen der Pflanze
    /// und schreibt diesen, wenn vorhanden in ein Textfeld.
    /// Außerdem werden die übergebenen Texturen anhand ihres Namens durchsucht. Entspricht der Text des Input-Feldes dem Namen einer Textur wird diese angezeigt.  
    /// </summary>
    public void lookUpPlantByName() {        
        //get use input plantname
        string userInput = iField.text;
        
        //look for plant image texture by plantname        
        foreach (Texture x in imageTextures)
        {
            if (x.name.Equals(userInput))
            {
                plantImage.texture = x;
            }
        }
            
        //create the db connection
        using (var connection = new SqliteConnection(dbName)) {
            connection.Open();
            // set up an object (called "command") to allow db control
            using (var command = connection.CreateCommand()) {
                //get generalInfo
                command.CommandText = "SELECT latName FROM publicPlants WHERE name='" + userInput + "';";
                using (IDataReader reader = command.ExecuteReader()) {
                    while (reader.Read()) {
                        latNameText.text = "" + reader["latName"];
                    }
                    reader.Close();
                }
            }
            connection.Close();
        }
    }
}