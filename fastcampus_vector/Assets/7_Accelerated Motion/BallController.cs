using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float shotVelocity;
    public float shotAngle;

    private Rigidbody2D ballRB2D;
    private bool isGround = true;
    private bool isCenter = false;
    private float totalTime = 0f;

    void Start()
    {
        // Rigidbody2D 객체를 멤버 변수에 받아옴
        ballRB2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // 사용자 키 입력을 받고 '스페이스바' 키가 눌리면 true
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(ShotBall());
        }
    }
    IEnumerator ShotBall()
    {
        Debug.Log("=== Simulation ===");
        
        // 오브젝트가 지면에 놓여있는지를 검증
        isGround = false;
        // 공의 각도를 설정.
        transform.right = new Vector2(Mathf.Cos(shotAngle * Mathf.Deg2Rad), Mathf.Sin(shotAngle * Mathf.Deg2Rad));
        // 설정된 각도로 shotVelocity 속도로 발사
        ballRB2D.velocity = transform.right * shotVelocity;

        // 시간을 0으로 초기화
        totalTime = 0f;
        while (true)
        {
            yield return null;
            
            // 땅바닥에 착지하면 isGround가 true가 되므로 탈출
            if (isGround) break;
            // ball이 땅바닥에 착지하기 전까지 시간을 계속 누적
            totalTime += Time.deltaTime;

            // y축 속도의 절댓값이 0에 가장 가까울 때(0.1f로 판단) && isCenter false일 때(단 1번만 동작하도록)
            if (Mathf.Abs(ballRB2D.velocity.y) < 0.1f && !isCenter)
            {
                isCenter = true;
                // 최고 높이(y축 속도의 절댓값이 가장 작을 때 = 하강 시작)를 로그로 출력
                Debug.Log("CenterHeight: " + transform.position.y);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D _col)
    {
        // 그라운드에 착지했을 때
        if(isGround == false)
        {
            isGround = true;
            // 속도를 0을 줘서 더이상 움직이지 않도록 제어
            ballRB2D.velocity = Vector2.zero;
            // 총 걸린 시간을 출력
            Debug.Log("Totaltime: " + totalTime);
            // 초기 위치가 -8에서 시작했기 때문에 +8로 보정
            Debug.Log("TotalMeter: " + (transform.position.x + 8));

            Verification();
        }
    }
    
    private void Verification()
    {
        // 유니티에서 계산한 것과 공식을 활용해서 직접 계산한 결과가 같은지 검증
        Debug.Log("=== Verification ===");

        // 총 걸린 시간은 2t
        // 2 * V * sin(theta) / g = 2 * shotVelocity * Mathf.Sin(shotAngle * Mathf.Deg2Rad) / 9.81f
        float totalTime = 2 * shotVelocity * Mathf.Sin(shotAngle * Mathf.Deg2Rad) / 9.81f;

        // 최고 높이
        // (V * sin(theta))^2 / 2 * g = Mathf.Pow(shotVelocity * Mathf.Sin(shotAngle * Mathf.Deg2Rad), 2) / (2*9.81f)
        float centerHeight = Mathf.Pow(shotVelocity * Mathf.Sin(shotAngle * Mathf.Deg2Rad), 2) / (2*9.81f); // Pow() = 제곱

        // 총 날아간 거리
        // 2 * v^2 * sin(theta) * cos(theta) / g = v^2 / g * sin(2*theta) =  Mathf.Pow(shotVelocity,2) / 9.81f * Mathf.Sin(2 * shotAngle * Mathf.Deg2Rad)
        // 2 * sin(theta) * cos(theta) == sin(2theta) 식을 사용
        float totalMeter = Mathf.Pow(shotVelocity,2) / 9.81f * Mathf.Sin(2 * shotAngle * Mathf.Deg2Rad);

        Debug.Log("Totaltime: " + totalTime);
        Debug.Log("CenterHeight: " + centerHeight);
        Debug.Log("TotalMeter: " + totalMeter);
    }
}
