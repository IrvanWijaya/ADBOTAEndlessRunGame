using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour {

	//bwt jump & movement
	public float moventSpeed;
	public float jump;
	private bool grounded;
	private float jarakTempuh = 20;
	public LayerMask theGround;
	private Collider2D myCollider;
	private Rigidbody2D myRigidBody;
	private Animator myAnimator;

	//bwt score
	public int score;
	public Text scoreText;

	//bwt obstacle
	public GameObject[] obstacle = new GameObject[4];
	private int i;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();
		myCollider = GetComponent<Collider2D> ();
		myAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		//score
		score++;
		scoreText.text = "Score :" + score;

		//movement
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

		//obstacle
		i = Random.Range(0,3);
		if(obstacle[i].transform.position.x < transform.position.x - 3){
			obstacle [i].transform.position = new Vector3(this.transform.position.x + Random.Range(10,20), obstacle[i].transform.position.y,obstacle[i].transform.position.z );
		}
	
	}
}
