using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InfoSelection : MonoBehaviour {

    public Dropdown carteDropdown;
    public InputField nbRoundInputNbRound;

    public InputField[] nomInputField;
    public Button[] couleurButton;
    public Dropdown [] controleDropdown;

    static public VariablesGlobales vg;

    private bool[] joue;

    public GameObject panel3;
    public GameObject panel4;

    public GameObject bouton3;
    public GameObject bouton3Supp;
    public GameObject bouton4;

    public string[] tabCarte = { "LevelDesert", "LevelDesert2" };

    public void Start()
    {
        try
        {
            nbRoundInputNbRound.text = ""+vg.nbRound;
            joue = new bool[4];
            for (int i = 0; i < vg.nomTab.Length; i++)
            {
                nomInputField[i].text = vg.nomTab[i];
                couleurButton[i].GetComponent<Image>().color = vg.couleurTab[i];
                controleDropdown[i].value = vg.commandeTab[i];
                joue[i] = vg.joueTab[i];
            }
        }
        catch
        {
            joue = new bool[] { true, true, false, false };
        }

        if(joue[2]) //affiche le joueur 3
        {
            panel3.SetActive(true); //affiche le joueur 3
            bouton3.SetActive(false); //cache le boutonJ3

            if (joue[3]) //affiche le joueur 4
            {
                panel4.SetActive(true); //affiche le joueur 4
                bouton4.SetActive(false); //cache le boutonJ4
                bouton3Supp.SetActive(false); //cache le bouton3Supp
            }
            else
            {
                panel4.SetActive(false); //cache le joueur 3
                bouton4.SetActive(true); //affiche le boutonJ4
                bouton3Supp.SetActive(true); //affiche le bouton3Supp
            }
        }
        else
        {
            panel3.SetActive(false); //cache le joueur 3
            bouton3.SetActive(true); //affiche le boutonJ3
            panel4.SetActive(false); //cache le joueur 3
            bouton4.SetActive(false); //cache le boutonJ4
        }
    }


    public void LoadLevel()
    {
        vg = new VariablesGlobales();
        vg.setNbRound(int.Parse(nbRoundInputNbRound.text)); //si pas de valeur ?

        vg.setInfoTanks(0, nomInputField[0].text, couleurButton[0].GetComponent<Image>().color, controleDropdown[0].value, joue[0]); //Joueur1
        vg.setInfoTanks(1, nomInputField[1].text, couleurButton[1].GetComponent<Image>().color, controleDropdown[1].value, joue[1]); //Joueur2
        vg.setInfoTanks(2, nomInputField[2].text, couleurButton[2].GetComponent<Image>().color, controleDropdown[2].value, joue[2]); //Joueur3
        vg.setInfoTanks(3, nomInputField[3].text, couleurButton[3].GetComponent<Image>().color, controleDropdown[3].value, joue[3]); //Joueur4

        vg.choixCarte = carteDropdown.value;

        SceneManager.LoadScene(choixCarte(), LoadSceneMode.Single);
    }

    public string choixCarte()
    {
        string carte = string.Empty;

        if (carteDropdown.value == 0)
        {
            int nbAlea = UnityEngine.Random.Range(0, tabCarte.Length);
            carte = tabCarte[nbAlea];
        }
        else if (carteDropdown.value == 1)
        {
            carte = tabCarte[0];
        }
        if (carteDropdown.value == 2)
        {
            carte = tabCarte[1];
        }
        return carte;
    }

    public void addJoueur3()
    {
        bouton3.SetActive(false); //cache le boutonJ3
        panel3.SetActive(true); //affiche le joueur 3
        bouton4.SetActive(true); //affiche le boutonJ4
        bouton3Supp.SetActive(true); //affiche le bouton3Supp

        joue[2] = true;
    }

    public void addJoueur4()
    {
        bouton4.SetActive(false); //cache le boutonJ4
        panel4.SetActive(true); //affiche le joueur 4
        bouton3Supp.SetActive(false); //false le bouton3Supp

        joue[3] = true;
    }

    public void removeJoueur3()
    {
        bouton3.SetActive(true); //affiche le boutonJ3
        panel3.SetActive(false); //cache le joueur 3
        bouton4.SetActive(false); //affiche le boutonJ4

        joue[2] = false;
    }

    public void removeJoueur4()
    {
        bouton4.SetActive(true); //affiche le boutonJ4
        panel4.SetActive(false); //cache le joueur 4
        bouton4.SetActive(true); //affiche le boutonJ4
        bouton3Supp.SetActive(true); //affiche le bouton3Supp

        joue[3] = false;
    }
}
