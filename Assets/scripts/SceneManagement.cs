using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    // Start is called before the first frame update
    public static void ReturnMainMenu()
    {
        SceneManager.LoadScene("menu");
    }
    public static void Play()
    {
        SceneManager.LoadScene("levels");
    }

    public static void PlayLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public static void PlayLevel2()
    {
        SceneManager.LoadScene("level2");
    }

    public static void PlayLevel3()
    {
        SceneManager.LoadScene("level3");
    }

    public static void Instructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public static void Credits()
    {
        SceneManager.LoadScene("Credits");
    }

    public static void Win()
    {
        SceneManager.LoadScene("Win");
    }

    public static void Exit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
