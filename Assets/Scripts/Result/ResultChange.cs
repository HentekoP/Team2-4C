using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultChange : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audioSource;
    bool Resultpushflag = true;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Resultpushflag == true)
        {
            if (Input.GetButton("B"))
            {
                StartCoroutine(ChangeCoroutine());
                audioSource.PlayOneShot(sound, 0.5f);
                Resultpushflag = false;
            }
        }
    }

    private IEnumerator ChangeCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("Title");
        Time.timeScale = 1;
    }
}
