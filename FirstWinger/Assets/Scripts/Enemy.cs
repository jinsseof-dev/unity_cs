using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public enum State
    {
        None = -1, // ��� ��
        Ready = 0, // �غ� �Ϸ�
        Appear,    // ����
        Battle,    // ���� ��
        Dead,      // ���
        Disappear, // ����
    }

    [SerializeField]
    State CurrentState = State.None;

    const float MaxSpeed = 10.0f;    // ���� ����ġ�� �������� �ʵ��� ����

    const float MaxSpeedTime = 0.5f; // �� ����Ⱑ ������ �� �ڿ������� ������ �̷�������� ����

    [SerializeField]
    Vector3 TargetPosition;

    [SerializeField]
    float CurrentSpeed;

    Vector3 CurrentVelocity;

    float MoveStartTime = 0.0f;

    [SerializeField]
    Transform FireTransform;

    [SerializeField]
    GameObject Bullet;

    [SerializeField]
    float BulletSpeed = 1;

    float LastBattleUpdateTime = 0.0f;

    [SerializeField]
    int FireRemainCount = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        switch (CurrentState)
        {
            case State.None:
            case State.Ready:
                break;
            case State.Dead:
                break;
            case State.Appear:
            case State.Disappear:
                UpdateSpeed();
                UpdateMove();
                break;
            case State.Battle:
                UpdateBattle();
                break;
        }
    }

    void UpdateSpeed()
    {
        CurrentSpeed = Mathf.Lerp(CurrentSpeed, MaxSpeed, (Time.time - MoveStartTime) / MaxSpeedTime); // �� �� ������ ��򰡸� ��ȯ��
    }

    void UpdateMove()
    {
        float distance = Vector3.Distance(TargetPosition, transform.position);
        if (distance == 0)
        {
            Arrived();
            return;
        }
        // 
        CurrentVelocity = (TargetPosition - transform.position).normalized * CurrentSpeed;

        // �ӵ� = �Ÿ� / �ð� �̹Ƿ� �ð� = �Ÿ� / �ӵ�
        transform.position = Vector3.SmoothDamp(transform.position, TargetPosition, ref CurrentVelocity, distance / CurrentSpeed, MaxSpeed);
    }



    void Arrived()
    {
        CurrentSpeed = 0.0f;
        if (CurrentState == State.Appear)
        {
            CurrentState = State.Battle;
            LastBattleUpdateTime = Time.time;
        }
        else if (CurrentState == State.Disappear)
        {
            CurrentState = State.None;
        }
    }

    public void Appear(Vector3 targetPos)
    {
        TargetPosition = targetPos;
        CurrentSpeed = MaxSpeed;

        CurrentState = State.Appear;
        MoveStartTime = Time.time;
    }


    void Disappear(Vector3 targetPos)
    {
        TargetPosition = targetPos;
        CurrentSpeed = 0;
        CurrentState = State.Disappear;
        MoveStartTime = Time.time;
    }

    void UpdateBattle()
    {
        if (Time.time - LastBattleUpdateTime > 3.0f)
        {
            //Debug.Log("time : " + Time.time + "// BattleStartTime : " + LastBattleUpdateTime + " // Diff : " + (Time.time - LastBattleUpdateTime));
            if (FireRemainCount > 0)
            {
                Fire();
                FireRemainCount--;
            }
            else
            {
                Disappear(new Vector3(-15.0f, transform.position.y, transform.position.z));
            }
            LastBattleUpdateTime = Time.time;
        }

    }

    private void OnTriggerEnter(Collider other) // other�� �� ������Ʈ�� �ε��� �ٸ�(other) Collider�� �ǹ�
    {
        Debug.Log("(Enemy) other = " + other.name); // other Collider�� ���� Ȯ��

        Player player = other.GetComponentInParent<Player>(); // �ε��� ������Ʈ�� ������Ʈ ȹ��
        if (player)
        {
            player.OnCrash(this); // player���� Crash �̺�Ʈ ����
        }
    }
    public void OnCrash(Player player)
    {
        Debug.Log("(Enemy) OnCrash player = " + player.name);
    }

    public void Fire()
    {
        GameObject go = Instantiate(Bullet);

        Bullet bullet = go.GetComponent<Bullet>();
        bullet.Fire(OwnerSide.Enemy, FireTransform.position, -FireTransform.right, BulletSpeed);

    }
}
