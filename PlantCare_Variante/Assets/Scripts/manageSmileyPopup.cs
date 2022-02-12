using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Die Klasse beinhaltet alle nötigen Methoden und Felder, um die Gesundheit der Pflanzen mit Hilfe von Smileys anzugeben
/// und gegebenenfalls den Hilfedialog zu starten.
/// </summary>
public class manageSmileyPopup : MonoBehaviour
{
    public GameObject Popup;
    public GameObject smileyHappy;
    public GameObject smileySad;

    /// <summary>
    /// Die Methode setzt beim Laden der Szene die Gesundheit der Pflanze auf gut, falls der Gesundheitswert noch nicht gesetzt wurde.
    /// </summary>
    void Start(){
        if(PlayerPrefs.GetString("gesundheit")==null || PlayerPrefs.GetString("gesundheit").Equals("")) {
            smileyHappy.SetActive(true);
            PlayerPrefs.SetString("gesundheit", "gut");
        }
    }

    /// <summary>
    /// Die Methode checkt periodisch den Gesundheitszustand der Pflanze und passt den Smiley gegebenenfalls an.
    /// </summary>
    void Update() {
        if (PlayerPrefs.GetString("gesundheit").Equals("gut")) {
            smileyHappy.SetActive(true);
            smileySad.SetActive(false);
        }
        else if (PlayerPrefs.GetString("gesundheit").Equals("schlecht"))
        {
            smileyHappy.SetActive(false);
            smileySad.SetActive(true);
        }
    }

    /// <summary>
    /// Die Methode startet den Hilfedialog und setzt den Gesundheitszustand der Pflanze auf schlecht.
    /// </summary>
    public void openHilfedialog() {
        SceneManager.LoadScene("Hilfedialog");
        Popup.SetActive(false);
        PlayerPrefs.SetString("gesundheit", "schlecht");
    }

    /// <summary>
    /// Die Methode setzt den Gesundheitszustand auf gut und lädt das Profil neu.
    /// </summary>
    public void closeSmileyPopup() {
        PlayerPrefs.SetString("gesundheit", "gut");
        Popup.SetActive(false);
        SceneManager.LoadScene("Pflanzenprofil");
    }

    /// <summary>
    /// Die Methode öffnet das Fenster zur Bestimmung des Gesundheitszustands.
    /// </summary>
    public void openSmileyPopup(){
        Popup.SetActive(true);
    }
}