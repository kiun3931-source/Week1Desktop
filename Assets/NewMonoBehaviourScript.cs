using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = new int[3];
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        //numbers[3] = 40;
        for(int i = 0; i < 3; i++)
        {
            Debug.Log(numbers[i]);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
