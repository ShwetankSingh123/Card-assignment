using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iDontKnow : MonoBehaviour
{
    Collider2D col;
    public GameObject card;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        card.transform.position = col.transform.position;
    }
}
