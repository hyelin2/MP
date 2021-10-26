using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 충돌처리함수
public class CollCtrl : MonoBehaviour
{ 
    int n = 0;
    public PlayerCtrl pc;
    public BulletCtrl bc;
    public GameObject ItemY;
    public GameObject ItemB;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(15, 0, 45) * Time.deltaTime);
        

    }

    public void Upgrade()
    {
        GameManager.instance.AttackDelay -= 0.2f;

    }
    public void Heal()
    {
        GameManager.instance.deathNum++;
    }

    void Enem2Play()
    {
        //적과 주인공 충돌
        // 주인공 체력 감소
    }

    void EnemBullet2Play()
    {
        //적의 총알과 플레이어 충돌, 적의총알 제거, 주인공 체력 감소
    }

    void PlayerButtet2Enum()
    {
        //주인공 총알과 적 , 적 체력 감소
        // 제거한 몬스터 개수 증가

    }
    void Plyer2Item()
    {
        //아이템 제거
    }

    // 총알끼리는 충돌하지 않음  아이템은 주인공 이외에는 충돌하지 않음
   
    
   
}
