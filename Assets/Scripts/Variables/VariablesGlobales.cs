using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariablesGlobales : MonoBehaviour {

    public int nbRound;
    public string[] nomTab;
    public Color[] couleurTab;
    public int[] commandeTab;
    public bool[] joueTab;
    public int choixCarte;

    public VariablesGlobales()
    {
        nbRound = 5;
        nomTab = new string[4];
        couleurTab = new Color[4];
        commandeTab = new int[4];
        joueTab = new bool[4];
}

    public int getNbRound()
    {
        return nbRound;
    }

    public void setNbRound(int val)
    {
        nbRound = val;
    }
    
    public void setInfoTanks(int numJoueur, string nom, Color couleur, int commande, bool joue)
    {
        nomTab[numJoueur] = nom;
        couleurTab[numJoueur] = couleur;
        commandeTab[numJoueur] = commande;
        joueTab[numJoueur] = joue;
    }
}
