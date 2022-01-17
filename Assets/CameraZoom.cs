using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public bool holdbtn;
    public bool releasebtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*  if(Input.GetAxis ("Mouse ScrollWheel") > 0)
          {
              GetComponent<Camera>().fieldOfView--;
          }
          if(Input.GetAxis ("Mouse ScrollWheel") < 0)
          {
              GetComponent<Camera>().fieldOfView++;
          } */

        if (holdbtn == true)
        {
            GetComponent<Camera>().fieldOfView--;
        }
        if (releasebtn == true)
        {
            GetComponent<Camera>().fieldOfView++;
        }
    }

    public void Hold()
    {
        holdbtn = true;
    }
    
    public void Release()
    {
        releasebtn = true;
    }
}
