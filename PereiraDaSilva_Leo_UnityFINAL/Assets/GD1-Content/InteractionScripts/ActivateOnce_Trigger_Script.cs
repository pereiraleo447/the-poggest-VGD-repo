using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOnce_Trigger_Script : MonoBehaviour {

	[Header("USE Key is 'E'", order = 0)]
	[Header("add this component to your trigger", order = 1)]
	[Header("Drag object to control from HIERARCHY", order = 3)]
	public GameObject objectToActivate;
	[Header("pick animation clips for activate")]
	public AnimationClip AnimClipToPlay;
	private KeyCode usekey;
	private Animator animator;
	private int triggeredAlready;

	private void Start(){
		animator = objectToActivate.GetComponent<Animator>();
		usekey = KeyCode.E;
		triggeredAlready = 0;
	}

	// Use this for initialization
	void OnTriggerStay (Collider other) {
		if (Input.GetKey (usekey) && triggeredAlready == 0){
			animator.Play("Base Layer." + AnimClipToPlay.name, 0, 0);
			triggeredAlready = 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}
