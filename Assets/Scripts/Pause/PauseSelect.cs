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
    int StageNumber = 0;

    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    void Update()
    {
        //SEflag = Seselect.GetSEFlag();
        //StageNumber = StageSelect.StageNumber();

        //if (SEflag == false)
        //{
            if ((!Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (!Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
            {
                if (pushFlag == false)
                {
                    pushFlag = true;
                    if (++MenuNumber > 2) MenuNumber = 0;   //ポーズメニューのカーソルが一番下から一番上にくるように
                }
            }
            else if ((!Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (!Input.GetButton("A") && Input.GetAxis("Vertical2") == 1))
            {
                if (pushFlag == false)
                {
                    pushFlag = true;
                    if (--MenuNumber < 0) MenuNumber = 2;    //ポーズメニューのカーソルが一番上から一番下にくるように

                }
            }
            else
            {
                pushFlag = false;
            }
        //}

        switch (MenuNumber)
        {
            case 0:
                rect.localPosition = new Vector3(-420, 40, 0);
                if (Input.GetButton("A") || (Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
                {
                    pushScene = true;
                    StartCoroutine(RetryCoroutine());
                }
                //Debug.Log("0");
                break;
            case 1:
                rect.localPosition = new Vector3(-420, -80, 0);
                if (Input.GetButton("A") || (Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
                {
                    pushScene = true;
                    StartCoroutine(TitleCoroutine());
                }
                //Debug.Log("1");
                break;
            case 2:
                rect.localPosition = new Vector3(-420, -200, 0);
                if (Input.GetButton("A") || (Input.GetButton("A") && Input.GetAxis("Vertical") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == 1) || (Input.GetButton("A") && Input.GetAxis("Vertical") == -1) || (Input.GetButton("A") && Input.GetAxis("Vertical2") == -1))
                {
                    pushScene = true;
                    StartCoroutine(EndCoroutine());
                }
                //Debug.Log("2");
                break;

        }
    }



    private IEnumerator RetryCoroutine()    //StageNumberによってロードシーンを管理
    {
        yield return new WaitForSecondsRealtime(1.5f);

        if (StageNumber == 0)
        {
            SceneManager.LoadScene("SampleScene");
            pushScene = false;
            MenuNumber = 0;
        }
    }

    private IEnumerator TitleCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);

        SceneManager.LoadScene("Title");
        pushScene = false;
        Time.timeScale = 1;
        MenuNumber = 0;
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