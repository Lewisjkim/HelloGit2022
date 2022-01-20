using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    float jumpForce = 680f;
    float walkForce = 30f;
    float maxWalfSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ѵ�
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        //�¿� �̵�
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;//������ ������ key���� 1�� �ǰ�
        Debug.Log("������");
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;//���� ������ key���� -1�� �ǰ�
        Debug.Log("����");

        //�÷��̾� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.velocity.x); //abs: absolute value
                                                           //velocity: Linear velocity of the rigidbody in  unit per second

        //���ǵ� ����
        if(speedx < this.maxWalfSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //�����̴� ���⿡ ���� �����Ѵ�
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
