using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.blue);
    }

    // // Event callback example: Debug-draw all contact points and normals for 2 seconds.
    // //事件回调例子：绘制所有接触点和法线，这将用2秒时间渲染
    // function OnCollisionEnter(collision : Collision)
    // {
    //     for (var contact : ContactPoint in collision.contacts)
    //     {
    //         Debug.DrawRay(contact.point, contact.normal, Color.green, 2);
    //     }
    // }
}
