using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab) as GameObject;//밤송이 프리팹의 인스턴스를 만든다
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            bamsongi.GetComponent<BamsongiController>().Shoot(worldDir.normalized*2000);
        }
    }
}
