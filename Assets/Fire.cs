using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Management;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARCore;
using UnityEngine.XR.ARSubsystems;


public class Fire : MonoBehaviour
{
    bool move = false;

    public GameObject targetimage;

    public Animator anim;
   // public Animator purpleAn;
    private float zoom;
   
    public bool btnPressedTrue = false;

    

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        //  purpleAn = gameObject.GetComponent<Animator>();

         zoom = GetComponent<Camera>().fieldOfView;

        

        //  zoom = GetComponent<ARCameraManager>().fieldOfView;
    }
   /* private void Update()
    {
        zoom = 60.0f;
        Camera.main.fieldOfView = zoom;
    } */
    public void HoldBtn(bool _move)
    {
        move = _move;
     
        if (move == true)
        {
            Debug.Log("Btn pressed");
            anim.Play("nonARcamera");
           
            targetimage.SetActive(true);
            zoom = 10f;
            btnPressedTrue = true;
        }  
        else
        {
            Debug.Log("Relesed");
            if (btnPressedTrue == true)
            {
                anim.Play("nonARcamera 0");
                Invoke("Imagefalse", 1);
                zoom = 60f;
                btnPressedTrue = false;
            }
        }
        
    }
    public void Imagefalse()
    {
        targetimage.SetActive(false);
    }
   
   /* public void PurpleAnim()
    {
        purpleAn.Play("PurpleAnimation");
        Debug.Log("Anim Purple");
    } */
}

