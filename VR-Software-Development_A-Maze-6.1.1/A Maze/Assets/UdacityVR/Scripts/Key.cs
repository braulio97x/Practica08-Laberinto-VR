﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'keyPoofPrefab' and assign the 'KeyPoof' prefab to the field in Unity
    // Declare a Door named 'door' and assign the top level 'Door' game object to the field in Unity
    public GameObject keyPoofPrefab;
    public Door door;

    void Update () {
        // OPTIONAL-CHALLENGE: Animate the key rotating
        // TIP: You could use a method from the Transform class
        transform.Rotate(0.0f, 0.0f, 3.0f);
    }


	public void OnKeyClicked () {
		/// Called when the 'Key' game object is clicked
		/// - Unlocks the door (handled by the Door class)
		/// - Displays a poof effect (handled by the 'KeyPoof' prefab)
		/// - Plays an audio clip (handled by the 'KeyPoof' prefab)
		/// - Removes the key from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Key.OnKeyClicked()' was called");

        // TODO: Unlock the door, display the poof effect, and remove the key from the scene
        // Use 'door' to call the Door.Unlock() method
        door.Unlock();
        // Use Instantiate() to create a clone of the 'KeyPoof' prefab at this coin's position and with the 'KeyPoof' prefab's rotation
        Object.Instantiate(keyPoofPrefab, this.transform.position, keyPoofPrefab.transform.rotation);
        // Use Destroy() to delete the key after for example 0.5 seconds
        Object.Destroy(this.gameObject, 0.5f);
    }
}
