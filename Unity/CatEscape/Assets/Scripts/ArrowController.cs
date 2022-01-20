using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    GameObject hpGauge;
    PlayerController player;
    GameDirector gameDirector;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("dochi").GetComponent<PlayerController>();
        this.hpGauge = GameObject.Find("hpGauge");
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
    }

    public float speed = 1.0f;
    public void Init(float speed, Vector3 initPos)
    {
        //Start���� ���� ȣ��� 
        this.speed = speed;
        this.transform.position = initPos;
    }



    // Update is called once per frame
    void Update()
    {
        if (this.gameDirector.isGameOver) return;
        transform.Translate(0, -0.1f, 0);//�ӵ� -0.1�� ��������
        
        if (transform.position.y< -4.03f)//-4.03�� �����ϸ� �������
        {
            Destroy(gameObject);
            
            ScoreManager.score += 1;//���� �������� ���� 1�� �߰�
        }
        Vector2 p1 = transform.position;//ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;//�÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;//�߽ɰ��� �Ÿ�
        float r1 = 0.5f;//ȭ���� �ݰ��� 0.5
        float r2 = 1.0f;//�÷��̾��� �ݰ��� 1.0

        if(d<r1+r2)//ȭ���� �ݰ�� �÷��̾� �ݰ��� ��ģ ���� 2���� ���� �Ÿ����� ������(�浹)
        {
            //GameObject director = GameObject.Find("GameDirector");//gamedirector���� ������ �Ǳ��̰�
            //director.GetComponent<GameDirector>().DecreaseHp();
            this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
            this.player.Hit(1);

            Destroy(gameObject);//ȭ���� ����
        }
        
        
        
    }
}
