using System.Collections;         // ȸ������ ǥ�õǴ� using ������
using System.Collections.Generic; // ������ �Ǿ����� ���� ���� ���ٴ� �ǹ�
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
    int myValue;
    [SerializeField]
    int myValue1;
    [SerializeField]
    int myValue2;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start() Log - myValue =" + myValue);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update() Log");
    }
}




