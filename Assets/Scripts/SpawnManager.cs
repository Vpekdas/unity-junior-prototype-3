using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    private PlayerController _playerControllerScript;

    private Vector3 _spawnPos = new(25, 0, 0);

    private readonly float _startDelay = 2.0f;
    private readonly float _repeatRate = 2.0f;

    void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating(nameof(SpawnObstacle), _startDelay, _repeatRate);
    }

    private void SpawnObstacle()
    {
        if (!_playerControllerScript.GameOver)
        {
            Instantiate(ObstaclePrefab, _spawnPos, ObstaclePrefab.transform.rotation);
        }
    }
}