using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    Animator anim;
    PlayerMovement pm;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        pm = GetComponent<PlayerMovement>();
        sr = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    void Update()
    {
        if (pm.moveDir.x != 0 || pm.moveDir.y != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        { 
            anim.SetTrigger("isSword");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            anim.SetTrigger("isPunch");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            anim.SetTrigger("isDead");
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            anim.SetTrigger("isHurt");
        }
        SpriteDirectionChecker();
    } 
    void SpriteDirectionChecker()
    {
        if (pm.lastHorizontal < 0)
        {
            sr.flipX = true;
        }
        else
        {
            sr.flipX = false;
        }
    }
}
