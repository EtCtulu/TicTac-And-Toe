using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerBefore : MonoBehaviour
{
    public GameObject error1;
    public GameObject error2;


    private void Start()
    {
        StartCoroutine(Timer());    
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(5f);

        error1.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Error");

        yield return new WaitForSeconds(2f);

        error2.SetActive(true);
        FindObjectOfType<AudioManager>().Play("Error");

        yield return new WaitForSeconds(0.25f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        yield return 0;

    }

}
