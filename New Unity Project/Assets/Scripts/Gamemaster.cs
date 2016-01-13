
using UnityEngine;
using System.Collections;

public class Gamemaster : MonoBehaviour {
    public enum playerState {normal,powered };
    public enum enemyState {follow, runAway };
    playerState currentPlayerState;
    enemyState currentEnemyState;
    private float speed = 2.5f;
    public Transform player;
    public GameObject enemy;
  //  float step = speed * Time.deltaTime;
    // Use this for initialization
    void Start () {
        currentPlayerState = playerState.normal;
        currentEnemyState = enemyState.follow;
	}
	
	// Update is called once per frame
	void Update () {
	   if (Input.GetKeyDown("p")&&currentPlayerState == playerState.normal)
        {
            currentPlayerState = playerState.powered;
        }
       else
        {
            currentPlayerState = playerState.normal;
        }
       if (currentEnemyState == enemyState.follow)
        {
            float step = speed * Time.deltaTime;
            //enemy.transform.LookAt(player);
            enemy.transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
        if (currentEnemyState == enemyState.runAway)
        {
            float step = -speed * Time.deltaTime;
            enemy.transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
        if (currentPlayerState == playerState.normal);
        {
           
        }

	}
}
