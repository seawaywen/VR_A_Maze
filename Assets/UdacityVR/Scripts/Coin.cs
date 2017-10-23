using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public GameObject coinPoof;

    public Animator coinRotationAnimation;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy

        Vector3 myPosition = this.transform.position;
        print(myPosition);

        Object.Instantiate(coinPoof, myPosition, Quaternion.Euler(-90f, 0, 0));
        Destroy(gameObject);

    }

}
