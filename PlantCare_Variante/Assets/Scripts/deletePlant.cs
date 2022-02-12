using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public class deletePlant : MonoBehaviour
{
    private string dbName = "URI=file:Plants.db";
    [SerializeField] private GameObject DeleteCheck;
    [SerializeField] private GameObject DeleteBtn;

/// <summary>
/// Die Methode löscht das Pflanzenobjekt auf der Datenbank, mit der Pflanzen-ID die aktuell in den Playerprefs gespeichert ist.
/// </summary>
    public void deletePlantFromDB(){
        using (var connection = new SqliteConnection(dbName)) {
            connection.Open();

            // set up an object (called "command") to allow db control
            using (var command = connection.CreateCommand()) {
                command.CommandText = "DELETE FROM userPlants WHERE plantID='"+PlayerPrefs.GetInt("plantID") + "';";
                command.ExecuteNonQuery(); //runs sql command
            }
            connection.Close();
        }
        SceneManager.LoadScene("MeinePflanzen");
    }

/// <summary>
/// Die Methode setzt den Löschen-Button auf inaktiv und aktiviert den Löschen-Dialog. 
/// </summary>
    public void turnOnDeleteCheck(){
        DeleteBtn.SetActive(false);
        DeleteCheck.SetActive(true);
    }
/// <summary>
/// Die Methode setzt den Löschen-Dialog auf inaktiv und den Löschen-Button auf aktiv
/// </summary>
    public void dontDeletePlant(){
        DeleteBtn.SetActive(true);
        DeleteCheck.SetActive(false);
    }
}