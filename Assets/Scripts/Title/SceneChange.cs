using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StartCoroutine(ChangeCoroutine());
        }
    }

    private IEnumerator ChangeCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
