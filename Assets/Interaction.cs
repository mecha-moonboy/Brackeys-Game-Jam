using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    public bool inMenu = false;
    public GameObject TextBox;

    // Start is called before the first frame update
    void Start()
    {
        
        TextBox.SetActive (false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(collider coll){
        
        if(coll.transform.tag == "Player"){
            
                if (Input.GetKeyDown("e")){
                
                //Open the interaction
                if(!inMenu){
                    print("open interaction");
                    TextBox.SetActive (true);
                    inMenu = true;
                }

                //Close the interaction
                else if(inMenu){
                    print("close interaction");
                    TextBox.SetActive (false);
                    inMenu = false;
                }
            }

        }
    }
}
