using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject hpGauge;
    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player").GetComponent<PlayerController>();
        this.hpGauge = GameObject.Find("hpGauge");
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);//속도 -0.1로 떨어진다
        
        if (transform.position.y< -4.03f)//-4.03에 도착하면 사라진다
        {
            Destroy(gameObject);
            
            ScoreManager.score += 1;//땅에 떨어지면 점수 1점 추가
        }
        Vector2 p1 = transform.position;//화살의 중심 좌표
        Vector2 p2 = this.player.transform.position;//플레이어의 중심 좌표
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;//중심간의 거리
        float r1 = 0.5f;//화살의 반경이 0.5
        float r2 = 1.0f;//플레이어의 반경이 1.0

        if(d<r1+r2)//화살의 반경과 플레이어 반경을 합친 값이 2개의 값의 거리보다 적으면(충돌)
        {
            //GameObject director = GameObject.Find("GameDirector");//gamedirector에게 맞으면 피깍이게
            //director.GetComponent<GameDirector>().DecreaseHp();

            this.player.Hit(1);

            Destroy(gameObject);//화살을 제거
        }
        
        
        
    }
}
