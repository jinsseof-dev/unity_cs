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
    OwnerSide ownerSide = OwnerSide.Player;
    [SerializeField]
    Vector3 MoveDirection = Vector3.zero;

    [SerializeField]
    float Speed = 0.0f;

    bool NeedMove = false;

    bool Hited = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }


    Vector3 AdjustMove(Vector3 moveVector)
    {
        RaycastHit hitInfo;
        
        if (Physics.Linecast(transform.position, transform.position + moveVector, out hitInfo))
        {
            moveVector = hitInfo.point;
        }
        return moveVector;
    }

    void OnBulletCollision(Collider collider)
    {
        if (Hited)
        {
            return;
        }

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
}
