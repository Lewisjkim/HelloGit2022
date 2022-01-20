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
        Vector3 playerPos = this.cat.transform.position;//캣의 포지션을 playerPos라하고
        //플레이어의 y축 포지션의 위치에 따라 움직이게 한다
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
    }
}
