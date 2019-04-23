using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordController : MonoBehaviour
{
    public Text RecordText;
    string Segundo = " Pts.";
    
    void Start()
    {
        RecordText.text = "Record:" + PlayerPrefs.GetFloat("PuntosActuales").ToString() + "<size=" + RecordText.fontSize / 2 + ">" + Segundo + "</size>";
    }

    public float GetMaxScore()
    {
        return PlayerPrefs.GetFloat("Puntaje", 0);
    }

    void Update()
    {
        if (PlayerPrefs.GetFloat("Puntaje") > PlayerPrefs.GetFloat("PuntosActuales", 0))
        {
            string Tiempo;

            PlayerPrefs.SetFloat("PuntosActuales", PlayerPrefs.GetFloat("Puntaje"));

            Tiempo = "Record:" + PlayerPrefs.GetFloat("PuntosActuales").ToString();
            Tiempo += "<size=" + RecordText.fontSize / 2 + ">" + Segundo + "</size>";

            RecordText.text = Tiempo;
        }   

        if (PlayerPrefs.GetFloat("PuntosActuales") == 0)
        {
            RecordText.text = "Record:---";
        }
    }
}
