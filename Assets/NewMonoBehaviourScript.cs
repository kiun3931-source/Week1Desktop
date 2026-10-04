using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int hp = 5;
        if(hp <= 10)
        {
            Debug.Log("치명");
        }
        else if(hp <= 100)
        {
            Debug.Log("정상");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
