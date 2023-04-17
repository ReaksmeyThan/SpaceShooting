using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private GameObject playerObj = null;

 
    private Rigidbody p_rig = null;
    private float speed = 10;

   
    void Start()
    {
        p_rig = playerObj.GetComponent<Rigidbody>();
    }
    void Update()
    {
        Movement();
    }

   private void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        //playerObj.transform.position = new Vector3(h, v, 0);

        p_rig.velocity = new Vector3(h, v, 0)*speed;


        float x = Mathf.Clamp(p_rig.position.x, -4.8f, 4.8f);
        float y = Mathf.Clamp(p_rig.position.y, -8, 10);

        p_rig.position = new Vector3(x,y,0);

        p_rig.rotation = Quaternion.Euler(0, p_rig.velocity.x * -4, 0);
        
    }
}



