using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DialogueHandler.Instance.startDialogue(GetComponent<CharacterInfo>());
    }
}
