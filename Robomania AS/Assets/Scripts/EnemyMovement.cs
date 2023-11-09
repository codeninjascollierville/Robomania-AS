using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour
{

      public float speed;

  
    // Start is called before the first frame update
   // void Start()
  void OnCollisionEnter(Collision other)
  {
     if(other.gameObject.tag == "Enemy")
     {
        print("Shreyas.is.silly");
     }
  }
   private void FixedUpdate()





  
   {
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;
        Vector2 newPosition = new Vector2(newXPosition, newYPosition);
        transform.position = newPosition;
    }
}

    // Update is called once per frame
    //void Update()
    
        
    

