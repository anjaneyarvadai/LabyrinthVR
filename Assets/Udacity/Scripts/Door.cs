using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
    public static bool locked = false;
	public AudioClip[] soundFiles;
	public AudioSource soundSource;
	public GameObject key;
	public static bool doorPress = false;
	public Renderer rend;

    void Update() {
        // If the door is unlocked and it is not fully raised
            // Animate the door raising up
		//Debug.Log(curypos);
		if (locked == true && doorPress == true){
			
			if (transform.position.y < 27.0f){
				transform.Translate(0, Time.deltaTime, 0);
			}
			else {
				soundSource.Stop();
			}
		}
    }

    public void doorOpen(){
    	Debug.Log("Door click");
    	Debug.Log(locked);
    	if(locked == true){
			Debug.Log("Check 1");
			soundSource.clip = soundFiles[1];
			soundSource.Play();
			doorPress = true;
			Debug.Log(soundSource.isPlaying);
			rend = GetComponent<Renderer>();
			rend.material.color = Color.green;
    	}
    	else if (locked == false){
			Debug.Log("Check 2");
			soundSource.clip = soundFiles[0];
			soundSource.Play();
			doorPress = false;
			Debug.Log(soundSource.isPlaying);
			rend = GetComponent<Renderer>();
			rend.material.color = Color.red;
    	}
		
    }

	public void doorClose(){
		locked = false;
		doorPress = false;
	}

    public void Unlock()
    {
    	
        // You'll need to set "locked" to true here
		key.GetComponent<Key>();
        Debug.Log("Setting door to unlock");
        locked = true;
        Debug.Log(locked);
    }
}
