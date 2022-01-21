using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//LoadScene을 사용하는데 필요

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680f;
    float walkForce = 30f;
    float maxWalkSpeed = 2.0f;
    //float threshold = 0.2f; //문지방,한계정을 0.2로 제한하기 위해

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //점프한다
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)//스페이스바를 누르거나 velocity=속도 가 0이면 
        {
            this.animator.SetTrigger("JumpTrigger");//점프애니메이션의 트리거로 설정
            this.rigid2D.AddForce(transform.up * this.jumpForce);//위쪽으로 * 680으로 힘을 준다
        }
        //if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)//화면을 터치하거나 velocity=속도 가 0이면 
        //{
        //    this.animator.SetTrigger("JumpTrigger");
        //    this.rigid2D.AddForce(transform.up * this.jumpForce);//위쪽으로 * 680으로 힘을 준다
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    this.rigid2D.AddForce(transform.up * this.jumpForce);
        //}

        //좌우 이동
        float key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;//오른쪽 누르면 key값이 1이 되고
        //Debug.Log("오른쪽");
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;//왼쪽 누르면 key값이 -1이 되고
        //Debug.Log("왼쪽");
        //if (Input.acceleration.x > this.threshold) key = 0.5f;//가속도 센서
        //if (Input.acceleration.x < -this.threshold) key = -0.5f;

        //플레이어 속도
        float speedx = Mathf.Abs(this.rigid2D.velocity.x/**Time.deltaTime*/); //abs: absolute value //time.deltatime 은 기기 간의 속도 차이 없애기 위해
                                                           //velocity: Linear velocity of the rigidbody in  unit per second

        //스피드 제한
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //움직이는 방향에 따라 반전한다
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //플레이어 속도에 맞춰 애니메이션 속도를 바꾼다
        if (this.rigid2D.velocity.y == 0) //리지드2D의 높이가 0이면
        {
            this.animator.speed = speedx / 2.0f;//애니메이션 속도는 2.0으로 맞추고
        }
        else//아니면
        {
            this.animator.speed = 1.0f;
        }
        //플레이어가 화면 밖으로 나갔다면 처음부터
        if (transform.position.y<-10)
        {
            SceneManager.LoadScene("GameScene");
        }

        //
    }


    //--------------------------------------------------------------------------------------------------------------
    
    
    //골 도착
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("골");
        SceneManager.LoadScene("ClearScene");
    }
    
}
