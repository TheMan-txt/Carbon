using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private const float SmoothTime = 0.25f;

    private Vector3 _velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Update is called once per frame
    void Update()
    {
        var pos = target.position;
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(pos.x, Mathf.Clamp(pos.y, 0, 1), -10),
            ref _velocity, SmoothTime);
    }
}