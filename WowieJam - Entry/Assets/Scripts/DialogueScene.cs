using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueScene : MonoBehaviour
{    

    public TextMeshProUGUI display;
    public string[] sentences;
    public float textSpeed;
    int index = 0;
    bool canCont;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void EndDiallogue()
    {
        index = 0;
    }

    public void NextLine()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            display.text = ""; canCont = false;
            StartCoroutine(Buildtext());
        }
        else
        {
            display.text = "";
        }

        if (index > sentences.Length) index = 0;

    }

    IEnumerator Buildtext()
    {
        foreach (char letter in sentences[index].ToCharArray())
        {
            display.text += letter;
            yield return new WaitForSeconds(textSpeed);
        }

        canCont = true;
    }

    public bool getCont() => canCont;
}
