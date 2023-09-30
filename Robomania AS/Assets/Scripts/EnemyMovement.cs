using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
{
      public float speed;
}
  
    // Start is called before the first frame update
   // void Start()
   private void FixedUpdate()
  
  
  
  
   {
        float newXPosition = transform.position.x + speed * Time.deltaTime;
        float newYPosition = transform.position.y;(newXPosition, newYPosition);
        Vector 2 newPosition = new Vector2
        transform.position = newXPosition;
    }

    // Update is called once per frame
    //void Update()
    {
        
    }
}
