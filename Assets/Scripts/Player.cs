using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Elements")]
    private Rigidbody2D rb;

    [Header("Movement Info")]
    private float xInput;
    private float yInput;

    [Header("Speed Info")]
    [SerializeField] private float moveSpeed;

    [Header("Score Info")]
    private int score;
    [SerializeField] private int targetScore;
    [SerializeField] private TextMeshProUGUI scoreCount;

    //[Header("Game Elements")]
    //[SerializeField] private GameObject winText;

    [Header("Canvas Groups")]
    [SerializeField] private CanvasGroup gameCG;
    [SerializeField] private CanvasGroup endCG;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ShowCG(gameCG);
        HideCG(endCG);
    }

    
    void Update()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = new Vector2(xInput, yInput);

        moveDirection.Normalize();

        rb.linearVelocity = moveDirection * moveSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Skull")
        {
            score++;
            scoreCount.text = score.ToString();

            Destroy(collision.gameObject);

            if (score >= targetScore)
            {
                moveSpeed = 0;
                ShowCG(endCG);
            }
        }


    }

    public void PlayAgainButtonCallBack()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        HideCG(endCG);
    }

    private void ShowCG(CanvasGroup cg)
    {
        cg.alpha = 1;
        cg.interactable = true;
        cg.blocksRaycasts = true;
    }

    private void HideCG(CanvasGroup cg)
    {
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }
}
