using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour
{
    public int itemsCollected = 0;
    public int itemsNeeded = 8;
    public GameObject player;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject houseLevel;


        public void AddItem()
        {
            itemsCollected++;

        Debug.Log("Item Collected! "+itemsCollected);

        if (itemsCollected >= itemsNeeded)
            {
            //LoadNextLevel();
            houseLevel.SetActive(false);
            player.transform.position = spawn1.transform.position;
                itemsCollected = 0;
                spawn1 = spawn2;
            }
        }

        void LoadNextLevel()
        {
            
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextSceneIndex);

           
        }
}
