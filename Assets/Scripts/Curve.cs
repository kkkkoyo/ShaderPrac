using UnityEngine;
using System.Collections;

public class Curve : MonoBehaviour
{
    public bool isRotation = true;
    public float speed = 30;
    private int counter = 0;

    void Update ()
    {

        int cou = 1;
        int cou2 = 1;//Random.Range(-1,2);

        transform.position = new Vector3(cou*10*Mathf.Sin(counter)+transform.position.x,transform.position.y
        ,counter/10);
        counter++;
    }

}