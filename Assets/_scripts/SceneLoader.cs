using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene(int i) 
    { 
        SceneManager.LoadScene(1);

    }

    public void LoadScene(string s)
    {
        SceneManager.LoadScene("SCN_menu");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
