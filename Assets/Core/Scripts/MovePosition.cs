using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  1.
//  �ݵ�� MonoBehaviour ��� Ŭ������ ��ӵǾ� �־�� �Ѵ�
//  Component  !

//  2.  ���ϸ�� Ŭ�������� �׻� ���ƾ� �Ѵ�
public class MovePosition : MonoBehaviour
{
    //  ����Ƽ �÷ο���Ʈ (����**)

    //  Start ?
    //  �÷��� �Ǿ��� �� �� �� ���� ȣ��ȴ�
    void Start()
    {
        //  �ּ� ?
        //  �� �۴�� �ΰ� ������ �ڵ忡�� ���ܵȴ�  (�޸� ���� ����)
        //  �ּ� �� ���� �ϴ� ��� : ��Ʈ�� + K, C
        //  �ּ� �� ���� Ǫ�� ��� : ��Ʈ�� + K, U

        //Debug.Log("Start!");    //  Console â�� ������!
        //Debug.LogWarning("�� �Լ��� ��� ǥ���Ѵ�!");    //  �� ��ɰ� �Ȱ����� ��� ������ �޾��ش�
        ////�� ��ɰ� ������, �� ������ ����Ǹ�
        ////������ �Ͻ����� �ȴ�
        //Debug.LogError("�� �Լ��� ���� ������ ǥ���Ѵ�");

    }


    //  Update  ?
    //  �� �����Ӹ��� ȣ��ȴ�
    //  ������ ?   ->  FPS
    //  �׳� ��� �ݺ��ȴ�! 
    void Update()
    {
        Rigidbody body = GetComponent<Rigidbody>();
        //  Vector3?
        //  X, Y, Z ���� ������ �ִ� ����ü

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
        //  ť�� �ȿ� �ִ� ������Ʈ(��ǰ �������� ���)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(0, 50.0f, 0,ForceMode.Impulse);//Force = ���� /  Impulse = �߰�
        }

        //  ȸ��
        if(Input.GetKey(KeyCode.Q)) //  �������� ȸ��
        {
            transform.Rotate(0,1.0f,0);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, -1.0f, 0);
        }

        

    }
}
