using UnityEngine;

public class PlayerAnimcontroller : MonoBehaviour
{

    void Update()
    {

        //GetComponentを用いてAnimatorコンポーネントを取り出す.
        Animator animator = GetComponent<Animator>();

        //あらかじめ設定していたintパラメーター「trans」の値を取り出す.
        int Hide = animator.GetInteger("Hide");

        //上矢印キーを押した際にパラメータ「trans」の値を増加させる.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Hide++;
        }

        //下矢印キーを押した際にパラメータ「trans」の値を減少させる.
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Hide--;
        }

        //intパラメーターの値を設定する.
        animator.SetInteger("Hide", Hide);
    }
}