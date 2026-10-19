using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Collectible : MonoBehaviour
{
    public int itemsCollected;
    public TextMeshProUGUI collectableCounter;
    public NewLevel gameManager;


    public void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Collectable"))
        {
            gameManager.AddItem();
            collectableCounter.text = gameManager.itemsCollected.ToString();
            Destroy(other.gameObject);
        }

    }

  
}
 
    
