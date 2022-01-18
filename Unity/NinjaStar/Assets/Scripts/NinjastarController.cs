using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjastarController : MonoBehaviour
{
    float speed = 0;
    float rotSpeed = 0;
    Vector2 startPos;
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
            Vector2 endPos = Input.mousePosition;//���� ���� ����
            float swipelength = endPos.y - this.startPos.y;//������������ ����
            this.speed = swipelength / 800.0f;//�̵� �ӵ� �ʱ�ȭ
            transform.Translate(0, 1, 0, Space.World);
            //transform.Translate(0, this.speed, 0); //y�� �������� �̵�
            this.rotSpeed = 10;
            transform.Rotate(0, 0, this.rotSpeed);

        }
        this.speed *= 0.98f;
        
        this.rotSpeed *= 0.96f;
        
    }
}
