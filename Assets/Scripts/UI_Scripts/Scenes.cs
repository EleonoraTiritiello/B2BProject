using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void ToGame()
    {
        SceneManager.LoadScene(1);
    }
}
