using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_ManageScene : MonoBehaviour
{
    public void ChangeToSecondLevel()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeToFirstLevel()
    {
        SceneManager.LoadScene(0);
    }
    
    public void QuitTheGame()
    {
        Application.Quit();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitTheGame();
        }
    }

}
