using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LButtonDown()
    {
        transform.Translate(-2, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(2, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))//왼쪽으로 3 움직인다
        {
            transform.Translate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))//오른쪽으로 3 움직인다
        {
            transform.Translate(2, 0, 0);
        }
    }
}
