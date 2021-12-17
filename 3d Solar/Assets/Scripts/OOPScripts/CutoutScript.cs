using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutoutScript : MonoBehaviour
{

    public float size;
    public float pos;
    public float falloff;

    [SerializeField]
    private GameObject[] targetObject;

    [SerializeField]
    private LayerMask wallMask;

    private Camera mainCamera;


    private void Awake()
    {
        mainCamera = GetComponent<Camera>();
    }

    private void Update() {

        for (int i =0; i< targetObject.Length; i++){

            RaycastHit hit;

            if(Physics.Raycast(mainCamera.transform.position,
            (targetObject[i].transform.position - mainCamera.transform.position).normalized,  
            out hit, Mathf.Infinity, wallMask ))
            {
                if( hit.collider.gameObject.tag == "spheremask"){
                    //targetObject[i].transform.DOScale(0, 2);
                }
                else{
                    //targetObject[i].transform.DOScale(10, 2);
                }
            }

            }
        // for(int t= 0; t < targerObject.Length; ++t){

        //     Vector2 cutoutPos = mainCamera.WorldToViewportPoint(targerObject[t].position);
        //     cutoutPos.y /= (Screen.width / Screen.height);

        //     Vector3 offest = targerObject[t].position - transform.position;
        //     RaycastHit[] hitObjects = Physics.RaycastAll(transform.position, offest, offest.magnitude, wallMask);

        
        //     Debug.Log("test"+ hitObjects.Length);

        //     for(int i = 0; i < hitObjects.Length; ++i){

        //         Debug.Log("test"+ i);
        //         Material[] materials = hitObjects[i].transform.GetComponent<Renderer>().materials;

        //         for( int j = 0; j < materials.Length; ++j){
        //             Debug.Log("tesdfgsdfgsdfgsdfgst" +j);
        //             materials[j].SetVector("_CutoutPos", cutoutPos);
        //             materials[j].SetFloat("_cutoutSize", .1f);
        //             materials[j].SetFloat("_FalloffSize", 0.05f);
        //         }
        //     }   
        // } 
    }


}
