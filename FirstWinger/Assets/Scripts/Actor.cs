using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : MonoBehaviour
{
    [SerializeField]
    protected int MaxHP = 100;


    [SerializeField]
    protected int CurrentHP;


    [SerializeField]
    protected int Damage = 1;

    [SerializeField]
    protected int crashDamage = 100;

    [SerializeField]
    public bool isDead = false; // 상속 받아간 player와 enemy에서 public이 아니면 scope 에러 발생


    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        CurrentHP = MaxHP; // 현재HP의 초기값을 최대HP로 설정
    }

    // Update is called once per frame
    void Update()
    {
        UpdateActor();
    }
    
    protected virtual void UpdateActor()
    {

    }

    public virtual void OnBulletHited(int damage)
    {
        Debug.Log("OnBulletHited damage = " + damage);
        DecreaseHP(damage);
    }

    void DecreaseHP(int value)
    {
        if (isDead)
        {
            return;
        }

        CurrentHP -= value;

        if (CurrentHP < 0)
        {
            CurrentHP = 0;
        }
        if (CurrentHP == 0)
        {
            OnDead();
        }
    }

    protected virtual void OnDead()
    {
        Debug.Log(name + "OnDead");
        isDead = true;
    }

}
