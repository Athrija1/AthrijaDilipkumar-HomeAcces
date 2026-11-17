using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject player;
    public NewLevel spawns;

    private void Start()
    {
        spawns = GameObject.FindGameObjectWithTag("GameManager").GetComponent<NewLevel>();
    }
    public void OnCollisionEnter(Collision collision)
    {
     
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Die();
        }
    }
    void Die()
    {
        player.transform.position = spawns.spawn1.transform.position;
        Debug.Log("Player Died!");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
