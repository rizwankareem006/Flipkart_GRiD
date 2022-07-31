using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator anim;
    void Awake(){
        anim = GetComponent<Animator>();
    }
    public void Walk(bool walk){
        anim.SetBool(AnimationTags.WALK_PARAMETER,walk);
    }
    public void Defend(bool defend){
        anim.SetBool(AnimationTags.DEFEND_PARAMETER,defend);
    }
    public void Attack1(){
        anim.SetTrigger(AnimationTags.ATTACK_TRIGGER_1);
    }
    public void Attack2(){
        anim.SetTrigger(AnimationTags.ATTACK_TRIGGER_2);
    }
    void FreezeAnimation(){
        anim.speed = 0f;
    }
    public void UnFreezeAnimation(){
        anim.speed = 1f;
    }
}
