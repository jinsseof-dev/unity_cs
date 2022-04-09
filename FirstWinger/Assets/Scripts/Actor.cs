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
    public bool isDead = false; // ��� �޾ư� player�� enemy���� public�� �ƴϸ� scope ���� �߻�


    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        CurrentHP = MaxHP; // ����HP�� �ʱⰪ�� �ִ�HP�� ����
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
