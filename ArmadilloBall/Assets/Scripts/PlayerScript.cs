using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

    private int count;
    public Text countText;
    public Text clearLevelText;

	// Use this for initialization
	void Start () {
        count = 0;
        setCountText();
        clearLevelText.gameObject.SetActive(false);
    }

	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickUps"))
        {
            other.gameObject.SetActive(false);
            count++;
            setCountText();
        }
        else if (other.gameObject.CompareTag("goal"))
        {
            clearLevelText.gameObject.SetActive(true);
        }
    }

    void setCountText()
    {
        countText.text = "Count : " + count.ToString();
    }
}
