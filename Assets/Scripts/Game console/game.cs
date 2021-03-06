using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{

    [SerializeField] GameObject Object;//
    //ゲームサウンド
    private AudioSource audioSource;

    //ゲームライト
    public GameObject gamelight;

    public GameObject score_object = null; // Textオブジェクト
    public int score_num = 0; // スコア変数


    bool getSEFlag;     //Pauseから受け取る変数用
    bool getRuleflag;
    bool pauseflag = true;
    bool Light = false;


    bool ActiveFlag = false;//

    void Start()
    {
        //AudioComponentを取得
        audioSource = GetComponent<AudioSource>();

        //ゲームライト（オン）
        gamelight.SetActive(false);
    }

    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        // テキストの表示を入れ替える
        score_text.text = "Score:" + score_num;
        //Pauseスクリプトの値を代入
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

                    if (Light == true)
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
                //もしBボタンが押されたら
                if (Input.GetKeyDown(KeyCode.JoystickButton1))
                {
                    //その時ゲームライトが（オン）なら
                    if (gamelight.activeSelf)
                    {
                        Light = false;
                        //Debug.Log("ボタンが押されている");
                        audioSource.Stop();
                        //ゲームライト（オフ）
                        gamelight.SetActive(false);

                        Object.SetActive(false);//
                        ActiveFlag = false;//
                    }
                    else
                    {
                        Light = true;
                        //Debug.Log("もう一度押された");

                        //ゲームライト（オン）
                        gamelight.SetActive(true);
                        //ゲームサウンドを鳴らす
                        audioSource.Play();

                        Object.SetActive(true);//
                        ActiveFlag = true;//
                    }

                }
            }
        }
    }

    void FixedUpdate()
    {
        if(Light == true)
        {
            score_num += 1;
        }
    }
}
