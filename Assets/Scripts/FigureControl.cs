using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureControl : MonoBehaviour
{
    static Animator anim;
    // Start is called before the first frame update

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
                {
                  if(hit.transform.name == "Body")
                {
                  anim.SetTrigger("isWaving");
                }
                }
             
        }
        
    }
}
