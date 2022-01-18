using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);//�ӵ� -0.1�� ��������

        if(transform.position.y< -4.03f)//-4.03�� �����ϸ� �������
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;//ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;//�÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;//�߽ɰ��� �Ÿ�
        float r1 = 0.5f;//ȭ���� �ݰ��� 0.5
        float r2 = 1.0f;//�÷��̾��� �ݰ��� 1.0

        if(d<r1+r2)//ȭ���� �ݰ�� �÷��̾� �ݰ��� ��ģ ���� 2���� ���� �Ÿ����� ������(�浹)
        {
            GameObject director = GameObject.Find("GameDirector");//gamedirector���� ������ �Ǳ��̰�
            director.GetComponent<GameDirector>().DecreaseHp();

            Destroy(gameObject);//ȭ���� ����
        }

    //    private void OnDrawGizmos()
    //{
        
    //}
}
}
