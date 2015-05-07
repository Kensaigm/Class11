using UnityEngine;
using System.Collections;

public class KillBird : MonoBehaviour {



	public void KillMe()
	{
		Destroy (gameObject);
	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeSpeed()
	{
		var animator = GetComponent<Animator> ();
		animator.speed = Random.Range (.1f, 2f);
	}


}
