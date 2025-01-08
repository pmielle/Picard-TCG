using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate = 120;
    }

    public void GoToMyCards() 
    { 
        SceneManager.LoadScene("MyCards"); 
    }

    public void GoToOpenPack() 
    { 
        SceneManager.LoadScene("OpenPack"); 
    }
}
