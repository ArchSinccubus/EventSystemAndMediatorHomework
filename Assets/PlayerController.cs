using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public List<ObserverManager> Observers;

    public bool Moving;

    public void Attatch(ObserverManager obvs)
    {
        Observers.Add(obvs);

    }


    public void Remove(ObserverManager obvs)
    {
        Observers.Remove(obvs);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * 4, 0, Input.GetAxis("Vertical") * Time.deltaTime * 4);
            if (!Moving)
            {
                Moving = true;
                Notify();
            }
        }
        else
        {
            if (Moving)
            {
                Moving = false;
                Notify();
            }
        }

    }


    public void Notify()
    {
        foreach (var o in Observers)
        {
            o.GetLocationUpdate(Moving, transform.position);
        }
    
    }


}
