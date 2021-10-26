using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float speed = 1000.0f;
    public GameObject bullet;
    public Transform firePos;
    public bool isDelay;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed);
        //rb.AddForce(transform.up * speed);
        
    }

    // Update is called once per frame
    void Update()
    {
        Attack();
    }
    void Attack()
    {
        // 공격 : 마우스 좌측 버튼을 누르고 있으면 전방으로 총알 발사, 1초당 1발
        if (Input.GetMouseButton(0) && isDelay == false)
        {
            isDelay = true;
            GameObject obj = Instantiate(bullet, firePos.position, firePos.rotation);
            ClickShot();
            Destroy(obj, 3.0f);

        }
    }

    public void ClickShot()
    {
        StartCoroutine(Shot());

    }
    IEnumerator Shot()
    {
        yield return new WaitForSeconds(1.0f);
        isDelay = false;
    }
}
