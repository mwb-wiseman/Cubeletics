using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    void Update()
    {
        if (player.position.z <= 0)
        {
            scoreText.text = "0";
        }
        else if (player.position.z >= 1000)
        {
            scoreText.text = "1000";
        }
        else
        {
            scoreText.text = player.position.z.ToString("0");
        }
    }
}
