using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private Transform _transform;
    private float _horizontal = 0.0f;
    private float _vertical = 0.0f;

    public float moveSpd = 5.0f;
    public float rotateSpd = 100.0f;


    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal"); // 수평 이동 입력 값 (-1 ~ 1)
        _vertical = Input.GetAxis("Vertical"); // 수직 이동 입력 값 (-1 ~ 1)

        Vector3 moveDirect = (Vector3.forward * _vertical) + (Vector3.right *_horizontal ); // 입력 값을 속도에 곱하여 이동 벡터 생성

        _transform.Translate(moveDirect.normalized * Time.deltaTime * moveSpd, Space.Self);

        _transform.Rotate(Vector3.up * Time.deltaTime * rotateSpd * Input.GetAxis("Mouse X"));
        
    }
}
