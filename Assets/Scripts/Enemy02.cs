using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy02 : MonoBehaviour
{
    int deathNum = 3;
    public Transform[] wayPoints;
    int nextIndex = 0;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move(wayPoints[nextIndex].position);
    }

    void move(Vector3 pos) {
        //랜덤 방향  이동
        
        agent = GetComponent<NavMeshAgent>();
        if(agent.remainingDistance < 1.0f && agent.velocity.magnitude < 0.5f)
        {
            nextIndex = Random.Range(0, wayPoints.Length);
        }
        if(agent.isPathStale == false)
        {
            agent.destination = pos;
            agent.isStopped = false;
            

        }

        // 다른 오브젝트(총알제외)와 충돌 or 목표 지점 도달시 랜덤 방향전환
    }
    void Attack() {

        //3초마다 유도총알 발사(5초 후 제거)
        // 1초마다 주인공의 위치로 방향 전환
    }
    void death() {

        //체력 ==0이면 사망
        // 랜덤 위치에서 2개 다시 생성
    }
}
