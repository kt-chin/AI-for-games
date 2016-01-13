using UnityEngine;
using System.Collections;

public class EnemyFollow : MonoBehaviour {
    public Transform player;
    private float speed = 2.5f;
    // Use this for initialization
    public enum enemyState {follow, run };
    enemyState currentState;
    void Start () {
       // enemyState currentState;

        currentState = enemyState.follow;
	}
	
	// Update is called once per frame
	void Update () {
      //  if (PlayerScript.playerCur)
        if (currentState == enemyState.follow)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
	}
}
