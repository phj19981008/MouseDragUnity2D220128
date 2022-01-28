using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector2 startPos, endPos;
    public float speed, speedCoefficient;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;    //���콺��ư���� ���������� ��ġ��
        }else if(Input.GetMouseButtonUp(0))
            {
            this.endPos = Input.mousePosition;  //���콺��ư���� �����ٰ� �������� ��ġ��
            float length = (this.endPos.x - this.startPos.x);  //������ ��ǥ�� - ó����ǥ��(x��)
            this.speed = length / speedCoefficient;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed * Time.deltaTime, 0, 0);  //x�������� speed��ŭ �̵�
        this.speed *= 0.98f; //����

    }
}
