using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageInfoPflanzenprofil : MonoBehaviour
{
    public GameObject title;
    public GameObject body;

    /// <summary>
    /// Die Methode schreibt den Namen und die allgemeinen Infos der Pflanze aus den Playerprefs in die übergebenen GameObjects.
    /// </summary>
    void Start(){
        TMPro.TextMeshProUGUI titleObject = title.GetComponentInChildren<TMPro.TextMeshProUGUI>();    
        TMPro.TextMeshProUGUI bodyObject = body.GetComponentInChildren<TMPro.TextMeshProUGUI>();

        titleObject.text=PlayerPrefs.GetString("name");
        bodyObject.text=PlayerPrefs.GetString("generalInfo");
    }
}