using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{

   
    

    public float moveSpeed = 10.0f;
    public float rotSpeed = 10.0f;

    float h = 0.0f;
    float v = 0.0f;
    Transform tr;

    

    // move 변수
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
     

        //회전 : 키보드 좌우 방향키(Y축 기준 회전)
        h = Input.GetAxis("Horizontal");
        tr.Rotate(0, h * rotSpeed, 0, Space.World);
        //이동 : 키보드 전후 방향키(평면에서 앞뒤로 이동)
        v = Input.GetAxis("Vertical");
        float tz = v * moveSpeed * Time.deltaTime;
          tr.Translate(0, 0, tz);

    }

    void OnCollisionEnter(Collision coll)
    {  //플레이어와 아이템 충돌처리
        Debug.Log(coll.collider.tag);
        if (coll.collider.CompareTag("ItemY"))
        {
            Debug.Log(coll.collider.tag);
            //노란색 물체와 부딪히면 주인공 체력 증가 1
            
            Destroy(coll.collider.gameObject, 0.1f);
            coll.collider.GetComponent<CollCtrl>().Heal();

        }

        if (coll.collider.CompareTag("ItemB"))
        {
            // 파란색 물체와 부딪히면 총알의 발사 간격이 0.2초 감소
            Debug.Log(coll.collider.tag);
            ClickShot();
            Destroy(coll.collider.gameObject, 0.1f);
          
            coll.collider.GetComponent<CollCtrl>().Upgrade();
            
        }
    }

    

    //코루틴 함수
    public void ClickShot()
    {
        StartCoroutine(Shot());

    }
    IEnumerator Shot()
    {
        yield return new WaitForSeconds(GameManager.instance.AttackDelay);
       
    }

}
