using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepTimer_Trigger_Script : MonoBehaviour {

	[Header("add this component to your trigger", order = 1)]
	[Header("Drag object to control from HIERARCHY", order = 3)]
	public GameObject objectOnTimer;
	[Header("pick animation clips for triggered + not triggered")]
	public AnimationClip FirstAnimationToPlay;
	public AnimationClip SecondAnimationToPlay;
	[Header("set timer until end")]
	public float timer = 3;

	private Animator animator;
	private float eventTime;

	private bool triggerActivated=false;

	private void Awake(){
		eventTime = float.PositiveInfinity;
	}

	private void Start(){
		animator = objectOnTimer.GetComponent<Animator>();
	}
		
	private void OnTriggerEnter (Collider other) {
		if (triggerActivated == false) {
			triggerActivated = true;
			animator.Play("Base Layer." + FirstAnimationToPlay.name, 0, 0);
			StartTimer (timer);
		}
	}

	private void Update (){
		if (Time.time >= eventTime) {
			animator.Play("Base Layer." + SecondAnimationToPlay.name, 0, 0);
			eventTime = float.PositiveInfinity;
			triggerActivated = false;
		}
	}

	private void StartTimer (float delay){
		eventTime = Time.time + delay;
	}
}