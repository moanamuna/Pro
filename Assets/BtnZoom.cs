using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BtnZoom : MonoBehaviour
{
    public GameObject targetimage;
   
    public Animator anim;
    private float zoom;

    public bool btnPressedTrue = false;

    

    // public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();

         zoom = GetComponent<Camera>().fieldOfView;
    }

    public void btnPressed()
    {
        anim.Play("New Animation");

        targetimage.SetActive(true);
       // GetComponent<Camera>().fieldOfView = 10f;
        zoom = 10f;
        btnPressedTrue = true;
        //GetComponent<Camera>().fieldOfView--;
    }
    public void btnRelease()
    {
        if(btnPressedTrue == true)
        {
            anim.Play("ZoomOut");
            Invoke("Imagefalse", 1);
            zoom = 60f;
            

        }
        
        
    }
    public void Imagefalse()

    {
        Debug.Log("btn");
        targetimage.SetActive(false);
    }
    
}
