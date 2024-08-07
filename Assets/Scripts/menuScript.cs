using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements.Experimental;

public class menuScript : MonoBehaviour
{
    private bool isPaused = false;
   // private bool bittimi = false;
    //amo { apo >:(( }
    public GameObject menu;
    public GameObject player;
    public GameObject ayarlar;
    public GameObject anaMenu;
    public GameObject easterEgg;
    public GameObject hardLevelSelect;

    public GameObject mainMenuSelected;
    public GameObject pauseMenuSelected;
    public GameObject settingsMenuSelected;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    void Start()
    {
        Time.timeScale = 1f;
        isPaused = false;
        if (SceneManager.GetActiveScene().buildIndex != 0)
        {
            menu.SetActive(false);
            
            
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }
    public void Reset()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void returnMainMenu()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0) hardLevelSelect.SetActive(false);
        else SceneManager.LoadScene(0);
            
    }
    public void escape()
    {
        if (isPaused)
        {
            resume();
            player.GetComponent<attackScript>().SetGamePaused(false);
        }
        else
        {
            pause();
            player.GetComponent<attackScript>().SetGamePaused(true);
            EventSystem.current.SetSelectedGameObject(pauseMenuSelected);
        }
    }
    public void quitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
    }
    public void settings()
    {
        ayarlar.SetActive(true);
        anaMenu.SetActive(false);
        EventSystem.current.SetSelectedGameObject(settingsMenuSelected);
    }
    public void resume()
    {
        Time.timeScale = 1f;
        isPaused = false;
        menu.SetActive(false);
    }
    public void pause()
    {
        Time.timeScale = 0f;
        isPaused = true;
        menu.SetActive(true);
    }
    public void ayarCikis()
    {
        ayarlar.SetActive(false);
        anaMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(pauseMenuSelected);
    }
    public void eggCikar()
    {
        anaMenu.SetActive(false);
        easterEgg.SetActive(true);
    }
    public void eggKapa()
    {
        anaMenu.SetActive(true);
        easterEgg.SetActive(false);
    }
    public void loadFoundyScene()
    {
        SceneManager.LoadScene("Foundy");
    }
    public void loadChinaTownyScene()
    {
        SceneManager.LoadScene("ChinaTowny");
    }
    public void skipscene()
    {
        SceneManager.LoadScene("Start");
        
    }

    public void loadFaciltyScene()
    {
        SceneManager.LoadScene("Facilty");
    }
    public void loadBossFightScene()
    {
        SceneManager.LoadScene("Boss");
    }

    
    public void levelSelectHard()
    {
        if(PlayerPrefs.GetInt("isGameFinished") == 1)
        hardLevelSelect.SetActive(true);
    }
    public void loadStartZor()
    {
        SceneManager.LoadScene("StartZor");
    }
        public void loadFoundyZor()
    {
        SceneManager.LoadScene("FoundyZor");
    }
        public void loadChinatownZor()
    {
        SceneManager.LoadScene("ChinatownyZor");
    }
        public void loadFaciltyZor()
    {
        SceneManager.LoadScene("FaciltyZor");
    }
        public void loadBossZor()
    {
        SceneManager.LoadScene("BossZor");
    }

    public void SkipCongrats()
    {
        SceneManager.LoadScene("Credits");
    }
    


    public void Oyna1BtnClicked()
    {
        button6.SetActive(false);
    }



    void Update()
    {

        switch (Input.inputString)
        {
            case "1":
                LoadScene("Start");
                break;
            case "2":
                LoadScene("Foundy");
                break;
            case "3":
                LoadScene("ChinaTowny");
                break;
            case "4":
                LoadScene("Facilty");
                break;
            case "5":
                LoadScene("Boss");
                break;
            case "0":
                LoadScene("mainMenu");
                break;
            default:
                break;
        }
    }

    void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void restart()
    {


        PlayerPrefs.SetInt("level2", 0);

        PlayerPrefs.SetInt("level3", 0);

        PlayerPrefs.SetInt("level4", 0);

        PlayerPrefs.SetInt("level5", 0);

        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
        button5.SetActive(false);
        button6.SetActive(false);

    }

    public void restartZor()
    {

        PlayerPrefs.SetInt("level7", 0);

        PlayerPrefs.SetInt("level8", 0);

        PlayerPrefs.SetInt("level9", 0);

        PlayerPrefs.SetInt("level10", 0);

        button7.SetActive(false);

        button8.SetActive(false);

        button9.SetActive(false);

        button10.SetActive(false);        


    }

}
