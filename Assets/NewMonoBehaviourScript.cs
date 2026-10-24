using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
   
}
    class Animal
    {
        public  virtual void Move()
        {
            Debug.Log("Move");
        }
    }
    class Dog : Animal
    {
        public override void Move()
        {
            Debug.Log("Run");
        }
    }
// Update is called once per frame
void Update()
    {

}
}
