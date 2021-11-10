using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
	
	public float interpVelocity;
	public float minDistance;
	public float followDistance;
	public GameObject target;
	public Vector3 offset;
	Vector3 targetPos;
	private int lastDirection;
	private float offsetAmount = 0.0f;
	// Use this for initialization
	void Start () {
		//if(StateManager.gameState == StateManager.GAME_STATE_WIN)
		//{
		//GameObject goal = GameObject.Find("Goal");
		//target = goal;

		//targetPos = transform.position;

		//StartCoroutine("TargetPlayer");
		//StartCoroutine("SetPlaying");
	}

	IEnumerator TargetPlayer()
	{
		yield return new WaitForSeconds(1.0f);
		target = GameObject.Find("Player");
	}

	IEnumerator SetPlaying()
	{
		yield return new WaitForSeconds(1.5f);
		//StateManager.gameState = StateManager.GAME_STATE_PLAYING;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        /*
		if(StateManager.gameState == StateManager.GAME_STATE_WIN)
		{
			target = GameObject.Find("Goal");
		}
        */
		//if (target && (!GameObject.Find("Player").GetComponent<Control>().isDead))
        if(target)
		{
            /*
			if(lastDirection != GameObject.Find("Player").GetComponent<PlayerControl>().moveDirection)
			{
				// direction changed

				offsetAmount = 0;
			}
			lastDirection = GameObject.Find("Player").GetComponent<PlayerControl>().moveDirection;

			if(offsetAmount < 1.0f)
				offsetAmount += Time.deltaTime/3;

			switch(lastDirection)
			{
			case 1:
				offset.x = -offsetAmount;
				offset.y = 0;
				break;
			case 2:
				offset.x = offsetAmount;
				offset.y = 0;
				break;
			case 3:
				offset.x = 0;
				offset.y = offsetAmount;
				break;
			case 4:
				offset.x = 0;
				offset.y = -offsetAmount;
				break;
			}
			*/
            offset = Vector3.Lerp(offset, new Vector3(0, 0, 0), 0.05f);
            /*
			switch(GameObject.Find("Player").GetComponent<PlayerControl>().moveDirection)
			{
			case 1:
				offset = Vector3.Lerp( offset, new Vector3(-0.7f, 0, 0), 0.05f);

				break;
			case 2:
				offset = Vector3.Lerp( offset, new Vector3(0.7f, 0, 0), 0.05f);

				break;
			case 3:
				offset = Vector3.Lerp( offset, new Vector3(0, 0.7f, 0), 0.05f);

				break;
			case 4:
				offset = Vector3.Lerp( offset, new Vector3(0, -0.7f, 0), 0.05f);

				break;
			}
            */

            /*
			if(StateManager.gameState == StateManager.GAME_STATE_WIN)
			{
				offset.x = 0;
				offset.y = 0;
				target = GameObject.Find("Goal");
			}
            */

            Vector3 posNoZ = transform.position;
			posNoZ.z = target.transform.position.z;
			
			Vector3 targetDirection = (target.transform.position - posNoZ);
			
			interpVelocity = targetDirection.magnitude * 5f;
			
			targetPos = transform.position + (targetDirection.normalized * interpVelocity * Time.deltaTime); 
			
			transform.position = Vector3.Lerp( transform.position, targetPos + offset, 0.5f);
			
		}
	}
}