using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cambiar_Sprite : MonoBehaviour
{
    public Sprite Zombie;
    public Sprite Mugiwara;
    public Sprite OsoPolarI;
    public Sprite OsoPolarII;
    public Sprite OsoPardoI;
    public Sprite OsoPardoII;
    public Sprite WhiteFace;
    public Sprite BlackFace;
    public GameObject Jugador;

    // Start is called before the first frame update
    void Start()
    {
        var Preferencia = PlayerPrefs.GetString("Sprite", "WhiteFace");
            if (Preferencia == "WhiteFace")
            {
                this.gameObject.GetComponent<Image>().sprite = WhiteFace;
                Jugador.GetComponent<SpriteRenderer>().sprite = WhiteFace;
            }
            if (Preferencia == "Zombie")
            {
                this.gameObject.GetComponent<Image>().sprite = Zombie;
                Jugador.GetComponent<SpriteRenderer>().sprite = Zombie;
            }
            if (Preferencia == "Mugiwara")
            {
                this.gameObject.GetComponent<Image>().sprite = Mugiwara;
                Jugador.GetComponent<SpriteRenderer>().sprite = Mugiwara;
            }
            if (Preferencia == "OsoPolarI")
            {
                this.gameObject.GetComponent<Image>().sprite = OsoPolarI;
                Jugador.GetComponent<SpriteRenderer>().sprite = OsoPolarI;
            }
            if (Preferencia == "OsoPardoI")
            {
                this.gameObject.GetComponent<Image>().sprite = OsoPardoI;
                Jugador.GetComponent<SpriteRenderer>().sprite = OsoPardoI;
            }
            if (Preferencia == "OsoPolarII")
            {
                this.gameObject.GetComponent<Image>().sprite = OsoPolarII;
                Jugador.GetComponent<SpriteRenderer>().sprite = OsoPolarII;
            }
            if (Preferencia == "OsoPardoII")
            {
                this.gameObject.GetComponent<Image>().sprite = OsoPardoII;
                Jugador.GetComponent<SpriteRenderer>().sprite = OsoPardoII;
            }
            if (Preferencia == "BlackFace")
            {
                this.gameObject.GetComponent<Image>().sprite = BlackFace;
                Jugador.GetComponent<SpriteRenderer>().sprite = BlackFace;
            }
            if (Preferencia == null)
            {
                this.gameObject.GetComponent<Image>().sprite = WhiteFace;
                Jugador.GetComponent<SpriteRenderer>().sprite = WhiteFace;
            }
    }

    public void CambiarSpriteWhiteFace()
    {
        this.gameObject.GetComponent<Image>().sprite = WhiteFace;
        Jugador.GetComponent<SpriteRenderer>().sprite = WhiteFace;
        PlayerPrefs.SetString("Sprite", "WhiteFace");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteZombie()
    {
        this.gameObject.GetComponent<Image>().sprite = Zombie;
        Jugador.GetComponent<SpriteRenderer>().sprite = Zombie;
        PlayerPrefs.SetString("Sprite", "Zombie");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteMugiwara()
    {
        this.gameObject.GetComponent<Image>().sprite = Mugiwara;
        Jugador.GetComponent<SpriteRenderer>().sprite = Mugiwara;
        PlayerPrefs.SetString("Sprite", "Mugiwara");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteOsoPolarI()
    {
        this.gameObject.GetComponent<Image>().sprite = OsoPolarI;
        Jugador.GetComponent<SpriteRenderer>().sprite = OsoPolarI;
        PlayerPrefs.SetString("Sprite", "OsoPolarI");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteOsoPardoI()
    {
        this.gameObject.GetComponent<Image>().sprite = OsoPardoI;
        Jugador.GetComponent<SpriteRenderer>().sprite = OsoPardoI;
        PlayerPrefs.SetString("Sprite", "OsoPardoI");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteOsoPolarII()
    {
        this.gameObject.GetComponent<Image>().sprite = OsoPolarII;
        Jugador.GetComponent<SpriteRenderer>().sprite = OsoPolarII;
        PlayerPrefs.SetString("Sprite", "OsoPolarII");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteOsoPardoII()
    {
        this.gameObject.GetComponent<Image>().sprite = OsoPardoII;
        Jugador.GetComponent<SpriteRenderer>().sprite = OsoPardoII;
        PlayerPrefs.SetString("Sprite", "OsoPardoII");
        print(PlayerPrefs.GetString("Sprite"));
    }

    public void CambiarSpriteBlackFace()
    {
        this.gameObject.GetComponent<Image>().sprite = BlackFace;
        Jugador.GetComponent<SpriteRenderer>().sprite = BlackFace;
        PlayerPrefs.SetString("Sprite", "BlackFace");
        print(PlayerPrefs.GetString("Sprite"));
    }
}
