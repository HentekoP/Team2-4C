using UnityEngine;

public class enemyAnim : MonoBehaviour
{

    Animation anim;

    // Use this for initialization
    void Start()
    {
        anim = this.gameObject.GetComponent<Animation>();


    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            anim.Play();



        }


    }
}