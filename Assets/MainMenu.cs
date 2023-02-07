using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //Escape button for all scenes(check to see if script is in all scene canvases)
    void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape))
        Application.Quit();
    }

    // Main gameplay scenes
    public void PlayGame ()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void Stats ()
    {
        SceneManager.LoadScene("Stats");
    }
    
    public void About ()
    {
        SceneManager.LoadScene("About");
    }

    public void MailmansGuide ()
    {
         SceneManager.LoadScene("Mailman");
    }

    public void BackToMenu ()
    {
        SceneManager.LoadScene("Home");
    }

    public void HowToPlay ()
    {
        SceneManager.LoadScene("HowToPlayPage");
    }


    //Character guides
    public void Tablet416 ()
    {
        SceneManager.LoadScene("Tablet416");
    }

    public void Sam ()
    {
        SceneManager.LoadScene("Sam");
    }

    public void Linda ()
    {
        SceneManager.LoadScene("Linda");
    }

    public void Dana ()
    {
        SceneManager.LoadScene("Dana");
    }

    //Levels
    public void Level1 ()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Level2 ()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void Level3 ()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void Level4 ()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void Level5 ()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void Level6 ()
    {
        SceneManager.LoadScene("Level 6");
    }

    public void Level7 ()
    {
        SceneManager.LoadScene("Level 7");
    }

    public void Level8 ()
    {
        SceneManager.LoadScene("Level 8");
    }

    public void Level9 ()
    {
        SceneManager.LoadScene("Level 9");
    }

    // VN Episodes

    public void Ep1 ()
    {
        SceneManager.LoadScene("Ep1");
    }

    public void Ep2 ()
    {
        SceneManager.LoadScene("Ep2");
    }

    public void Ep3 ()
    {
        SceneManager.LoadScene("Ep3");
    }

    public void Ep4 ()
    {
        SceneManager.LoadScene("Ep4");
    }

    public void Ep5 ()
    {
        SceneManager.LoadScene("Ep5");
    }

    public void Ep6 ()
    {
        SceneManager.LoadScene("Ep6");
    }

    public void Ep7 ()
    {
        SceneManager.LoadScene("Ep7");
    }

    public void Ep8 ()
    {
        SceneManager.LoadScene("Ep8");
    }

    public void Ep9 ()
    {
        SceneManager.LoadScene("Ep9");
    }
}
