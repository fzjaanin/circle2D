using UnityEngine;
using System.Collections;

public class ChallengeGenerator : MonoBehaviour {
    public Transform circle;
    public GameObject firstChallenge;
    //Array of challenges to generate randomly
    public GameObject[] challenges;
    // Use this for initialization
    ChallengeInfo lastChallenge;
	
	void Start () {
        //generate first 3 random challenges
        int RandomInt = Random.Range(0, challenges.Length);
        GameObject initObj;
        lastChallenge = firstChallenge.GetComponent<ChallengeInfo>();
        for (int i = 0; i < 1; i++) {
            RandomInt = Random.Range(0, challenges.Length);
            initObj = Instantiate(challenges[RandomInt], lastChallenge.GetEndPos(), Quaternion.identity) as GameObject;
            initObj.transform.parent = transform;
            lastChallenge = initObj.transform.GetComponent<ChallengeInfo>();
        }
	}
	
	
	void Update () {
        
        int RandomInt;
        GameObject initObj;
        Transform currentChild;
        for (int i = 0; i < transform.childCount; i++){
            currentChild = transform.GetChild(i);
            if (currentChild.GetComponent<ChallengeInfo>().GetEndPos().x - circle.position.x<=-15.0f)
            Destroy(currentChild.gameObject);
            if (lastChallenge && lastChallenge.GetEndPos().x - circle.position.x >= 5f) {
                RandomInt = Random.Range(0, challenges.Length);
                initObj = Instantiate(challenges[RandomInt], lastChallenge.GetEndPos(), Quaternion.identity) as GameObject;
                initObj.transform.parent = transform;
                lastChallenge = initObj.transform.GetComponent<ChallengeInfo>();
                return;
            }
          }
	}
}
