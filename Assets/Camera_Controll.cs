using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controll : MonoBehaviour
{
    public Transform targetTransform;

    public float dist = 7.0f;
    public float height = 2.0f;
    public float dampTrace = 20.0f;

    private Transform _transform;

    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        _transform.position = Vector3.Lerp(_transform.position, targetTransform.position - (targetTransform.forward * dist) + (Vector3.up * height), Time.deltaTime * dampTrace);
        
        _transform.LookAt(targetTransform.position);
    }
}
