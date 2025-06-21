using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public ParticleSystem ParticleExplosion;
    public ParticleSystem DirtParticle;
    public AudioClip JumpSound;
    public AudioClip CrashSound;
    private Rigidbody _playerRb;
    private Animator _playerAnim;
    private AudioSource _playerAudio;

    public float JumpForce;
    public float GravityModifier;

    public bool GameOver = false;
    public bool IsOnGround = true;
    void Start()
    {
        _playerRb = GetComponent<Rigidbody>();
        _playerAnim = GetComponent<Animator>();
        _playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= GravityModifier;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsOnGround && !GameOver)
        {
            _playerRb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            _playerAnim.SetTrigger("Jump_trig");
            DirtParticle.Stop();
            _playerAudio.PlayOneShot(JumpSound, 1.0f);
            IsOnGround = false;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            IsOnGround = true;
            DirtParticle.Play();
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game over !");
            GameOver = true;
            _playerAnim.SetBool("Death_b", true);
            _playerAnim.SetInteger("DeathType_int", 1);
            ParticleExplosion.Play();
            DirtParticle.Stop();
            _playerAudio.PlayOneShot(CrashSound, 1.0f);
        }
    }
}