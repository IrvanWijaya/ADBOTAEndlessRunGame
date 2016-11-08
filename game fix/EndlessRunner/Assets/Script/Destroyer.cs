using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	public GameObject platformDestroy;
	// Use this for initialization
	void Start () {
		platformDestroy = GameObject.Find ("DestroyPoint");
	}

	// Update is called once per frame
	void Update () {
		if (transform.position.x < platformDestroy.transform.position.x) {
			Destroy (gameObject);	
		}
	}
}
