using UnityEngine;

public class Mothers_AI : MonoBehaviour
{
    int counter = 0;
    float move = 0.05f;

    void Update()
    {
        Vector3 p = new Vector3(0, 0, move);
        transform.Translate(p);
        counter++;

        //countが100になれば-1を掛けて逆方向に動かす
        if (counter == 500)
        {
            counter = 0;
            move *= -1;
        }
    }
}
