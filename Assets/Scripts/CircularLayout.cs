
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CircularLayout : MonoBehaviour
{
    public GameObject letterPrefab;
    private int count = 22;
    List<GameObject> alphabetList = new List<GameObject>();
    List<GameObject> firstList = new List<GameObject>();

    GameDataSo gameDataSo;
    string GetLetter(int index)
    {
        string[] letters = {
            "A", "B", "C", "Ç", "D", "E", "F", "G", "H",
            "İ","K", "L", "M", "N", "O","P",
            "R", "S", "Ş", "T","Y", "Z"
        };
        return letters[index];
    }
    public void MakeCircularLayout(int radius, float size)
    {
        for (int i = 0; i < count; i++)
        {
            
            float angle = -i * Mathf.PI * 2f / count - Mathf.PI / 2f; //
            Vector2 pos = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius;

            GameObject letter = Instantiate(letterPrefab, transform);
            letter.GetComponent<RectTransform>().anchoredPosition = pos;
            letter.GetComponent<Transform>().localScale = new Vector3(size, size, 1);
            letter.GetComponentInChildren<TextMeshProUGUI>().text = GetLetter(i);
            alphabetList.Add(letter);
        }

        GameManager.instance.GetList(alphabetList);
    }
    void ColorFirstObjects(List<GameObject> firstPlayerResult)
    {
        foreach (var item in gameDataSo.correctList)
        {
            firstPlayerResult[item].GetComponent<Image>().color = Color.green;

        }
        foreach (var item in gameDataSo.wrongList)
        {
            firstPlayerResult[item].GetComponent<Image>().color = Color.red;

        }
        foreach (var item in gameDataSo.passedList)
        {
            firstPlayerResult[item].GetComponent<Image>().color = Color.yellow;
        }
    }
    public void MakeCircularLayout(int radius, float size, GameDataSo gamedataSo)
    {
        for (int i = 0; i < count; i++)
        {     
            float angle = -i * Mathf.PI * 2f / count - Mathf.PI / 2f; 
            Vector2 pos = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle)) * radius;

            GameObject letter = Instantiate(letterPrefab, transform);
            letter.GetComponent<RectTransform>().anchoredPosition = pos;
            letter.GetComponent<Transform>().localScale = new Vector3(size, size, 1);
            firstList.Add(letter);

        }
        gameDataSo = gamedataSo;
        ColorFirstObjects(firstList);
    }
}
