using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnButton : MonoBehaviour
{
    public GameObject SpawnButtonv;
    public GameObject SpawnButtonc;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.SougenBoss)
        {
            //村ボタン
            SpawnButtonv.gameObject.SetActive(true);

            if (PlayerController.VillageBoss)
            {
                //城ボタン
                SpawnButtonc.gameObject.SetActive(true);
            }

        }

    }

}
