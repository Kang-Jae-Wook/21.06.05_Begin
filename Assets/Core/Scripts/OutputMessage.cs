using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class OutputMessage : MonoBehaviour
{
    //  이 컴포넌트를 가진 객체가
    //  다른 콜라이더 (Collider, Rigidbody) 또는 리지드바디를 가진 객체와 만나면
    //  호출된다
    private void OnCollisionEnter(Collision collision)
    {
        //  rich Text ?
        //  서식있는 문자열    <b>내용</b> -> 굵은 글씨
        Debug.Log("<b>Win!</b>");
    }

}
