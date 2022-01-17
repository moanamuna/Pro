using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    public Animator purpleAn;
    // Start is called before the first frame update
    void Start()
    {
        purpleAn = gameObject.GetComponent<Animator>();
    }

    public void PurpleAnim()
    {
        purpleAn.Play("PurpleAnimation");
        Debug.Log("Anim Purple");
    }
}
