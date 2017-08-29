using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
    public bool isRotation = true;
    public float speed = 30;
    private int counter = 0;

    void Update ()
    {
        if (!isRotation)
            return;
        var r = transform.rotation.eulerAngles;
        r.y += speed * Time.deltaTime;
        transform.rotation = Quaternion.Euler (r);

        counter++;
        if(counter>30)
        {
            Vector3 position = Input.mousePosition;
			position.z = 10;
			Vector3 screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
            GameObject cubez ;
           if(GameObject.Find((int.Parse(this.name)+1).ToString())!=null)
           {
               cubez = GameObject.Find((int.Parse(this.name)+1).ToString());
           
                var moveHash = new Hashtable();
                cubez = GameObject.Find((int.Parse(this.name)+1).ToString());
                moveHash.Add ("position",cubez.transform.position);
                moveHash.Add ("time", 1.0f);
                moveHash.Add ("oncomplete", "AnimationEnd");
                moveHash.Add ("oncompletetarget", this.gameObject);
                iTween.MoveTo (this.gameObject, moveHash);
           }
        }
    }

}