using UnityEngine;
using System.Collections;

public class DeadAndRestart : MonoBehaviour {
	public Transform platformGenerator;
	private Vector3 platformStartPoint;

	public Movement thePlayer;
	private Vector3 playerStartPoint;
	// Use this for initialization
	void Start () {
		platformStartPoint = platformGenerator.position;
		playerStartPoint = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
