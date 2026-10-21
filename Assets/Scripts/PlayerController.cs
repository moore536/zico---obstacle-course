using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    //left right
    float lrinput;
    //forward backwrds
    float fbinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lrinput = Input.GetAxis("Horizontal");
        fbinput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.forward * speed * fbinput * Time.deltaTime);
        transform.Translate(Vector3.right * speed * lrinput * Time.deltaTime);
    }
}
