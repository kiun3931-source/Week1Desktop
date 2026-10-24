using UnityEngine;
using System.Collections.ObjectModel;
using System.Collections;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
        Queue queue = new Queue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        Debug.Log(queue.Peek());

    }
// Update is called once per frame
void Update()
    {

}
}
