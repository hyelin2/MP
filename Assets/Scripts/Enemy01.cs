using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy01 : MonoBehaviour
    
{
   int  DeathNum = 3;

    // 이동변수
    public Transform playerTr;
    public Transform[] wayPoint;
    public GameObject bullet;

    NavMeshAgent agent;
    Renderer render;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Move(playerTr.position);   
    }
    void Move(Vector3 nextPos)
    {
        // 주인공 추적(1초), 랜덤 방향 이동 2초 반복 ( 미완 )
        if(agent.isPathStale == false)
        {
            agent.destination = nextPos;
            agent.isStopped = false;
        }
    }
    void Attack() {
        //Vector3 fireDir = Random.Range(0,wayPoint[nextIndex]);
        GameObject obj = Instantiate(bullet);
        obj.transform.position = transform.position;
        //obj.GetComponent<Rigidbody>().AddForce(fireDir * 100);
        Destroy(obj, 10);
        //2-4초마다 랜덤 방향으로 총알 발사,
        //10초 후 제거 (ok)
        // 총알이 벽과 충돌시 반사되어 방향 전환
    }
    void Death() {

        // 체력==0이면 사망, 랜덤 위치에서 다시 생성 
    }

}
