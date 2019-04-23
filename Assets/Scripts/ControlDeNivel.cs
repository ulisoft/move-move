using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlDeNivel : MonoBehaviour
{
    public GameObject character;

    public ActivatePanel activatePanel;
    public ActivatePanel activatePanelSelectLevel;
    public ActivatePanelSettings activatePanelSettings;
    public ActivatePanelTutoria activatePanelTutoria;

    public SettingsMenuController Selectpj;
    public SettingsMenuController SelectLevel;
    public SettingsMenuController Settings;
    public SettingsMenuController Tutorial;

    bool Activacion;

    public void LevelSpace()
    {
        PlayerPrefs.SetFloat("Roze", 0);
        PlayerPrefs.SetFloat("Roze", 0);
        SceneManager.LoadScene("SpaceScene");
        Time.timeScale = 1f;
        DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
        PlayerPrefs.SetFloat("PuntajeNeto", 0);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
        Destroy(GameObject.Find("GameObject"));
        Destroy(GameObject.Find("sprite"));
    }

    public void Level1()
    {
        SceneManager.LoadScene("Nivel-1");
        Time.timeScale = 1f;
        DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
    }

    public void Level2()
    {
        SceneManager.LoadScene("Nivel-2");
        Time.timeScale = 1f;
        DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
    }

    public void Level3()
    {
        SceneManager.LoadScene("Nivel-3");
        Time.timeScale = 1f;
        DontDestroyOnLoad(character);
        PlayerPrefs.SetFloat("Termino", 0);
    }

    public void Creditos()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Credits");
    }

    public void RestartRecord()
    {
        PlayerPrefs.SetFloat("PuntosActuales", 0);
        PlayerPrefs.SetFloat("Puntaje", 0);
    }

    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (Application.platform == RuntimePlatform.Android)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                if (sceneName == "Credits")
                {
                    SceneManager.LoadScene("MainMenu");
                }

                if (sceneName == "MainMenu")
                {

                    if (activatePanel.Activado == true)
                    {
                        activatePanel.Desactivar();
                        Selectpj.ReturnLeft();
                        Activacion = true;
                    }

                    if (activatePanelSelectLevel.Activado == true)
                    {
                        SelectLevel.ReturnDown();
                        Activacion = true;
                        activatePanelSelectLevel.Desactivar();
                    }

                    if (activatePanelSettings.Activado == true)
                    {
                        activatePanelSettings.Desactivar();
                        Settings.ReturnRight();
                        Activacion = true;
                    }

                    if (activatePanelTutoria.Activado == true)
                    {
                        Tutorial.ReturnRight();
                        activatePanelTutoria.Desactivar();
                        Activacion = true;
                    }

                    if (Activacion == true)
                    { 
                        Application.Quit();
                    }
                }
            }
        }
    }    

   
}
