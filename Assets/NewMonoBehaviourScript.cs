using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    void Start()
    {
        Player player = new Player();
        player.HP = 100;
    }
    public class Player
    {
        public int HP
        {
            get;
            set;
        }
    }
// Update is called once per frame
void Update()
    {

}
}
