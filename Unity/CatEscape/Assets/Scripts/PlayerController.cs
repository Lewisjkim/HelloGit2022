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
        if (Input.GetKeyDown(KeyCode.LeftArrow))//�������� 3 �����δ�
        {
            transform.Translate(-2, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))//���������� 3 �����δ�
        {
            transform.Translate(2, 0, 0);
        }
    }
}
