using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreated : MonoBehaviour
{
    int time;
    public GameObject enemy;
    int enemymake = 100;
    float xRight = 1;
    float xLeft = -1;
    void Start()
    {
        time = 0;
    }

    
    void Update()
    {
        if (time >= 20 && enemymake != 0)
        {
            Instantiate(enemy, new Vector3(Random.Range(xRight, xLeft), 0.6f, 11f), Quaternion.identity);
            enemymake -= 1;
            time = 0;
        }
        else
        {
            time += 1;
        }
    }
    
}
