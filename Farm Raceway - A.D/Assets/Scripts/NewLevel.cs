using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
    public int itemsCollected = 0;
    public int itemsNeeded = 8;
    public GameObject player;
    public GameObject spawn2;

        public void AddItem()
        {
            itemsCollected++;

        Debug.Log("Item Collected! "+itemsCollected);

        if (itemsCollected >= itemsNeeded)
            {
                //LoadNextLevel();
                player.transform.position = spawn2.transform.position;
            }
        }

        void LoadNextLevel()
        {
            
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);

           
        }
}
