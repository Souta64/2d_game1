using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBall : MonoBehaviour
{
    float count = 5.0f;
    private void Update()
    {
        count -= Time.deltaTime;
        if (count <= 0)
        {
            count = 5.0f;
            Destroy(this.gameObject);
        }
    }

   

    //画面外に出たら消える
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
