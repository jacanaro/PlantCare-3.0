using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Die Klasse enthält die nötigen GameObjects, sowie Funktionen, um die richtigen Optionen und Informationen eines Hilfedialogs anzeigen zu lassen.
/// </summary>
public class manageHilfedialog : MonoBehaviour
{
    public GameObject Fenster1;
    public GameObject Fenster21;
    public GameObject Fenster22;
    public GameObject Fenster23;
    public GameObject Fenster24;
    
    /// <summary>
    /// Die Methode zeigt die entsprechenden Informationen an, wenn der User die erste Option des Hilfedialogs wählt. 
    /// </summary>
    public void option1() {
        Fenster1.SetActive(false);
        Fenster21.SetActive(true);
    }
    /// <summary>
    /// Die Methode zeigt die entsprechenden Informationen an, wenn der User die zweite Option des Hilfedialogs wählt. 
    /// </summary>
    public void option2() {
        Fenster1.SetActive(false);
        Fenster22.SetActive(true);
    }
    /// <summary>
    /// Die Methode zeigt die entsprechenden Informationen an, wenn der User die dritte Option des Hilfedialogs wählt. 
    /// </summary>
    public void option3() {
        Fenster1.SetActive(false);
        Fenster23.SetActive(true);
    }
    /// <summary>
    /// Die Methode zeigt die entsprechenden Informationen an, wenn der User die vierte Option des Hilfedialogs wählt. 
    /// </summary>
    public void option4() {
        Fenster1.SetActive(false);
        Fenster24.SetActive(true);
    }

    /// <summary>
    /// Die Methode lädt das Pflanzenprofil, wenn die Startseite des Hilfedialogs aktiv ist.
    /// Wenn bereits eine der Optionen im Hilfedialog gewählt wurde, wird stattdessen die Startseite angezeigt.
    /// </summary>
    public void manageBackButton() {
        if (Fenster1.active) SceneManager.LoadScene("Pflanzenprofil");
        if (Fenster21.active || Fenster22.active || Fenster23.active || Fenster24.active) SceneManager.LoadScene("Hilfedialog");
    }

    /// <summary>
    /// Die Methode lößt den vierten Erfolg aus, falls dies noch nicht geschehen ist,
    /// setzt den Playerpref "gesundheit" auf "gut" und kehrt dann zum Pflanzenprofil zurück.
    /// </summary>
    public void setHappySmileyAndReturnToProfile() {
        Script_Erfolge.erf4Count++;
        PlayerPrefs.SetString("gesundheit", "gut");
        SceneManager.LoadScene("Pflanzenprofil");
    }
}