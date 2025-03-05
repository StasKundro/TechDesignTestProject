using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void GoExit()
    {
        Application.Quit();
    }
    public void GoLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
