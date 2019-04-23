using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sprite_Movement : MonoBehaviour
{
    public float speed = 5f;

    public Text MasCincoTexto;

    float numero = 0f;
    float borde = 2.2f;

    public GameObject Reset;
    public GameObject BackMenu;
    public GameObject NuevoRecord;
    public GameObject Nivel3;
    public GameObject RecordText;
    public GameObject MasCinco;

    GameObject sprite;

    bool Derecha;
    bool Izquierda;
    bool PasoElTiempo;

    void OnTriggerEnter2D(Collider2D objetoQueLoToca)
    {
        if (objetoQueLoToca.gameObject.tag == "Fire" && PasoElTiempo == false)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("Puntaje") >= PlayerPrefs.GetFloat("PuntosActuales"))
            {
                RecordText.gameObject.SetActive(true);
            }
            
        
        }

        if (objetoQueLoToca.gameObject.tag == "Asteroide" && PasoElTiempo == false)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("Puntaje") > PlayerPrefs.GetFloat("PuntosActuales"))
            {
                NuevoRecord.gameObject.SetActive(true);
                RecordText.gameObject.SetActive(true);
            }
        }

        if (objetoQueLoToca.gameObject.tag == "AsteroideGrande" && PasoElTiempo == false)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("Puntaje") > PlayerPrefs.GetFloat("PuntosActuales"))
            {
                NuevoRecord.gameObject.SetActive(true);
                RecordText.gameObject.SetActive(true);
            }
        }

        if (objetoQueLoToca.gameObject.tag == "Robot" && PasoElTiempo == false && Nivel3 != null)
        {
            Time.timeScale = 0;
            //Destroy(gameObject);
            //Instantiate [Explosion]
            Reset.gameObject.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            if (PlayerPrefs.GetFloat("Puntaje") > PlayerPrefs.GetFloat("PuntosActuales"))
            {
                NuevoRecord.gameObject.SetActive(true);
                RecordText.gameObject.SetActive(true);
            }
        }

        if (objetoQueLoToca.gameObject.tag == "Inmunidad" && PasoElTiempo == false)
        {
            PasoElTiempo = true;
            var game = GameObject.Find("Proteccion");
            game.gameObject.GetComponent<SpriteRenderer>().enabled = true;
            Debug.Log("inmune");
            Invoke("Esperar", 7f);
            Destroy(objetoQueLoToca);
        }

        if(objetoQueLoToca.gameObject.tag == "Aura" && PasoElTiempo == false)
        {
            numero = numero + 1;

/*            if (MasCinco.activeInHierarchy == true)
            {
                MasCincoTexto.color();
            }*/

            if (PlayerPrefs.GetFloat("Roze") < numero)
            { 
                PlayerPrefs.SetFloat("Roze", numero);
                print(PlayerPrefs.GetFloat("Roze") + " Rozes");
            }

            MasCinco.gameObject.SetActive(true);
            Invoke("Texto", 0.15f);
        }
    }

    void Esperar()
    {
        PasoElTiempo = false;
        var game = GameObject.Find("Proteccion");
        game.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Debug.Log("VULNERABLE");
    }

    void Start()
    {
        Reset.gameObject.SetActive(false);
        BackMenu.gameObject.SetActive(false);
        NuevoRecord.gameObject.SetActive(false);
        RecordText.gameObject.SetActive(false);
        numero = 0;
        MasCinco.gameObject.SetActive(false);
        PlayerPrefs.SetFloat("Roze", 0);
    }

    void Update()
    {
        print(PlayerPrefs.GetFloat("PuntajeNeto") + " ESTE ES EL PUNTAJE NETO");
        if (Derecha)
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Izquierda)
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (PlayerPrefs.GetFloat("PuntajeNeto") == 1)
        {
            NuevoRecord.gameObject.SetActive(true);
        }

        if(Time.timeScale == 0f)
        {
            MasCinco.gameObject.SetActive(false);
        }

        sprite = GameObject.Find("sprite");

        this.gameObject.GetComponent<SpriteRenderer>().sprite = sprite.GetComponent<SpriteRenderer>().sprite;

        float newX = Mathf.Clamp(transform.position.x, -borde, borde);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        

        // Movimiento Horizontal para Pc

        float hInput = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hInput * speed * Time.deltaTime, 0, 0);

        //float vInput = Input.GetAxis("Vertical");
        //transform.position += new Vector3(0, vInput * speed * Time.deltaTime, 0);

        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if(Time.timeScale == 1)
                {
                    Time.timeScale = 0;
                    Reset.gameObject.SetActive(true);
                    BackMenu.gameObject.SetActive(true);
                }
                else
                {
                    SceneManager.LoadScene("MainMenu");
                }
            }
        }
    }

    public void MoverDerecha()
    {
        Derecha = true;
    }

    public void MoverIzquierda()
    {
        Izquierda = true;
    }

    public void Detener()
    {
        Derecha = false;
        Izquierda = false;
    }

    void Texto()
    {
        MasCinco.gameObject.SetActive(false);
    }
}





