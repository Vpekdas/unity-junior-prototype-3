using UnityEngine;

public class MoveLeft : MonoBehaviour
{

    private readonly float _speed = 30.0f;
    private readonly float _leftBound = -15.0f;
    private PlayerController _playerControllerScript;
    void Start()
    {
        _playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!_playerControllerScript.GameOver)
        {
            transform.Translate(Time.deltaTime * _speed * Vector3.left);
        }

        if (transform.position.x < _leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }
    }
}