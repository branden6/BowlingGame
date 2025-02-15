using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    private FallTrigger[] pins;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        pins = FindObjectsOfType<FallTrigger>();

        foreach (FallTrigger pin in pins)
        {
            pin.OnPinFall.AddListener(IncrementScore);
        }
    }

    // Update is called once per frame
    private void IncrementScore(){
        score++;
        scoreText.text = $"Score: {score}";
    }
}
