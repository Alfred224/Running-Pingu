using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Transform playerTransform; 
    
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // I did this because for some reason my player stutters when the plane moves above -0.3f on the y axis
        if (playerTransform.position.z > 1 / 4 * transform.position.z)
        {
            transform.position = new Vector3(0, -0.3f, (playerTransform.position.z));
        }

    }
}
