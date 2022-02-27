using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController2 : MonoBehaviour
{
    public GameObject bulletObject;
    public Transform bulletContainer;
    public GameObject guideLine;
    
    public float ditectionRange = 4f;


    private Camera mainCamera;
    
    // 마우스의 위치에 따라서 가이드 라인이 생기고 미사일이 발사
    // 카메라 위에 마우스의 좌표가 어떻게 나오는지 알기 위해서
    void Start()
    {
        // 현재 사용하고 있는 카메라 객체가 들어가게 됩니다.
        mainCamera = Camera.main; // 카메라도 하나의 객체로 처리됩니다.
    }

    void Update()
    {
        MouseCheck();
        
        // 마우스 좌클릭 이벤트가 밸생하면 true
        if (Input.GetMouseButtonDown(0))
        {
            // 화면상 마우스의 위치를 구해서 게임내좌표로 변환
            Vector2 mousePos = Input.mousePosition;
            mousePos = mainCamera.ScreenToWorldPoint(mousePos);

            Vector3 playerPos = transform.position; //플레이어 오브젝트 위치 구해옴
            
            Vector2 dirVec = mousePos - (Vector2)playerPos; // 벡터를 만듦
            dirVec = dirVec.normalized; // 방향 벡터(dirVec=direction Vector)를 만듦

            GameObject tempObject = Instantiate(bulletObject, bulletContainer); // 총알 오브젝트 생성
            tempObject.transform.right = dirVec; // 총알에 방향 벡터 설정(from 플레이어 to 마우스 방향)

            // 총알이 플레이어보다 살짝 앞에서 발사하도록 값을 조금 줌
            tempObject.transform.position = (Vector2)playerPos + dirVec * 0.5f;

            // 총알의 발사 방향의 반대(-dirVec)로 플레이어에게 방향 벡터 적용
            //transform.Translate(-dirVec);

            // 더 강한 힘을 주어서 이동시키려면 방향 벡터에 값을 곱해줌
            transform.Translate(-dirVec * 3);
        }
    }

   
    void MouseCheck()
    {
        // 마우스의 위치값을 받아옴. mousePos는 좌하단이 0, 후상단이 최댓값.
        Vector2 mousePos = Input.mousePosition;
        //Debug.Log(mousePos);

        // 화면상에서의 현재 마우스 좌표값을 게임 내에서의 마우스 Position 값으로 변환
        mousePos = mainCamera.ScreenToWorldPoint(mousePos);
        //Debug.Log(mousePos);

        Vector3 playerPos = transform.position;
        
        // 플레이어 오브젝트에서 마우스 좌표 방향으로 가이라인을 그려야 하기 때문에
        // 오브젝트와 마우스 위치의 벡터는 마우스좌표(mousePos) - (플레이어좌표)playerPos로 연산
        Vector2 distanceVec = mousePos - (Vector2)playerPos;

        // 일정 거리 안에 들어가면 가이드 라인이 활성화 되는 로직을 구현해야 함
        // magnitude 속성을 이용해서 거리를 바로 구해낼 수 있음.(sqrMagnitude는 거리의 제곱)
        // 거리를 삼항 연산자를 이용해서 판단
        guideLine.SetActive(distanceVec.magnitude < ditectionRange ? true : false);

        // 가이드라인의 방향을 distanceVec의 방향벡터로 설정한다는 의미
        // 벡터.normalized를 하면 방향 벡터가 나옴
        // distanceVec.normailzed = distanceVec / distanceVec.magnitude
        // 방향 관련된 것은 모두 방향 벡터로 설정
        guideLine.transform.right = distanceVec.normalized;
    }
}
