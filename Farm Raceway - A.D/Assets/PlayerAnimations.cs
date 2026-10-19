using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public PlayerMovement player;

    public Animator anim;
    [SerializeField] private RuntimeAnimatorController idleController;
    [SerializeField] private RuntimeAnimatorController walkController;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.rb.velocity != Vector3.zero)
        {
            anim.runtimeAnimatorController = walkController;
        }

        else if (player.rb.velocity == Vector3.zero )
        {
            anim.runtimeAnimatorController = idleController;

        }
        
    }
}
