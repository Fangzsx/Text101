using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = ("Gunfires. Explosions. Sounds of rotary engines. Seeing Ben's falling comrades one by one realized that this is already defeat. It never struck to him that this day will come. The day that he feared the most.\nSuddenly, Ben heard a very large noise and all things went bright. \n\n\n\nPress Enter to Continue.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
