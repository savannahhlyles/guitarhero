using UnityEngine;
using UnityEngine.UI;

public class PPText : MonoBehaviour
{
    public string scoreName; 

    // Update is called once per frame
    void Update()
    {
        Text textComponent = GetComponent<Text>();
        if (textComponent != null)
        {
            textComponent.text = PlayerPrefs.GetInt(scoreName).ToString();
        }
        else
        {
            Debug.LogError("Text component is missing on GameObject " + gameObject.name);
        }
    }
}
