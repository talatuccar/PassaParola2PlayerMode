using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public GameDataSo gameDataSo;
    public void Play()
    {
        if(gameDataSo.QuestionTopic == null)
          gameDataSo.QuestionTopic = "genelk�lt�r"; // set default topic 
        SceneManager.LoadScene("GameScene");
    }
}
