using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorController : MonoBehaviour
{
    private Rigidbody2D warriorRigidbody2D;

    public float jumpPower;
    public float speed;
    void Start()
    {
        warriorRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        PlayerMove(); // 플레이어 오브젝트 이동
        PlayerJump(); // 플레이어 오브젝트 점프 처리
    }
    
    void PlayerMove()
    {
        // x축만 값을 받아서 사용
        float x = Input.GetAxis("Horizontal");
        
        // Vector3.right vs transform.right
        // transform.right -> 플레이어 오브젝트의 우측을 의미
        // Vector3.right -> 월드 좌표계 기준으로 우측을 의미
        transform.Translate(Vector3.right * (x * speed * Time.deltaTime));
    }

    void PlayerJump()
    {
        if(Input.GetKeyDown(KeyCode.Space)) // 스페이스 키를 쿨렀을 때 true
            // Vector2.up -> 월드 좌표계상 위쪽 방향으로 힘을 가함
            // jumpPower -> 힘의 크기
            // ForceMode20.Impulse -> 힘을 가하는 방법. impulse는 일시적으로 힘을 가함
            warriorRigidbody2D.AddForce(Vector2.up * jumpPower,ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D _col)
    {
        // 벽의 아래쪽에? 위쪽에? 부딪혔는지 알고 싶음
        // 부딪힌 충돌체의 태그가 Ground가 아닐 때에만 true
        if (_col.gameObject.tag != "Ground")
        {
            // 벡터의 외적을 사용해서 부딪힌 방향이 위인지 아래인지 판단
            UpOrDown(_col);
        }
    }

    void UpOrDown(Collision2D _col)
    {
        // Warrior Pos - Wall Pos = 벽 -> 전사 밯양으로 벡터를 만든다
        // 반시계 방향 - 엄지의 방향(화면에서 밖으로 나옴) - 양수
        // 시계방향 - 엄지의 방향(화면으로 들어감) - 음수
        // 외적 결과물의 z값이 양수라면 위, 음수라면 아래
        Vector3 distVec = transform.position - _col.transform.position;

        // _col.transform.right 충돌체의 오른쪽 방향 벡터
        if (Vector3.Cross(_col.transform.right, distVec).z > 0)
        {
            Debug.Log("Up - 벽의 위에 부딪힘");
            return;
        }
        Debug.Log("Down - 벽의 아래에 부딪힘");
    }
 
}
