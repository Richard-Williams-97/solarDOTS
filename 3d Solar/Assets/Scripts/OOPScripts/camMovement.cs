using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camMovement : MonoBehaviour
{
    public float scrollSpeed;

    public float top;
    public float bot;
    public float left;
    public float right;

    void Update(){

        if(Input.mousePosition.y >= Screen.height * top){
            //Debug.Log("top");
            transform.Translate( (Vector3.forward + Vector3.right) * Time.deltaTime * scrollSpeed, Space.World);
        }

        if(Input.mousePosition.y <= Screen.height * bot){
            //Debug.Log("bot");
            transform.Translate( (Vector3.back + Vector3.left) * Time.deltaTime * scrollSpeed, Space.World);
        }

        if(Input.mousePosition.x >= Screen.width * right){
            //Debug.Log("right");
            transform.Translate( (Vector3.right + Vector3.back) * Time.deltaTime * scrollSpeed, Space.World);
        }

        if(Input.mousePosition.x <= Screen.width * left){
            //Debug.Log("left");
            transform.Translate( (Vector3.left+ Vector3.forward)  * Time.deltaTime * scrollSpeed, Space.World);
        }

    }
}
