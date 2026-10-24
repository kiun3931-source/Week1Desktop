using UnityEngine;
using System.IO;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
        if (!Directory.Exists("Data"))
        {
            Directory.CreateDirectory("Data");
        }
        File.WriteAllText("Data/save.txt", "Hello");
        string text = File.ReadAllText("Data/save.txt");

    }
// Update is called once per frame
void Update()
    {

}
}
