using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    [SerializeField]
    private Transform hand;

    private float speed = 20;

    private bool clicked;

    private bool handLifted = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        float step =  speed * Time.deltaTime;
        if(!clicked){
            clicked = Input.GetMouseButtonDown(0);
            if(handLifted){
                transform.position = mousePos;
                hand.position = transform.position + Vector3.one * 3;
            } else{
                transform.localScale = Vector3.Lerp(Vector3.one * 1.5f, Vector3.one * 2, Time.deltaTime / 0.5f);
                hand.position = Vector3.MoveTowards(hand.position, transform.position + Vector3.one * 3, step);
                if(hand.position == transform.position + Vector3.one * 3){
                    handLifted = true;
                }
            }
        } else {
            transform.localScale = Vector3.Lerp(Vector3.one * 2, Vector3.one * 1.5f, Time.deltaTime / 0.5f);
            hand.position = Vector3.MoveTowards(hand.position, transform.position, step);
            if(hand.position == transform.position){
                handLifted = false;
                clicked = false;
            }
        }
    }
}
