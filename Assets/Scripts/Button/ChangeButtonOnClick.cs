using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonOnClick : MonoBehaviour {

    private Color bleu = new Color32(42, 100, 178, 255);
    private Color rouge = new Color32(229, 46, 40, 255);
    private Color vert = new Color32(126, 206, 64, 255);
    private Color violet = new Color32(142, 42, 178, 255);
    private Color turquoise = new Color32(29, 154, 133, 255);
    private Color orange = new Color32(225, 90, 0, 255);
    private Color rose = new Color32(255, 0, 132, 255);

    public void ChangerCouleur(Button button)
    {
        if (button.GetComponent<Image>().color.Equals(rose))
        {
            button.GetComponent<Image>().color = bleu;
        }
        else if (button.GetComponent<Image>().color.Equals(bleu))
        {
            button.GetComponent<Image>().color = rouge;
        }
        else if (button.GetComponent<Image>().color.Equals(rouge))
        {
            button.GetComponent<Image>().color = vert;
        }
        else if (button.GetComponent<Image>().color.Equals(vert))
        {
            button.GetComponent<Image>().color = violet;
        }
        else if (button.GetComponent<Image>().color.Equals(violet))
        {
            button.GetComponent<Image>().color = turquoise;
        }
        else if (button.GetComponent<Image>().color.Equals(turquoise))
        {
            button.GetComponent<Image>().color = orange;
        }
        else //si orange
        {
            button.GetComponent<Image>().color = rose;
        }
    }
}
