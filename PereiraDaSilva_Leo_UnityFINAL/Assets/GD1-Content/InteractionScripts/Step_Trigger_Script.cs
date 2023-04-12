using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step_Trigger_Script : MonoBehaviour {

	[Header("add this component to your trigger", order = 1)]
	[Header("Drag object to control from HIERARCHY", order = 3)]
	public GameObject objectToControl;
	[Header("pick animation clips for triggered + not triggered")]
	public AnimationClip FirstAnimationToPlay;
	public AnimationClip SecondAnimationToPlay;
	private Animator animator;

	void Start(){
		animator = objectToControl.GetComponent<Animator>();
	}

	void OnTriggerEnter (Collider other) {
		animator.Play("Base Layer." + FirstAnimationToPlay.name, 0, 0);
	}

	void OnTriggerStay (Collider other) {
		
	}

	void OnTriggerExit (Collider other) {
		animator.Play("Base Layer." + SecondAnimationToPlay.name, 0, 0);
	}
}

/* NOTES:
 * 
 * IF object imported (FBX) moves when animation plays, you need to do the following:
 * 1) create dummy in 3dsmax and drag your animating object under it (child)
 * 2) export to FBX
 * 3) import to Unity
 *
 *You can't attach a collider to the top object (the dummy), as it never moves with the animation. Instead:
 * 1) when object is in hierarchy, expand arrow, click on the actual child door, and add a box collider to that.
 * That will move with the door, as opposed to the dummy which stays still.
 * */
