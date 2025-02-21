using UnityEngine;

public class SadSkillScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    Player player;
    void Start()
    {
        player = GameManager.Instance.player; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
    }
}
