using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabBox : MonoBehaviour
{
    public Transform grabDetect;
    public Transform boxHandler;
 
   
    public float rayDist;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {

        }
        
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D grabCheck = Physics2D.Raycast(grabDetect.position, Vector2.right * transform.localScale, rayDist);

        if(grabCheck.collider != null && grabCheck.collider.tag == "Box")
        {
            
            if (Input.GetKey(KeyCode.Q) || Input.GetButton("Fire1"))
            {
                grabCheck.collider.gameObject.transform.parent = boxHandler;
                grabCheck.collider.gameObject.transform.position = boxHandler.position;
                grabCheck.collider.gameObject.transform.GetComponent<Rigidbody2D>().isKinematic = true;
            }

            else
            {
                
                grabCheck.collider.gameObject.transform.parent = null;
                grabCheck.collider.gameObject.GetComponent<Rigidbody2D>().isKinematic = false;
            }




        }






      
        
    }
}
