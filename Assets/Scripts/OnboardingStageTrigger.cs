using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnboardingStageTrigger : MonoBehaviour
{
    public YarnCommands yarnCommnands;

    public string nextNodeToLoad;
    // Start is called before the first frame update
    void Start()
    {
        yarnCommnands = FindObjectOfType<YarnCommands>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Onboarding Stage Triggered");
            yarnCommnands.StartNextOnboardingStage(nextNodeToLoad);

            gameObject.SetActive(false);
        }
    }
}
