using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakTest : MonoBehaviour
{
    public string talk_line = "";
    public float time_interval = 5.0f;

    float time_count;

    // Start is called before the first frame update
    void Start()
    {
        time_count = time_interval;
    }

    // Update is called once per frame
    void Update()
    {
        time_count -= Time.deltaTime;

        if (time_count < 0)
        {
            time_count = time_interval;
            GetComponent<VoiceBoxer>().Talk(talk_line);
        }
    }
}
