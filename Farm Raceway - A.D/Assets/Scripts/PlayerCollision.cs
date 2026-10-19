using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour

{
    public void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
    void Die()
    {

        Debug.Log("Player Died!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
