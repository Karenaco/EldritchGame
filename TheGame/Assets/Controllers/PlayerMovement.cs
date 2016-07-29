using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {


    public Animator anim;
	// Use this for initialization
	void Start () {
        setAnimation(1);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void setAnimation(int animationNumber)
    {
        if (animationNumber == anim.GetInteger("animation") || animationNumber == -anim.GetInteger("animation"))
        {
            anim.SetInteger("animation", -animationNumber);
        }
        else
        {
            anim.SetInteger("animation", animationNumber);

        }
        
        
    }
}
