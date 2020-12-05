using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConnectionMediator : MonoBehaviour
{
    private KeyCode[] numbers =
        {
            KeyCode.Alpha1,
            KeyCode.Alpha2,
            KeyCode.Alpha3,
            KeyCode.Alpha4,
            KeyCode.Alpha5,
            KeyCode.Alpha6,
            KeyCode.Alpha7,
    };

    public ObserverManager[] ObserverArray;

    public PlayerController Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (Input.GetKeyDown(numbers[i]))
            {
                if (!Player.Observers.Contains(ObserverArray[i]))
                {
                    Debug.Log("Attatching Observer " + (i + 1) + " to player");

                    Player.Attatch(ObserverArray[i]);

                    ObserverArray[i].Mat.color = Color.green;
                }
                else
                {
                    Debug.Log("Detatching Observer " + (i + 1) + " from player");

                    Player.Remove(ObserverArray[i]);

                    ObserverArray[i].Mat.color = Color.red;
                }
            }
        }
    }

    private void OnApplicationQuit()
    {
        foreach (var item in ObserverArray)
        {
            item.Mat.color = Color.red;
        }
    }
}

