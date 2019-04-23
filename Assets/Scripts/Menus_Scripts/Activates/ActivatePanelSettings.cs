using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivatePanelSettings : MonoBehaviour
{

    public bool Activado = false;
    // Start is called before the first frame update

    public void Activar()
    {

        Invoke("ActivacionDePanel", 0f);

    }


    void ActivacionDePanel()
    {
        if (Activado == false)
        {
            this.gameObject.GetComponent<Image>().enabled = true;
            Activado = true;
            Debug.Log(Activado);
        }
    }


    public void Desactivar()
    {

        Invoke("DesactivacionDePanel", 0.2f);

    }

    void DesactivacionDePanel()
    {
        var Select = GameObject.Find("DeslizanteSettings");
        if (Activado && Select.transform.position.x >= 2f)
        {
            this.gameObject.GetComponent<Image>().enabled = false;
            Activado = false;
            Debug.Log(Activado);
        }

    }

}
