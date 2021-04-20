using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButtonPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void createDeleteButton()
    {
        GameObject child = gameObject.transform.GetChild(0).gameObject;
        child.active = !child.active;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider != null)
            {
                createDeleteButton();
            }
        }
        }
    }
