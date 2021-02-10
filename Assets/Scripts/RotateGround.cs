using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGround : MonoBehaviour
  
    
{
    [SerializeField] private float speed;
  
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")<0|| Input.GetAxis("Horizontal") > 0) {
            transform.Rotate(0,0,-Input.GetAxis("Horizontal")*speed*Time.deltaTime);
         
}
        if (Input.GetAxis("Vertical")<0|| Input.GetAxis("Vertical") > 0)
        {
            transform.Rotate(Input.GetAxis("Vertical")*speed*Time.deltaTime,0,0);

        }
        
    }
}
