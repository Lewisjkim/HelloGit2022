using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//LoadScene�� ����ϴµ� �ʿ�

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 680f;
    float walkForce = 30f;
    float maxWalkSpeed = 2.0f;
    //float threshold = 0.2f; //������,�Ѱ����� 0.2�� �����ϱ� ����

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ѵ�
        if (Input.GetKeyDown(KeyCode.Space) && this.rigid2D.velocity.y == 0)//�����̽��ٸ� �����ų� velocity=�ӵ� �� 0�̸� 
        {
            this.animator.SetTrigger("JumpTrigger");//�����ִϸ��̼��� Ʈ���ŷ� ����
            this.rigid2D.AddForce(transform.up * this.jumpForce);//�������� * 680���� ���� �ش�
        }
        //if (Input.GetMouseButtonDown(0) && this.rigid2D.velocity.y == 0)//ȭ���� ��ġ�ϰų� velocity=�ӵ� �� 0�̸� 
        //{
        //    this.animator.SetTrigger("JumpTrigger");
        //    this.rigid2D.AddForce(transform.up * this.jumpForce);//�������� * 680���� ���� �ش�
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    this.rigid2D.AddForce(transform.up * this.jumpForce);
        //}

        //�¿� �̵�
        float key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;//������ ������ key���� 1�� �ǰ�
        //Debug.Log("������");
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;//���� ������ key���� -1�� �ǰ�
        //Debug.Log("����");
        //if (Input.acceleration.x > this.threshold) key = 0.5f;//���ӵ� ����
        //if (Input.acceleration.x < -this.threshold) key = -0.5f;

        //�÷��̾� �ӵ�
        float speedx = Mathf.Abs(this.rigid2D.velocity.x/**Time.deltaTime*/); //abs: absolute value //time.deltatime �� ��� ���� �ӵ� ���� ���ֱ� ����
                                                           //velocity: Linear velocity of the rigidbody in  unit per second

        //���ǵ� ����
        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        //�����̴� ���⿡ ���� �����Ѵ�
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        //�÷��̾� �ӵ��� ���� �ִϸ��̼� �ӵ��� �ٲ۴�
        if (this.rigid2D.velocity.y == 0) //������2D�� ���̰� 0�̸�
        {
            this.animator.speed = speedx / 2.0f;//�ִϸ��̼� �ӵ��� 2.0���� ���߰�
        }
        else//�ƴϸ�
        {
            this.animator.speed = 1.0f;
        }
        //�÷��̾ ȭ�� ������ �����ٸ� ó������
        if (transform.position.y<-10)
        {
            SceneManager.LoadScene("GameScene");
        }

        //
    }


    //--------------------------------------------------------------------------------------------------------------
    
    
    //�� ����
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("��");
        SceneManager.LoadScene("ClearScene");
    }
    
}
