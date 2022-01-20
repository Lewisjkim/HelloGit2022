using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject cat;//cat image

    // Start is called before the first frame update
    void Start()
    {
        this.cat = GameObject.Find("cat");//findthe gameobject name "cat'
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = this.cat.transform.position;//Ĺ�� �������� playerPos���ϰ�
        //�÷��̾��� y�� �������� ��ġ�� ���� �����̰� �Ѵ�
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}
