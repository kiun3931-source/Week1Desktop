using UnityEngine;
using System.IO;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
        FileStream fs = new FileStream("save.dat", FileMode.Create);
        BinaryWriter writer = new BinaryWriter(fs);
        writer.Write(100);
        writer.Close();
    }
// Update is called once per frame
void Update()
    {

}
}
