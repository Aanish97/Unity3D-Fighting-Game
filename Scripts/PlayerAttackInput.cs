using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour {

    private CharacterAnimations playerAnimation;
	// Use this for initialization
	void Awake () {
        playerAnimation = GetComponent<CharacterAnimations>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
            playerAnimation.Defend(true);
        }

        if(Input.GetKeyUp(KeyCode.J))
        {
            playerAnimation.UnFreezeAnimation();
            playerAnimation.Defend(false);

        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            if(Random.Range(0,2)>0)
            {
                playerAnimation.Attack_0();
            }
            else
            {
                playerAnimation.Attack_1();
            }
        }

	}
}
