using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdater : MonoBehaviour
{
    private Text text;
    public ScoreTracker st;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
        text.text = st.score.ToString();
    }
}
