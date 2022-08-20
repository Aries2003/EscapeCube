using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    public void MainMenu()//Main menu scene Change method
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void startGame()//Start game scene Change method
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void _2d()//Start game 2d scene Change method
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

    public void _3d()//Start game 3d scene Change method
    {
        SceneManager.LoadScene(3, LoadSceneMode.Single);
    }

    public void Exit()//Exit the Game
    {
       Application.Quit();
    }
    
}