using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");//Hierarchy에있는 car를 찾는다
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");//
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        if(length>=0)
        {
            this.distance.GetComponent<Text>().text = "목표지점까지" + length.ToString("F2") + "m";//텍스트에 해당내용 추가
        }
        else
        {
            this.distance.GetComponent<Text>().text = "게임 오버";//플레그를 지나면 게임오버
        }
    }
}
