using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxState : MonoBehaviour
{
    public PhysicsMaterial2D slopeMaterial;
    private Rigidbody2D boxRigidbody2D;

    // 바
    private float boxMass = 0f;  // 박스의 질량
    private float gravity = 0f;  // 중력
    private float friction = 0f; // 마찰 계수
    private float angle = 0f;    // 각도

    void Start()
    {
        boxRigidbody2D = GetComponent<Rigidbody2D>();
        boxMass = boxRigidbody2D.mass; // 질량값을 가져옴
        gravity = 9.81f * boxRigidbody2D.gravityScale; // 중력값을
        friction = slopeMaterial.friction;
        angle = transform.rotation.eulerAngles.z;

        float pushForce = boxMass * gravity * Mathf.Sin(angle * Mathf.Deg2Rad);
        float frictionForce = friction * boxMass * gravity * Mathf.Cos(angle * Mathf.Deg2Rad);

        Debug.Log("Push: " + pushForce + " , Friction: " + frictionForce);

        if (pushForce > frictionForce)
            Debug.Log("움직임");
        else
            Debug.Log("정지");
    }
}
