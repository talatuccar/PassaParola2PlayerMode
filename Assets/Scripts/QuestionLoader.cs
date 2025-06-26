using UnityEngine;
using System.Collections.Generic;
using System;
public class QuestionLoader : MonoBehaviour
{
    string currentQuestionSet;
    public GameDataSo gameDataSo;

    [Serializable]
    public class Question
    {
        public string question;
        public string answer;
    }

    [Serializable]
    public class QuestionList
    {
        public List<Question> questions;
    }
    void Start()
    {
        currentQuestionSet = gameDataSo.QuestionTopic;

        LoadQuestions(0);
    }
    void LoadQuestions(int soruindex)
    {
        string jsonFileName = currentQuestionSet;
        TextAsset jsonData = Resources.Load<TextAsset>(jsonFileName);
       
        if (jsonData != null)
        {
            QuestionList questionList = JsonUtility.FromJson<QuestionList>(jsonData.ToString());
           
            GameManager.instance.GetQuestionData(questionList.questions[soruindex].question, questionList.questions[soruindex].answer);
        }
        else
        {
            Debug.LogError("JSON dosyasý bulunamadý!");
        }
    }
    void OnEnable()
    {
        GameManager.OnNextAsk += LoadQuestions;
    }
    void OnDisable()
    {
        GameManager.OnNextAsk -= LoadQuestions;
    }
}
