using UnityEngine;
using System.Collections;

public class YetiController : MonoBehaviour {

	private Rigidbody2D _rigidBody;
	private Animator _animator;
	private int _health;
	private bool _jump; 
	private bool _grounded;
	private bool _dead;
	private GameController _gameController;


	// Use this for initialization
	void Start () {
		_rigidBody = GetComponent<Rigidbody2D> ();
		_animator = GetComponent<Animator> ();
		_gameController = GameObject
			.FindGameObjectWithTag ("GameController")
			.GetComponent<GameController>();

		// Two line method
		// var gc = GameObject.FindGameObjectWithTag("GameController");
		// _gameController = gc.GetComponent<GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		// reading key press or mouse input? DO IT HERE
		// readin INput.getAsix? Here or FixedUpdate




		if (!_jump) {
			_jump = Input.GetButtonDown ("Fire1");
		}


	}


	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Border") 
		{
			StartCoroutine(CoYetiDie());
			_dead = true;
		}

		// Yeti Dies
		// Destroy (collider.gameObject);
	}

	IEnumerator CoYetiDie()
	{
		yield return new WaitForSeconds (2);
		_rigidBody.isKinematic = true;
		_gameController.PlayerDied ();

	}

	void FixedUpdate() {
		var speed = 20;

		if (_dead) {
		//	GetComponent<Rigidbody2D>()
		//	_rigidBody.isKinematic = true;
			return;
		}

		if (_jump) {
			_jump=false;
			if(_grounded)
			{
				// Put code belower here to precent flying mode.
			}
			_rigidBody.AddForce(new Vector2(0,1500));

			_animator.SetTrigger("Jumping");
			_grounded=false;
			_animator.SetBool("Grounded", false);
		}
	
		var horizontal = Input.GetAxis ("Horizontal");
		var localScale = transform.localScale;


		if (horizontal < 0) {
			localScale.x = -1;
		} else if (horizontal > 0){
			localScale.x = 1;
		}

		// This is important or the if above doesn't do anything
		transform.localScale = localScale;


		if (horizontal != 0) {
			_animator.SetBool ("Running", true);
		} else {
			_animator.SetBool ("Running", false);
		}

		_rigidBody.velocity = new Vector2 (horizontal * speed, 
		                                   _rigidBody.velocity.y);

	}


	void OnCollisionEnter2D(Collision2D collision){
		if (collision.gameObject.tag == "Platform") {
			_grounded = true;
			_animator.SetBool ("Grounded", true);
		}
	}

}
