using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public bool GameOver;
    public float FloatForce;
    public AudioClip MoneySound;
    public AudioClip ExplodeSound;
    public AudioClip BounceSound;
    public ParticleSystem ExplosionParticle;
    public ParticleSystem FireworksParticle;
    private readonly float _gravityModifier = 1.5f;
    private readonly float _yBound = 15.0f;

    private Rigidbody _playerRb;
    private AudioSource _playerAudio;

    void Start()
    {
        Physics.gravity *= _gravityModifier;
        _playerRb = GetComponent<Rigidbody>();
        _playerAudio = GetComponent<AudioSource>();

        // Apply a small upward force at the start of the game
        _playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
    }

    void Update()
    {
        // While space is pressed and player is low enough, float up
        if (Input.GetKey(KeyCode.Space) && !GameOver && transform.position.y < _yBound)
        {
            _playerRb.AddForce(Vector3.up * FloatForce, ForceMode.Impulse);
        }
        if (transform.position.y > _yBound)
        {
            float adjustedY = _yBound - transform.position.y;
            Vector3 newPos = new(transform.position.x, transform.position.y + adjustedY, transform.position.z);
            transform.position = newPos;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            ExplosionParticle.Play();
            _playerAudio.PlayOneShot(ExplodeSound, 1.0f);
            GameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        }

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            FireworksParticle.Play();
            _playerAudio.PlayOneShot(MoneySound, 1.0f);
            Destroy(other.gameObject);
        }

        else if (other.gameObject.CompareTag("Ground"))
        {
            _playerAudio.PlayOneShot(BounceSound, 1.0f);
            _playerRb.AddForce(10 * FloatForce * Vector3.up, ForceMode.Impulse);
        }
    }
}