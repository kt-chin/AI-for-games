using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
    //public bool Powered = false;
    public enum playerState {normal, powered};
    playerState playerCurrentState;
    // Use this for initialization
    void Start () {

        playerCurrentState = playerState.normal;
	}
	
	// Update is called once per frame
	void Update () {
            if (Input.GetKeyDown("p") && playerCurrentState == playerState.normal)
            {
                print("Powered");
                playerCurrentState = playerState.powered;
            }
            else
            {
            playerCurrentState = playerState.normal;
            }
        }
}
