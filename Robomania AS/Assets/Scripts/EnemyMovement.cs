using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     public float yForce;
     public float xForce;
     public float xDirection;
    //public float yDirection;
     private Rigidbody2D enemyRigidBody;
     // public float speed;
       
    // Start is called before the first frame update
   void Start()
{
    enemyRigidBody = GetComponent<Rigidbody2D>();
}
 
 
   private void FixedUpdate()
   {
       if (transform.position.x <= -8)
       {
        xDirection = 1;
        enemyRigidBody.AddForce(Vector2.right * xForce);
       }
       
       
       if (transform.position.x >= 8)
    
    {
       xDirection = -1;
        enemyRigidBody.AddForce(Vector2.left * xForce);
    }
   
   
    {
      // yDirection = -1;
       // enemyRigidBody.AddForce(Vector2.up * yForce);
    }
   
   
   
   }
  
  private void OnCollisionEnter2D(Collision2D collision)
   {
        if (collision.gameObject.tag == "Ground")
       // if (transform.position.x <= -8)
       {
         Vector2 jumpForce = new Vector2(xForce, yForce);


  //if (collision.gameObject.tag == "player")
       // Vector2 jumpForce = new Vector2(0, yForce);
        enemyRigidBody.AddForce(jumpForce);
          //  speed = speed * -1;
       }
   
       
   {
          //speed = speed * -1;
   }
        
        //float newXPosition = transform.position.x + speed * Time.deltaTime;
        //float newYPosition = transform.position.y;
        //Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        //transform.position = newPosition;
    }





}

    // Update is called once per frame
    //void Update()
    
// change Crusher2 yforce back to 300