using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int healt = 5;
    public int level = 1;
    public float speed = 1.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        healt += level;
        print("Çהמנמגüו:" + healt);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
