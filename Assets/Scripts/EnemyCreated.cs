using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreated : MonoBehaviour
{
    int time;
    public GameObject enemy;
    void Start()
    {
        time = 0;
    }

    
    void Update()
    {
        if (time >= 10)
        {
            Instantiate(enemy, new Vector3(0f, 0.6f, 11f), Quaternion.identity);
            time = 0;
        }
        else
        {
            time += 1;
        }
    }
}
