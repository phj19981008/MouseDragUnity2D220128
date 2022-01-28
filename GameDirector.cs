using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject player, portal, distance;       //player = 캐릭터, portal = 목표물, distance = 거리표시할 ui 게임오브젝트형 변수


    void Start()
    {
        this.player = GameObject.Find("player1");
        this.portal = GameObject.Find("portal");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.portal.transform.position.x - this.player.transform.position.x;        
        if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표지점" + " : " + lengthDis.ToString("F2") + "m";  // ToString("D숫자")정수형, ToString("F숫자") 실수형
        }
        else
        {
            this.distance.GetComponent<Text>().text = "GameOver";
        }
    
    }
}
