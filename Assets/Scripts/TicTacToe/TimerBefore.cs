using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerBefore : MonoBehaviour
{
    public GameObject error1;
    public GameObject error2;

    public bool isWinning;


    private void Start()
    {
        StartCoroutine(Timer());    
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(5f);

        if (isWinning == false)
        {
            error1.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Error");
        }

        yield return new WaitForSeconds(2f);

        if (isWinning == false)
        {
            error2.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Error");
        }

        yield return new WaitForSeconds(0.25f);

        if (isWinning == false)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        yield return 0;

    }

    public IEnumerator YouTriedToWin()
    {
        if (isWinning == true)
        {
            error1.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Error");
        }

        yield return new WaitForSeconds(2f);

        if (isWinning == true)
        {
            error2.SetActive(true);
            FindObjectOfType<AudioManager>().Play("Error");
        }

        yield return new WaitForSeconds(0.25f);

        if (isWinning == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        yield return 0;
    }

}
