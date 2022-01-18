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
        //���콺�� ������  
        if(Input.GetMouseButtonDown(0))//�������� �ϸ� ���󰡴°�
        {
            this.startPos = Input.mousePosition;//���� ���� ����
        }
        //���콺�� ����
        else if (Input.GetMouseButtonUp(0))
        {
            Vector3 endPos = Input.mousePosition;//���� ���� ����
            float swipelength = endPos.y - this.startPos.y;//������������ ����

            this.speed = (swipelength / 30.0f)*Time.deltaTime;//�̵� �ӵ� �ʱ�ȭ
            
            
        }
        this.rotSpeed = 20;
        transform.Rotate(new Vector3(0, 0, this.rotSpeed));
        transform.Translate(new Vector3(0, this.speed,0),Space.World);//���ǵ�
        this.speed *= 0.98f;
        
        
    }
}
