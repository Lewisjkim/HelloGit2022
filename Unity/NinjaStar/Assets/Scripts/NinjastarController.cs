using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjastarController : MonoBehaviour
{
    float speed = 0;
    float rotSpeed = 0;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스를 누르면  
        if(Input.GetMouseButtonDown(0))//스와이프 하면 날라가는거
        {
            this.startPos = Input.mousePosition;//시작 지점 지정
        }
        //마우스를 때면
        else if (Input.GetMouseButtonUp(0))
        {
            Vector3 endPos = Input.mousePosition;//종료 지점 지정
            float swipelength = endPos.y - this.startPos.y;//스와이프렝스 정의

            this.speed = (swipelength / 30.0f)*Time.deltaTime;//이동 속도 초기화
            
            
        }
        this.rotSpeed = 20;
        transform.Rotate(new Vector3(0, 0, this.rotSpeed));
        transform.Translate(new Vector3(0, this.speed,0),Space.World);//스피드
        this.speed *= 0.98f;
        
        
    }
}
