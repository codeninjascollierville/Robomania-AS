using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
     public float yForce;

     private Rigidbody2D enemyRigidBody;
     // public float speed;
       
    // Start is called before the first frame update
   void Start()
{
    enemyRigidBody = GetComponent<Rigidbody2D>();
}



   private void FixedUpdate()
  
  private void OnCollisionEnter2D(Collision2D collision)
   {
        
        if (transform.position.x <= -8)
       {
          //  speed = speed * -1;
       }

       if (transform.position.x >= 8)
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
    
        
    

