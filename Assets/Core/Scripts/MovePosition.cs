using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  1.
//  반드시 MonoBehaviour 라는 클래스가 상속되어 있어야 한다
//  Component  !

//  2.  파일명과 클래스명은 항상 같아야 한다
public class MovePosition : MonoBehaviour
{
    //  유니티 플로우차트 (참조**)

    //  Start ?
    //  플레이 되었을 때 단 한 번만 호출된다
    void Start()
    {
        //  주석 ?
        //  요 작대기 두개 있으면 코드에서 제외된다  (메모 같은 느낌)
        //  주석 한 번에 하는 방법 : 컨트롤 + K, C
        //  주석 한 번에 푸는 방법 : 컨트롤 + K, U

        //Debug.Log("Start!");    //  Console 창에 적힌다!
        //Debug.LogWarning("이 함수는 경고를 표시한다!");    //  위 기능과 똑같지만 경고 문구를 달아준다
        ////위 기능과 같지만, 이 문구가 실행되면
        ////게임이 일시정지 된다
        //Debug.LogError("이 함수는 에러 문구를 표시한다");

    }


    //  Update  ?
    //  매 프레임마다 호출된다
    //  프레임 ?   ->  FPS
    //  그냥 계속 반복된다! 
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        //  Vector3?
        //  X, Y, Z 값을 가지고 있는 구조체

        //Vector3 position = transform.position;
        //position.z += 0.05f;

        //transform.position = position;
        //transform.Translate(0, 0, 0.01f);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Translate(-0.02f, 0, 0);
            // transform.Rotate(-1.0f,0,0);
            body.AddForce(-0.5f, 0, 0, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //            transform.Translate(0.02f, 0, 0);
            body.AddForce(0.5f, 0, 0, ForceMode.Impulse);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            body.AddForce(0, 0, -0.5f, ForceMode.Impulse);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            body.AddForce(0, 0, 0.5f, ForceMode.Impulse);
        }
        //  큐브 안에 있는 컴포넌트(부품 가져오는 방법)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 50.0f, 0,ForceMode.Impulse);//Force = 강제 /  Impulse = 추가
        }

        //  회전
        if(Input.GetKey(KeyCode.Q)) //  왼쪽으로 회전
        {
            transform.Rotate(0,1.0f,0);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -1.0f, 0);
        }

        

    }
}
