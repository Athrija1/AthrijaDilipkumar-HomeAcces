using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemylvl : MonoBehaviour
{
    public Transform startPos;
        // For trigger collisions (passing through/zones)
        private void OnCollisionEnter(Collision other)
        {
                Debug.Log("triggered");
            if (other.gameObject.CompareTag("Player"))
            {
            //Destroy(other.gameObject);
            other.gameObject.transform.position = startPos.position;
            }
        }

        void Die()
        {
            Debug.Log("Object died!");
            // Destroy this game object
            Destroy(gameObject);
        }
    
}
