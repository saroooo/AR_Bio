using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class main_menu : MonoBehaviour
{
    public void StartApp()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitApp()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
