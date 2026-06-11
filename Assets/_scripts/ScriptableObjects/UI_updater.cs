using TMPro;
using UnityEngine;

public class UI_updater : MonoBehaviour
{
    
    public SOint coins;
    public TextMeshProUGUI count;



    void Start()
    {
        count.text = coins.value.ToString(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        count.text = coins.value.ToString();
    }
}
