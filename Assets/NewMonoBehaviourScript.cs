using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
   
}
private void Awake()
{
    Multiple(3, 4);
    Multiple(5, 8);
    Multiple(4, 6);
}
public void Multiple(int num1, int num2)
{
    int result = num1 * num2;
    Debug.Log($"{num1} x {num2} = {result}");
}
// Update is called once per frame
void Update()
    {

}
}
