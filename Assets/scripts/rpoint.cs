using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rpoint : MonoBehaviour
{
    GameObject[] objectToMove;
    
    public GameObject newParentObject;
    int noOfChildObject;



    // Start is called before the first frame update
    void Start()
    {
        //objectToMove = GameObject.FindGameObjectsWithTag("card");
        

       // for(int i = 0; i<this.transform.childCount;i++)
       // {
          //  objectToMove[i] = this.transform.GetChild(i).gameObject;
       // }
        

    }

    // Update is called once per frame
    void Update()
    {
        
        if (newParentObject.transform.childCount<=0 )
        {
            noOfChildObject = this.transform.childCount;
            objectToMove = new GameObject[noOfChildObject];

            for (int i=0; i < noOfChildObject; i++)
            {
                objectToMove[i] = this.transform.GetChild(i).gameObject;
            }


            //objectToMove = GetComponentsInChildren<GameObject>();
            if (this.transform.childCount >= 0)
            {
                
                foreach (GameObject card in objectToMove)
                {

                    StartCoroutine(change( card));
                    
                }

                
            }
        }   
    }

    IEnumerator change(GameObject card)
    {
        yield return new WaitForSeconds(5);
        card.transform.parent = null;
        Debug.Log("done1 " + name);
        card.transform.parent = newParentObject.transform;
    }
}
