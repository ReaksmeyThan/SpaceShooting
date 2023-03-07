using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject player = null;
    private Rigidbody p_rig = null;
    private float speed = 10;

    private float minX = -4.8f;
    private float maxX = 4.8f;
    private float minY = -8;
    private float maxY = 10;


    // Start is called before the first frame update
    void Start()
    {
        p_rig = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
   
        Movement();
    }

    private void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

      //  var movement = new Vector3(h, v, 0);

        //  player.transform.position = new Vector3(h, v, 0);
        p_rig.velocity = new Vector3(h, v, 0)*speed;

        p_rig.position = new Vector3(
            Mathf.Clamp(p_rig.position.x, minX, maxX),
            Mathf.Clamp(p_rig.position.y, minY, maxY),
            0);

        p_rig.rotation = Quaternion.Euler(0, p_rig.velocity.x * -4, 0);
    }

}
