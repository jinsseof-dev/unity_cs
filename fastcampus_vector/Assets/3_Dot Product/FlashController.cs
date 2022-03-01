using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class FlashController : MonoBehaviour
{
    public GameObject[] ghostObjectArray;

    public float moveSpeed = 3f;
    public float rangeAngle = 25f;   // 
    public float rangeDistance = 4f; // 
    void Update()
    {
        PlayerMove();
        CheckGhost();
    }

    void PlayerMove()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(x,y) * (moveSpeed * Time.deltaTime));
    }

    void CheckGhost()
    {
        int i = 0; // 감지된 유령의 수 초기값은 0
        foreach (var ghost in ghostObjectArray) // foreach를 이용해서 각 오브젝트를 검출
        {
            // 유령(ghost.transform.position)의 위치와 손전등(transform.position)의 위치를 빼서 방향 벡터를 구합니다
            Vector3 distanceVec = ghost.transform.position - transform.position;

            // magnitude는 거리이므로, 유령과 손전등간의 거리가 4f보다 작으면 거리 조건은 맞음
            if (distanceVec.magnitude < rangeDistance)
            {
                // 내적을 하기 위해서 무조건 방향벡터로 만들어 줌(normalized)
                Vector3 dirVec = distanceVec.normalized;

                // up은 오브젝트의 위쪽 방향을 의미. up, down, left, right 모두 방향 벡터
                // 내적의 x1x2 + y1y2 (X)는 유니티에서는 Vector3.Dot() 이용

                Debug.Log("각도 " + (Mathf.Deg2Rad));
                if (Vector3.Dot(transform.up, dirVec) > Mathf.Cos(rangeAngle*Mathf.Deg2Rad))
                    i++; // 손전등 각도 범위 안에 포함되었으므로 유령 검출 갯수 추가
            }
        }
        
        Debug.Log("감지된 유령의 수: "+i);
    }
}
