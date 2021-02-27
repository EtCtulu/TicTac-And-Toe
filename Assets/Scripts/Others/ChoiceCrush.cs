using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoiceCrush : MonoBehaviour
{
    public void ChooseKaren()
    {
        SceneManager.LoadScene("Bar");
    }

    public void ChoosePipper()
    {
        SceneManager.LoadScene("Parc");
    }

    public void ChooseArnold()
    {
        SceneManager.LoadScene("Plage");
    }

}
