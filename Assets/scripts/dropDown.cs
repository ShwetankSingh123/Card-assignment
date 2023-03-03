using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class dropDown : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    Transform parentToReturnTo = null;
    public Text counttext;

    public void OnPointerEnter(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {

    }


    public void OnDrop(PointerEventData eventdata)
    {
        Debug.Log(eventdata.pointerDrag.name + "was dropped on " + gameObject.name);
        Draggable d = eventdata.pointerDrag.GetComponent<Draggable>();

        if (d != null)
        {
            d.parentToReturnTo = this.transform;
        }
    }

   
    void Update()
    {
        counttext.text = "Count: " + (transform.childCount).ToString();
    }

}

