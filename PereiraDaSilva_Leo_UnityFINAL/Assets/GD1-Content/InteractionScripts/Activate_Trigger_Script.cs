using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activate_Trigger_Script : MonoBehaviour {


    [Header("USE Key is 'E'",order=0)]
    
    [Header("add this component to your trigger",order=1)]
    [Header("Drag object to control from HIERARCHY", order=3)]
	public GameObject objectToActivate;
	[Header("pick animation clips for activate + deactivate")]
	public AnimationClip FirstAnimationToPlay;
	public AnimationClip SecondAnimationToPlay;


    private KeyCode usekey;
	private Animator animator;
	private bool triggerActivated=false;
    private float cooldownTime = .2f;
    private float activateDelay= 0f;

    private void Start()
    {
        animator = objectToActivate.GetComponent<Animator>();
        usekey = KeyCode.E;
    }

        void OnTriggerStay(Collider other)
    {
        if (Time.time > activateDelay)
        {
            if (Input.GetKey(usekey) && triggerActivated == false)
            {
                triggerActivated = true;
                animator.Play("Base Layer." + FirstAnimationToPlay.name, 0, 0);
                activateDelay = Time.time + cooldownTime;
            }
            else if (Input.GetKey(usekey) && triggerActivated == true)
            {
                triggerActivated = false;
                animator.Play("Base Layer." + SecondAnimationToPlay.name, 0, 0);
                activateDelay = Time.time + cooldownTime;
            }
        }
    }
}
