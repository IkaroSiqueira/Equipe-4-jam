using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Mnu : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("InterMission");
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
