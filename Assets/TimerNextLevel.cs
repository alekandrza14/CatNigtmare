using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerNextLevel : MonoBehaviour
{
    void Start()
    {
        Invoke("NextLevel",60);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(2);
    }
}
