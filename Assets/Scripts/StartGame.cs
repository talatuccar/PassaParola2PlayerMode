using UnityEngine;
using UnityEngine.SceneManagement;
public class StartGame : MonoBehaviour
{
    public GameDataSo gameDataSo;
    public void Play()
    {
        if(gameDataSo.QuestionTopic == null)
          gameDataSo.QuestionTopic = "genelkültür"; // set default topic 
        SceneManager.LoadScene("GameScene");
    }
}
