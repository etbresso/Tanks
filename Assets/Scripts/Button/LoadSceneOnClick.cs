using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

    public void LoadScene(string level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }

    public void LoadSceneAdditive(string level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Additive);
    }
}
