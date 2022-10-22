using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{

    bool right;
    bool left;
    public GameObject shoot;
    float shootTime;


    void Start()
    {
        shootTime = 0;
    }


    void Update()
    {
        Vector3 go_right = new Vector3(1, transform.position.y, transform.position.z);
        Vector3 go_left = new Vector3(-1, transform.position.y, transform.position.z);

        if (Input.touchCount > 0)
        {
            Touch finger = Input.GetTouch(0);
            if (shootTime >= 0.3f)
            {
                Instantiate(shoot, new Vector3(0f, 0.35f, -14.23f), Quaternion.identity);
                shootTime = 0;
            }
            else
            {
                shootTime += 0.4f;
            }

            if (finger.deltaPosition.x > 50.0f)
            {
                right = true;
                left = false;
            }

            if (finger.deltaPosition.x < -50.0f)
            {
                right = false;
                left = true;
            }

            if (right == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_right, 5 * Time.deltaTime);
            }

            if (left == true)
            {
                transform.position = Vector3.Lerp(transform.position, go_left, 5 * Time.deltaTime);
            }
        }
    }
}
