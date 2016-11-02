using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float moventSpeed;
	public float jump;
	private bool grounded;
	private float jarakTempuh = 20;

	public LayerMask theGround;
	private Collider2D myCollider;
	private Rigidbody2D myRigidBody;
	private Animator myAnimator;
	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D> ();
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		grounded = Physics2D.IsTouchingLayers (myCollider,theGround);

		myRigidBody.velocity = new Vector2 (moventSpeed,myRigidBody.velocity.y);

		if(Input.GetKeyDown(KeyCode.Space)){
			if (grounded) {
				myRigidBody.velocity = new Vector2 (myRigidBody.velocity.x, jump);
			}
		}
			
		if(transform.position.x > jarakTempuh && this.moventSpeed < 50){
			this.moventSpeed++;
			this.jarakTempuh += 20;
		}

		myAnimator.SetFloat ("moventSpeed", myRigidBody.velocity.x);
		myAnimator.SetBool ("grounded", grounded);
	
	}
}
