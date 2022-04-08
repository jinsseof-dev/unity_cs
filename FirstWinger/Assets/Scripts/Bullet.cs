using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum OwnerSide: int
{
    Player = 0,
    Enemy
}
public class Bullet : MonoBehaviour
{
    const float LifeTime = 15.0f;

    OwnerSide ownerSide = OwnerSide.Player;
    [SerializeField]
    Vector3 MoveDirection = Vector3.zero;

    [SerializeField]
    float Speed = 0.0f;

    bool NeedMove = false;

    float FiredTime;
    bool Hited = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ProcessDisappearCondition())
        {
            return;
        }
        UpdateMove();
    }

    void UpdateMove()
    {
        if (!NeedMove)
        {
            return;
        }

        Vector3 moveVector = MoveDirection.normalized * Speed * Time.deltaTime;

        transform.position += moveVector;
    }

    public void Fire(OwnerSide FireOwner, Vector3 firePosition, Vector3 direction, float speed)
    {
        ownerSide = FireOwner;
        transform.position = firePosition;
        MoveDirection = direction;
        Speed = speed;
        // 이대로도 총알이 날아갈텐데 추가 작업을 ㅎ자ㅏ

        NeedMove = true;
        FiredTime = Time.time;
    }


    Vector3 AdjustMove(Vector3 moveVector)
    {
        RaycastHit hitInfo;
        
        if (Physics.Linecast(transform.position, transform.position + moveVector, out hitInfo))
        {
            moveVector = hitInfo.point - transform.position;
            OnBulletCollision(hitInfo.collider);
        }
        return moveVector;
    }

    void OnBulletCollision(Collider collider)
    {
        if (Hited)
        {
            return;
        }


        if (collider.gameObject.layer == LayerMask.NameToLayer("EnemyBullet")
         || collider.gameObject.layer == LayerMask.NameToLayer("PlayerBullet")
        {
            return;
        }
        ;// Layer 이름으로 int값을 얻을 수 있음


        Collider myCollider = GetComponentInChildren<Collider>();
        myCollider.enabled = false;

        Hited = true;
        NeedMove = false;

        Debug.Log("OnBulletCollision collider = " + collider.name);

        if (ownerSide == OwnerSide.Player)
        {
            Enemy enemy = collider.GetComponentInParent<Enemy>();
        }
        else
        {
            Player player = collider.GetComponentInParent<Player>();
        }
    }



    bool ProcessDisappearCondition()
    {
        if (transform.position.x > 15.0f || transform.position.x < -15.0f
         || transform.position.y > 15.0f || transform.position.y < -15.0f)
        {
            Debug.Log("bullet transform: " + transform);
            //ProcessDisappearCondition();
            return true;
        }
        else if (Time.time - FiredTime > LifeTime)
        {
            Disappear();
            return true;
        }

        return false;
    }

    void Disappear()
    {
        Debug.Log("Bullet Disappeared");
    }
}
