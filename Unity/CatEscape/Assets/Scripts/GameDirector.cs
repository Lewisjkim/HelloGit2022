using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    //GameObject arrowPrefab;
    GameObject playerGo;
    GameObject hpGauge;
    
    GameObject gameoverGo;

    public Text txtHpGaugePercentage;


    // Start is called before the first frame update
    void Start()
    {
        
        //this.arrowPrefab = GameObject.Find("arrowPrefab");
        this.playerGo = GameObject.Find("player");
        this.hpGauge = GameObject.Find("hpGauge");
        this.gameoverGo = GameObject.Find("GameOver");
        gameoverGo.SetActive(false);//�Ⱥ��̰��ϱ�

        var playerController = this.playerGo.GetComponent<PlayerController>();

        //player hp percentage text �ʱ�ȭ 
        this.txtHpGaugePercentage.text = string.Format("{0}%", playerController.GetHpPercentage());

        playerController.OnDie = () => {
            this.GameOver();
        };
        playerController.OnHit = (per) => {
            Debug.LogFormat("per: {0}", per);
            this.txtHpGaugePercentage.text = string.Format("{0}%", per);
        };
        //var per = ((float)playerController.hp / playerController.maxHp) * 100;
        

    }

    public bool isGameOver;
    private void GameOver() {
        if (this.isGameOver == false)
        {
            this.isGameOver = true;
            Debug.Log("GAME OVER");
            gameoverGo.SetActive(true);
        }
    }

    //private void Update()
    //{
        
    //}

    //public void DecreaseHp()
    //{
    //    this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
        
    //    if(this.hpGauge.GetComponent<Image>().fillAmount == 0f)
    //    {
    //        GameOver.SetActive(true);//���ӿ��� Ȱ��ȭ
    //        //this.arrowPrefab.SetActive(false);
    //    }
    //}
    
    
}
