using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PlayerController : MonoBehaviour
{
    
    public int hp=100;
    public int maxHp= 100;

    public Action<float> OnHit;
    public Action OnDie;
    public GameDirector gameDirector;
    
    // Start is called before the first frame update
    void Start()
    {
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
    }
    
    public void LButtonDown()
    {
        this.MoveLeft();
    }
    public void RButtonDown()
    {
        this.MoveRight();
            
    }

    private void MoveLeft() {

        if (this.gameDirector.isGameOver) return;
        
        if (transform.position.x > -8.0)//범위제한
        {
            transform.Translate(-1, 0, 0);
        }
    }

    private void MoveRight() {

        if (this.gameDirector.isGameOver) return;

        if (transform.position.x < 8.0)
        {
            transform.Translate(1, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))//왼쪽으로 2 움직인다
        {
            this.MoveLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))//오른쪽으로 2 움직인다
        {
            this.MoveRight();
        }
    }

    public void Hit(int damage) {
        this.hp -= damage;

        if (this.hp <= 0) {
            this.hp = 0;
            this.Die();
        }

        var per = ((float)this.hp / this.maxHp) * 100f;
        this.OnHit(per);
    }

    private void Die() {
        Debug.Log("die");
        this.OnDie();
    }

    public float GetHpPercentage() {
        return ((float)this.hp / this.maxHp) * 100f;
    }
}
