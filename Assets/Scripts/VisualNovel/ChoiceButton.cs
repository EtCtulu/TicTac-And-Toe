using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoiceButton : MonoBehaviour
{
    public TextMeshProUGUI text;
    private int sound = 0;
    private string soundtostring;

    private Choice choice;
    
    public void InitChoiceButton(Choice choice)
    {
        this.choice = choice;
        text.text = choice.choiceDialogue;
    }

    public void OnClick()
    {
        UIManager.Instance.OnClickChoiceButton(choice.choiceidx);
        sound = UnityEngine.Random.Range(1, 5);
        soundtostring = sound.ToString();
        FindObjectOfType<AudioManager>().Play(soundtostring);
    }
}
