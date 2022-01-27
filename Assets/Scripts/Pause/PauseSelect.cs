using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseSelect : MonoBehaviour
{
    static int MenuNumber = 0;
    RectTransform rect;

    bool pushFlag = false;
    bool SEflag = false;
    private static bool pushScene = false;


    public AudioClip sound1;
    public AudioSource audioSource1;

    public AudioClip audioClip2;
    public AudioSource audioSource2;

    void Start()
    {
        rect = GetComponent<RectTransform>();
        audioSource1 = GetComponent<AudioSource>();
        audioSource2 = gameObject.GetComponent<AudioSource>();
    }

    void Update()
    {
        if ((!Input.GetButton("A") && Input.GetAxis("Horizontal") == 1) || (!Input.GetButton("A") && Input.GetAxis("Horizontal2") == 1))
        {
            if (pushFlag == false)
            {
                pushFlag = true;
                if (++MenuNumber > 2) MenuNumber = 0;   //ポーズメニューのカーソルが一番下から一番上にくるように
                audioSource1.PlayOneShot(sound1, 0.5f);
            }
        }
        else if ((!Input.GetButton("A") && Input.GetAxis("Horizontal") == -1) || (!Input.GetButton("A") && Input.GetAxis("Horizontal2") == -1))
        {
            if (pushFlag == false)
            {
                pushFlag = true;
                if (--MenuNumber < 0) MenuNumber = 2;    //ポーズメニューのカーソルが一番上から一番下にくるように
                audioSource1.PlayOneShot(sound1, 0.5f);
            }
        }
        else
        {
            pushFlag = false;
        }

        switch (MenuNumber)
        {
            case 0:
                rect.localPosition = new Vector3(-380, -107, 0);
                if (Input.GetButton("A") || (Input.GetButton("A") && Input.GetAxis("Horizontal") == 1) || (Input.GetButton("A") && Input.GetAxis("Horizontal2") == 1) || (Input.GetButton("A") && Input.GetAxis("Horizontal") == -1) || (Input.GetButton("A") && Input.GetAxis("Horizontal2") == -1))
                {
                    pushScene = true;
                    StartCoroutine(RetryCoroutine());
                    audioSource2.Play();
                }
                //Debug.Log("0");
                break;
            case 1:
                rect.localPosition = new Vector3(0, -107, 0);
                if (Input.GetButton("A") || (Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
                {
                    pushScene = true;
                    StartCoroutine(TitleCoroutine());
                    audioSource2.Play();
                }
                //Debug.Log("1");
                break;
            case 2:
                rect.localPosition = new Vector3(380, -107, 0);
                if (Input.GetButton("A") || (Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
                {
                    pushScene = true;
                    StartCoroutine(EndCoroutine());
                    audioSource2.Play();
                }
                //Debug.Log("2");
                break;
        }
    }



    private IEnumerator RetryCoroutine()    //StageNumberによってロードシーンを管理
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("SampleScene");
        pushScene = false;
        Time.timeScale = 1;
    }

    private IEnumerator TitleCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("Title");
        pushScene = false;
        Time.timeScale = 1;
    }

    private IEnumerator EndCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        Application.Quit();
    }


    public static bool PushLoadScene()
    {
        return pushScene;
    }
}