using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Vector3 start = new Vector3(0, -1.8f, 0);
    public GameObject snow;

    // Update is called once per frame
    void Update()
    {
        snow.transform.position = new Vector3(transform.position.x, snow.transform.position.y, snow.transform.position.z);
        if (transform.position.y <= -2)
        {
            GetComponent<PlayerMovement>().enabled = false;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            transform.position = start;
            GetComponent<PlayerMovement>().enabled = true;
        }
    }
}
