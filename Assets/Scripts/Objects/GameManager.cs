using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public Player player;

    public PoolManager poolManager;

    public Camera MainCamera;
    Vector3 dist;

    void Start()
    {
        Instance = this;
        MainCamera = Camera.main;
        dist = MainCamera.transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.position = player.transform.position + dist;
    }
}
