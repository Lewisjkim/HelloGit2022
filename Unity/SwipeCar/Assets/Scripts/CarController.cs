using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector3 startPos;
    Vector3 endPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
            //this.speed = 0.2f; //초기속도 설정
        }
        if(Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;
            float swipelength = this.endPos.x - this.startPos.x;
            this.speed = swipelength / 500;

            
        }
        this.transform.Translate(this.speed, 0, 0); //x축으로 이동한다
        this.speed *= 0.98f;//감속
    }
}
