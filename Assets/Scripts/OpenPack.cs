using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenPack : MonoBehaviour
{
    public void Cancel() {
        SceneManager.LoadScene("MainMenu");
    }
}
