using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameDirector : MonoBehaviour
{
    GameObject player, portal, distance;       //player = ĳ����, portal = ��ǥ��, distance = �Ÿ�ǥ���� ui ���ӿ�����Ʈ�� ����


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
            this.distance.GetComponent<Text>().text = "��ǥ����" + " : " + lengthDis.ToString("F2") + "m";  // ToString("D����")������, ToString("F����") �Ǽ���
        }
        else
        {
            this.distance.GetComponent<Text>().text = "GameOver";
        }
    
    }
}
