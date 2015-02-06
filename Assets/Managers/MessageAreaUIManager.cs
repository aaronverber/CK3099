using UnityEngine;
using System.Collections;

public class MessageAreaUIManager : MonoBehaviour {

	public GameObject speakerTextUI;
	public GameObject eventTextUI;

	// Use this for initialization
	void Start () {
		GameEventManager.EnemyDestroyed += EnemyDestroyed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void EnemyDestroyed(){
		//Instantiate(speakerTextUI, transform.position, transform.rotation);
	}
}
