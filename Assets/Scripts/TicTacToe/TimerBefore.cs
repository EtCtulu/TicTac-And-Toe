using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerBefore : MonoBehaviour
{
    void Start()
    {
        
    }


    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(7f);

        yield return new WaitForSeconds(2f);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        yield return 0;

    }

}
