using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDel : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Delete();
    }

    void Delete()
    {
        if (Input.GetMouseButtonDown(0))
        {
          
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);
            if (hit.collider.gameObject.tag == "Enemy")
            {
                Destroy(hit.collider.gameObject);
            }
        }
    }
}
