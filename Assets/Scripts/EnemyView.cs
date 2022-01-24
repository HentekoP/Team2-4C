using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyView : MonoBehaviour
{
    Ray ray;
    RaycastHit hit;
    Vector3 direction;   // Rayを飛ばす方向
    float distance = 10;    // Rayを飛ばす距離

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Rayを飛ばす方向を計算
            Vector3 temp = other.transform.position - transform.position;
            direction = temp.normalized;

            ray = new Ray(transform.position, direction);  // Rayを飛ばす
            Debug.DrawRay(ray.origin, ray.direction * distance, Color.red);  // Rayをシーン上に描画

            // Rayが最初に当たった物体を調べる
            if (Physics.Raycast(ray.origin, ray.direction * distance, out hit))
            {
                if (hit.collider.CompareTag("Player"))
                {
                    Debug.Log("プレイヤー発見");
                }
                else
                {
                    Debug.Log("プレイヤーとの間に壁がある");
                }
            }
        }
    }
}
