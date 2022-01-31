using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public AudioClip sound;
    AudioSource audioSource;

    bool push = true;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (push == true)
        {
            if (Input.GetButton("B"))
            {
                StartCoroutine(ChangeCoroutine());
                audioSource.PlayOneShot(sound, 0.5f);
                push = false;
            }
        }
    }

    private IEnumerator ChangeCoroutine()
    {
        yield return new WaitForSecondsRealtime(1.5f);  //1.5秒待った後にシーンをロード

        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
