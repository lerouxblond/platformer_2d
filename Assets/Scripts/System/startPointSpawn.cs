using UnityEngine;

public class startPointSpawn : MonoBehaviour
{
    [Header("Target")]
    [SerializeField] private Transform target;

    [Header("Start Position")]
    [SerializeField] public Vector2 startPosition;

    public startPointSpawn Instance;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(Instance);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        target.position = startPosition;
    }
}
