using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public int damage;
    public float hp;
    public string myName;
    public bool isDie;
    public string[] arr;
    public GameObject PlayerGo;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 playerPos = new Vector2(2, 3);
        Vector2 monsterPos = new Vector2(5, 8);
        float distance = Vector2.Distance(playerPos, monsterPos);
        Debug.Log(distance);

        //Vector2 startPos = new Vector2(2.0f, 1.0f);
        //Vector2 endPos = new Vector2(8.0f, 5.0f);
        //Vector2 direction = endPos - startPos;
        //Debug.Log(direction);

        //float length = direction.magnitude;//magnitude를 사용하여 길이구하기
        //Debug.Log(length);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
