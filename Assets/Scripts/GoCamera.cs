using UnityEngine;
using System.Collections;

public class GoCamera : MonoBehaviour
{
    private int counter = 0;
    public bool isStop = true;
    void Update ()
    {

        if(!isStop)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y
            ,counter/10-20);
            counter++;
        }
    }

}