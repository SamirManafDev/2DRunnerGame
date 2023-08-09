using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    //[SerializeField] private Animator animator;
    [SerializeField] private GameObject pausePanel;
    [SerializeField] public GameObject RestartPanel;
    [SerializeField] private GameObject StartPanel;


    private bool isJumping = false;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
    }
    
    private void Update()
    {
        
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * moveSpeed, rb.velocity.y);


        PlayerJump();
    }
    public   void PlayerJump()
    {
        if ((Input.GetKey(KeyCode.Space) || Input.GetMouseButton(0) )&& !isJumping )
        {
            rb.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            isJumping = true;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;

        }
        if (collision.gameObject.CompareTag("River"))
        {
            RestartPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void StartPanelTap()
    {
        StartPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void PauseButton()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }
   
    public void Restart()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
}
