using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerAnimcontroller : MonoBehaviour
{
    Animator m_player;

    bool getSEFlag;

    // Start is called before the first frame update
    void Start()
    {
        this.m_player = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        getSEFlag = Pause.GetSEflag();

        if (getSEFlag == true)
        {
            if (Gamepad.current.bButton.wasPressedThisFrame)
            {
                m_player.SetTrigger("Hidee");

            }
        }
    }
}