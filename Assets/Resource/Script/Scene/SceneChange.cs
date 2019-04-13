using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string[] SceneNames;

    public void change(int i)
    {
        SceneManager.LoadScene(SceneNames[i]);
    }

    public static void change(Scene s)
    {
        SceneManager.LoadScene(s.name);
    }
}
