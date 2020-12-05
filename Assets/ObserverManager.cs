using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverManager : MonoBehaviour
{
    public int ID;

    public Material Mat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetLocationUpdate(bool moving, Vector3 loc)
    {
        if (moving)
        {
            Debug.Log("Observer " + ID + " Sees the player beginning to move from position: " + loc.ToString());

        }
        else
        {
            Debug.Log("Observer " + ID + " Sees the player stopping to move in position: " + loc.ToString());

        }

    }
}
