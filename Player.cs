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
            this.startPos = Input.mousePosition;    //마우스버튼으로 눌렀을때의 위치값
        }else if(Input.GetMouseButtonUp(0))
            {
            this.endPos = Input.mousePosition;  //마우스버튼으로 눌렀다가 땠을때의 위치값
            float length = (this.endPos.x - this.startPos.x);  //마지막 좌표값 - 처음좌표값(x의)
            this.speed = length / speedCoefficient;
            GetComponent<AudioSource>().Play();
        }
        transform.Translate(this.speed * Time.deltaTime, 0, 0);  //x방향으로 speed만큼 이동
        this.speed *= 0.98f; //감속

    }
}
