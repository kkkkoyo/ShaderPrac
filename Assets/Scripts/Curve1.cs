using UnityEngine;
using System.Collections;

public class Curve1 : MonoBehaviour
{
    public bool isRotation = true;
    public float speed = 30;
    private int counter = 0;

    void Update ()
    {

        int cou = Random.Range(-1,2);
        int cou2 = 1;//Random.Range(-1,2);

        transform.position = new Vector3(cou*10*Mathf.Sin(counter)+transform.position.x,cou*10*Mathf.Sin(counter)+cou*10*Mathf.Sin(counter)+transform.position.y
        ,transform.position.z);
        counter++;
    }

}