using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script_SceneManager : MonoBehaviour
{
    /// <summary>
    /// L�dt die Szene MeinePflanzen
    /// </summary>
    public void meinePflanzen()
    {
        SceneManager.LoadScene("MeinePflanzen");
    }

    /// <summary>
    /// L�dt die Szene Pflanzenprofil
    /// </summary>
    public void pflanzenProfil()
    {
        SceneManager.LoadScene("Pflanzenprofil");
    }

    /// <summary>
    /// L�dt die Szene PflanzeFinden
    /// </summary>
    public void pflanzeFinden()
    {
        SceneManager.LoadScene("PflanzeFinden");
    }

    /// <summary>
    /// L�dt die Szene Kalender
    /// </summary>
    public void kalender()
    {
        SceneManager.LoadScene("Kalender");
    }

    /// <summary>
    /// L�dt die Szene AllgemeineTipps
    /// </summary>
    public void allgemeineTipps()
    {
        SceneManager.LoadScene("AllgemeineTipps");
    }

    /// <summary>
    /// L�dt die Szene Hilfedialog
    /// </summary>
    public void Hilfedialog()
    {
        SceneManager.LoadScene("Hilfedialog");
    }

    /// <summary>
    /// L�dt die Szene Erfolge
    /// </summary>
    public void errungenschaften()
    {
        SceneManager.LoadScene("Erfolge");
    }

    /// <summary>
    /// L�dt die Szene Pflanzehinzufuegen
    /// </summary>
    public void pflanzeHinzufugen()
    {
        SceneManager.LoadScene("PflanzeHinzufuegen");
    }

    /// <summary>
    /// L�dt die Szene Pflanzeninfos
    /// </summary>
    public void pflanzenInfos()
    {
        SceneManager.LoadScene("Pflanzeninfos");
    }

    /// <summary>
    /// L�dt die Szene Einstellungen
    /// </summary>
    public void einstellungen()
    {
        SceneManager.LoadScene("Einstellungen");
    }

    /// <summary>
    /// L�dt die Szene InfosGiessen
    /// </summary>
    public void infosGiessen()
    {
        SceneManager.LoadScene("InfosGiessen");
    }

    /// <summary>
    /// L�dt die Szene InfosUmtopfen
    /// </summary>
    public void infosUmtopfen()
    {
        SceneManager.LoadScene("InfosUmtopfen");
    }

    /// <summary>
    /// L�dt die Szene InfosDuengen
    /// </summary>
    public void infosDuengen()
    {
        SceneManager.LoadScene("InfosDuengen");
    }
}