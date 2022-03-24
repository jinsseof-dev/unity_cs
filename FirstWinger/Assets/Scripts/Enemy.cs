using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum State
    {
        None = -1, // 사용 전
        Ready = 0, // 준비 완료
        Appear,    // 등장
        Battle,    // 전투 중
        Dead,      // 사망
        Disappear, // 퇴장
    }

    [SerializeField]
    State CurrentState = State.None;

    const float MaxSpeed = 10.0f;    // 적이 지나치게 빨라지지 않도록 제한

    const float MaxSpeedTime = 0.5f; // 적 비행기가 퇴장할 때 자연스러운 가속이 이루어지도록 정의

    [SerializeField]
    Vector3 TargetPosition;

    [SerializeField]
    float CurrentSpeed;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateSpeed()
    {

    }

    void UpdateMove()
    {

    }



    void Arrived()
    {

    }

    public void Appear(Vector3 targetPos)
    {
        TargetPosition = targetPos;
        CurrentSpeed = MaxSpeed;

        CurrentState = State.Appear;
    }


    void Disappear(Vector3 targetPos)
    {
        TargetPosition = targetPos;
        CurrentSpeed = 0;
        CurrentState = State.Disappear;
    }
}
