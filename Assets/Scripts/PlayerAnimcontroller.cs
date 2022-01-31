using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAnimcontroller : MonoBehaviour
{
    //ゲームサウンド
    private static AudioSource audioSource;

    bool audioflag = true;

    Animator m_player;

    bool getSEFlag;
    bool getRuleflag;
    bool pauseflag = true;

    // Start is called before the first frame update
    void Start()
    {
        //AudioComponentを取得
        audioSource = GetComponent<AudioSource>();
        audioSource.Stop();
        this.m_player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        getSEFlag = Pause.GetSEflag();
        getRuleflag = Rule.GetRuleFlag();

        if (getSEFlag == false) //もし getSEFlag が false なら
        {
            if (pauseflag == true)
            {
                pauseflag = false;
                if (Time.timeScale == 0)
                {
                    audioSource.Stop();

                    //Debug.Log("音がとまる");
                }
            }
        }
        else　   //もし getSEFlag が true なら
        {
            if (pauseflag == false)
            {
                pauseflag = true;
                if (Time.timeScale == 1)
                {
                    if(audioflag == true)
                    {
                        audioSource.Play();
                    }
                }
            }
        }


        if (getRuleflag == true)
        {
            if (getSEFlag == true)
            {
                if (Gamepad.current.bButton.wasPressedThisFrame)
                {
                    m_player.SetTrigger("Hidee");

                }

                if (Input.GetKeyDown(KeyCode.JoystickButton1))
                {
                    if (audioflag == false)
                    {
                        audioSource.Play();
                        audioflag = true;
                    }
                    else
                    {
                        audioSource.Stop();
                        audioflag = false;
                    }
                }
            }
        }
    }

    public static AudioSource GetIbikiSE()
    {
        return audioSource;
    }
}