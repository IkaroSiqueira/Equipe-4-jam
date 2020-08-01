using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("ok");
    }
    public void copy()
    {
        SceneManager.LoadScene("Copyrights");
    }
    public void cred()
    {
        SceneManager.LoadScene("Créditos");
    }
    public void quitG()
    {
        Application.Quit();
    }
}
