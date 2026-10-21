using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float jumpheight = 15;
    //left right
    float lrinput;
    //forward backwrds
    float fbinput;
    //jump
    float jumpinput;
    //rigidbody
    Rigidbody cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        lrinput = Input.GetAxis("Horizontal");
        fbinput = Input.GetAxis("Vertical");
        jumpinput = Input.GetAxis("Jump");
        
        transform.Translate(Vector3.forward * speed * fbinput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * lrinput * Time.deltaTime);
        cube.AddForce(transform.up * jumpheight * jumpinput);
    }
}
