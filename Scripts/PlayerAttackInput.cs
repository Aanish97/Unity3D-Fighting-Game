using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackInput : MonoBehaviour {

    private CharacterAnimations playerAnimation;
    public GameObject attack_point;
    public  PlayerSheild shield;

	// Use this for initialization
	void Awake () {
        playerAnimation = GetComponent<CharacterAnimations>();
        shield = GetComponent<PlayerSheild>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
//            playerAnimation.FreezeAnimation();
            playerAnimation.Defend(true);
            shield.ActivateShield(true);
        }

        if(Input.GetKeyUp(KeyCode.J))
        {
            playerAnimation.UnFreezeAnimation();
            playerAnimation.Defend(false);
            shield.ActivateShield(false);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            playerAnimation.Attack_0();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
           
            playerAnimation.Attack_1();
            
        }

	}

    void Activate_attack_point()
    {
        attack_point.SetActive(true);
    }

    void DeActivate_attack_point()
    {
        if (attack_point.activeInHierarchy)
        {
            attack_point.SetActive(false);
        }
    }
}
