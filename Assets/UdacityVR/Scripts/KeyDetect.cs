using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDetect : MonoBehaviour 
{
    //public GameObject key;
    //public GameObject door;


	void FixedUpdate()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, fwd, 10)) {
            print("Nice thing happends!");
        }
    }



}
