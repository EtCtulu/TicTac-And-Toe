using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    #region Singleton

    public static ScenesManager Instance;

    void Awake ()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy (gameObject);
    }
    #endregion

    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
