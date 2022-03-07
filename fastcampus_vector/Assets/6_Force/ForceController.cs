using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceController : MonoBehaviour
{
    private Rigidbody boxRigidbody;
    private float movePower = 5f;
    void Start()
    {
        boxRigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        // Debug.Log(boxRigidbody2D.velocity);
        Debug.Log(boxRigidbody.velocity);
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
            // Impulse와 Force는 질량에 영향을 받음. F=ma
            // 순간적인 힘을 가할 때 사용
            // Impulse는 1초동안 가해진 힘의 합
            // FixedUpdate는 1스텝당 0.02s 소요, 1초에 50번 업데이트
            // 1초에 힘을 50번 가함 = Force모드로 50번의 힘을 가하면 Impulse와 동일
            boxRigidbody.AddForce(transform.right * movePower, ForceMode.Impulse);
            //boxRigidbody.AddForce(transform.right * movePower / Time.fixedDeltaTime, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            // Impulse와 Force는 질량에 영향을 받음. F=ma
            // 지속적으로 힘을 가할 때 사용
            boxRigidbody.AddForce(transform.right * movePower, ForceMode.Force);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            // VelocityChange와 Acceleration은 질량과 무관하게 힘을 가함. F=ma
            // 순간적인 힘을 가할 때 사용
            boxRigidbody.AddForce(transform.right * movePower, ForceMode.VelocityChange);
            //boxRigidbody.AddForce(transform.right * movePower / Time.fixedDeltaTime, ForceMode.Acceleration);
        }
        else if (Input.GetKey(KeyCode.F))
        {
            // VelocityChange와 Acceleration은 질량과 무관하게 힘을 가함. F=ma
            // 지속적으로 힘을 가할 때 사용
            boxRigidbody.AddForce(transform.right * movePower, ForceMode.Acceleration);
        }
    }
}
