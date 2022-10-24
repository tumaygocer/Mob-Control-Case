using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMove : MonoBehaviour
{
    public float speed = 1f;

    public Vector3 startPos1;
    public Vector3 startPos2;

    public Transform currentPoint;
    public GameObject platform;

    private void Start()
    {
        startPos1 = platform.transform.position;
    }

    private void Update()
    {
        platform.transform.position = Vector3.MoveTowards(platform.transform.position, startPos1, Time.deltaTime * speed);
        if (platform.transform.position == startPos1)
        {
            startPos1 = startPos2;
            if (startPos1 == startPos2)
            {
                startPos2 = platform.transform.position;
            }
        }
    }
}
