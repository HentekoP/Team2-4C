using UnityEngine;

public class game : MonoBehaviour
{
    //ゲームサウンド
    private AudioSource audioSource;

    //ゲームライト
    public GameObject gamelight;

    //Pauseから受け取る変数用
    bool pushflag;

    void Start()
    {
        //AudioComponentを取得
        audioSource = GetComponent<AudioSource>();

        //ゲームライト（オン）
        gamelight.SetActive(true);
    }

    void Update()
    {
        //Pauseスクリプトから持ってきた値を代入
        pushflag = Pause.PushFlag();

        //もし pushFlag が true なら
        if (pushflag == true)
        {
            //もしBボタンが押されたら
            if (Input.GetKeyDown(KeyCode.JoystickButton1))
            {
                //その時ゲームライトが（オン）なら
                if (gamelight.activeSelf)
                {
                    Debug.Log("ボタンが押されている");
                    audioSource.Stop();
                    //ゲームライト（オフ）
                    gamelight.SetActive(false);
                }
                else
                {
                    Debug.Log("もう一度押された");
                    //ゲームライト（オン）
                    gamelight.SetActive(true);
                    //ゲームサウンドを鳴らす
                    audioSource.Play();
                }
            }
        }
    }
}
