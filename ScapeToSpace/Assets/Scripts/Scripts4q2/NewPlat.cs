using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NewPlat : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject objectToInstantiate;
    private GameObject myCurrentObject;
    Collider2D blockCollider;

    void Start()
    {
        
    }

    #region IBeginDragHandler implementation

    public void OnBeginDrag(PointerEventData eventData)
    {
        var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
        screenPoint.z = 10.0f;
        myCurrentObject = Instantiate(objectToInstantiate, Camera.main.ScreenToWorldPoint(screenPoint), transform.rotation);
        myCurrentObject.layer = 0;
        blockCollider = myCurrentObject.GetComponent<Collider2D>();
        blockCollider.enabled = false;
        //blockGravity = myCurrentObject.GetComponent<Rigidbody2D>();
        //blockGravity.gravityScale = 0;

    }

    #endregion

    #region IDragHandler implementation

    public void OnDrag(PointerEventData eventData)
    {
        if (myCurrentObject)
        {
            var screenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z);
            screenPoint.z = 10.0f;
            myCurrentObject.transform.position = Camera.main.ScreenToWorldPoint(screenPoint);
        }
    }
    #endregion

    #region IEndDragHandler implementation
    public void OnEndDrag(PointerEventData eventData)
    {
        if (myCurrentObject)
        {
            blockCollider = myCurrentObject.GetComponent<Collider2D>();
            blockCollider.enabled = true;
            myCurrentObject = null;
            
        }
    }

    #endregion
}
