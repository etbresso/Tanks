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

    public void LoadCarte()
    {
        string[] tabCarte = { "LevelDesert", "LevelDesert2" };
        string carte = string.Empty;

        if (InfoSelection.vg.choixCarte == 0)
        {
            int nbAlea = UnityEngine.Random.Range(0, tabCarte.Length);
            carte = tabCarte[nbAlea];
        }
        else if (InfoSelection.vg.choixCarte == 1)
        {
            carte = tabCarte[0];
        }
        if (InfoSelection.vg.choixCarte == 2)
        {
            carte = tabCarte[1];
        }

        SceneManager.LoadScene(carte, LoadSceneMode.Single);
    }
}
