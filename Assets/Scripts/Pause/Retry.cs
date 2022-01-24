using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{

    public void OnClick()
    {
        SceneManager.LoadScene("SampleScene");
        //StartCoroutine("RetryCoroutine");
    }

    //private IEnumerator RetryCoroutine()
    //{
    //    yield return new WaitForSecondsRealtime(1.5f);

    //    SceneManager.LoadScene("SampleScene");

    //}
}
