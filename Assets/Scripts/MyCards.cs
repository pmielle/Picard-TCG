using UnityEngine;
using UnityEngine.SceneManagement;

public class MyCards : MonoBehaviour
{
    public void GoToCard() {
        SceneManager.LoadScene("Card");
    }

    public void Close() {
        SceneManager.LoadScene("MainMenu");
    }
}
