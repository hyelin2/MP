using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCtrl : MonoBehaviour
{
    private new Transform transform;
    public float rotSpeed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Mouse X");
    
        float tankrot = h * rotSpeed * Time.deltaTime;
       
        
        transform.Rotate(0, tankrot, 0, Space.Self);
    }
}
