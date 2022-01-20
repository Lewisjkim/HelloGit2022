using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour
{
    
    public GameObject arrowPrefab;
    float span = 0.5f;
    float delta = 0; //시간 누적
    GameDirector gameDirector;

    // Start is called before the first frame update
    void Start()
    {
        this.gameDirector = GameObject.FindObjectOfType<GameDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameDirector.isGameOver) return;

        this.delta += Time.deltaTime;
        if(this.delta >= this.span)
        {
            this.delta = 0;

            GameObject go = Instantiate<GameObject>(this.arrowPrefab);
            var arrowController = go.GetComponent<ArrowController>();
            int rSpeed = Random.Range(-6, 7);
            var randPosX = Random.Range(-8f, 9f);
            arrowController.Init(rSpeed, new Vector3(randPosX, 4, 0));
            //go.transform.position = new Vector3(px, 7, 0);
        }
        
    }

}
