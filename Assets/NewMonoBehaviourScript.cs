using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
   
}
    class Player
    {
        private int hp;
        public Player(int hp)
        {
            this.hp = hp;
        }
    }
    Player player = new Player(10);
// Update is called once per frame
void Update()
    {

}
}
