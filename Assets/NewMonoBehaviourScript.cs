using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] score = { 90, 80, 70 };
        for(int i = 0; i<=score.Length; i++)
        {
            Debug.Log(score[i]);
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
