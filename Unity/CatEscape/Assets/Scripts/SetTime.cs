using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTime : MonoBehaviour
{
    public float LimitTime;
    public Text text_timer;
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

        LimitTime -= Time.deltaTime;
        text_timer.text = "" + Mathf.Round(LimitTime);
    }
}
