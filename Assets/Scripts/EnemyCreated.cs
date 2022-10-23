using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyCreated : MonoBehaviour
{
    int time;
    public GameObject enemy;
    int enemymake = 50;
    public TextMeshProUGUI enemyCount;
    void Start()
    {
        time = 0;
    }

    
    void Update()
    {
        if (time >= 10 && enemymake != 0)
        {
            Instantiate(enemy, new Vector3(0f, 0.6f, 11f), Quaternion.identity);
            enemymake -= 1;
            enemyCount.text = enemymake.ToString();
            time = 0;
        }
        else
        {
            time += 1;
        }
    }
    
}
