using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rule : MonoBehaviour
{
    [SerializeField]
    GameObject RulePanel;

    private static bool Ruleflag;
    AudioSource getIbikiSE;
    AudioSource getEnemySE;

    void Start()
    {
        RulePanel.SetActive(true);
        Ruleflag = false;
        Time.timeScale = 0;
    }

    void Update()
    {
        getIbikiSE = PlayerAnimcontroller.GetIbikiSE();
        getEnemySE = EnemySound.GetEnemySE();

        if (Input.GetButton("A"))
        {
            if (Ruleflag == false)
            {
                RulePanel.SetActive(false);
                Time.timeScale = 1;
                Ruleflag = true;
                getIbikiSE.Play();
                getEnemySE.Play();
            }
        }
    }

    public static bool GetRuleFlag()
    {
        return Ruleflag;
    }
}
