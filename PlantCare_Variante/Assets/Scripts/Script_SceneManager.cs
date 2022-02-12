using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_SceneManager : MonoBehaviour
{
    /// <summary>
    /// Lädt die Szene MeinePflanzen
    /// </summary>
    public void meinePflanzen()
    {
        SceneManager.LoadScene("MeinePflanzen");
    }

    /// <summary>
    /// Lädt die Szene Pflanzenprofil
    /// </summary>
    public void pflanzenProfil()
    {
        SceneManager.LoadScene("Pflanzenprofil");
    }

    /// <summary>
    /// Lädt die Szene PflanzeFinden
    /// </summary>
    public void pflanzeFinden()
    {
        SceneManager.LoadScene("PflanzeFinden");
    }

    /// <summary>
    /// Lädt die Szene Kalender
    /// </summary>
    public void kalender()
    {
        SceneManager.LoadScene("Kalender");
    }

    /// <summary>
    /// Lädt die Szene AllgemeineTipps
    /// </summary>
    public void allgemeineTipps()
    {
        SceneManager.LoadScene("AllgemeineTipps");
    }

    /// <summary>
    /// Lädt die Szene Hilfedialog
    /// </summary>
    public void Hilfedialog()
    {
        SceneManager.LoadScene("Hilfedialog");
    }

    /// <summary>
    /// Lädt die Szene Erfolge
    /// </summary>
    public void errungenschaften()
    {
        SceneManager.LoadScene("Erfolge");
    }

    /// <summary>
    /// Lädt die Szene Pflanzehinzufuegen
    /// </summary>
    public void pflanzeHinzufugen()
    {
        SceneManager.LoadScene("PflanzeHinzufuegen");
    }

    /// <summary>
    /// Lädt die Szene Pflanzeninfos
    /// </summary>
    public void pflanzenInfos()
    {
        SceneManager.LoadScene("Pflanzeninfos");
    }

    /// <summary>
    /// Lädt die Szene Einstellungen
    /// </summary>
    public void einstellungen()
    {
        SceneManager.LoadScene("Einstellungen");
    }

    /// <summary>
    /// Lädt die Szene InfosGiessen
    /// </summary>
    public void infosGiessen()
    {
        SceneManager.LoadScene("InfosGiessen");
    }

    /// <summary>
    /// Lädt die Szene InfosUmtopfen
    /// </summary>
    public void infosUmtopfen()
    {
        SceneManager.LoadScene("InfosUmtopfen");
    }

    /// <summary>
    /// Lädt die Szene InfosDuengen
    /// </summary>
    public void infosDuengen()
    {
        SceneManager.LoadScene("InfosDuengen");
    }
}