using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public Player player;

    public PoolManager poolManager;
    void Start()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
