using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3 firstPerson = new Vector3(1, 2, 1/4);
    [SerializeField] Vector3 thirdPerson = new Vector3(0, 4, -8);
    private Vector3 currentView;

    void Start(){
        currentView = thirdPerson;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.C)){
            toggleCamera();
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + currentView;
    }

    void toggleCamera(){
        if(currentView == thirdPerson){
            currentView = firstPerson;
        } else {
            currentView = thirdPerson;
        }
    }
}
