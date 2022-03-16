using System.Collections;         // 회색으로 표시되는 using 구문은
using System.Collections.Generic; // 선언은 되었으나 사용된 곳이 없다는 의미
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




