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
        //점프한다
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }
        //좌우 이동
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;//오른쪽 누르면 key값이 1이 되고
        Debug.Log("오른쪽");
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;//왼쪽 누르면 key값이 -1이 되고
        Debug.Log("왼쪽");

        //플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x); //abs: absolute value
                                                           //velocity: Linear velocity of the rigidbody in  unit per second

        //스피드 제한
        if(speedx < this.maxWalfSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //움직이는 방향에 따라 반전한다
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
