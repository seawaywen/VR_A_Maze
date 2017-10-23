using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoofObj;
    public GameObject door;


	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy
        Vector3 myPosition = gameObject.transform.position;
        print(myPosition);


        Object.Instantiate(keyPoofObj, myPosition, Quaternion.Euler(-90f, 0, 0));
        Destroy(gameObject);

    }

}
