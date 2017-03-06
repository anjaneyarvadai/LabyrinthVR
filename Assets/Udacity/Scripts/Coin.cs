using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;

    public void OnCoinClicked() {
		GameObject go = (GameObject)Instantiate(coinPoof);
		go.transform.position = transform.position;
		gameObject.SetActive(false);
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

    }

}
