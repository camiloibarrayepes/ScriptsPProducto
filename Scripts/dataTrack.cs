using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Vuforia
{
    public class dataTrack : MonoBehaviour
    {
        public Transform TextTargetName;
        public Transform TextTitle;
        public Transform TextDescription;
        public Transform PanelDescription;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach(TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + " -size: " + size.x + " , " + size.y);

                TextTargetName.GetComponent<Text>().text = name;
                TextTitle.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);

                Debug.Log("NAME: " + name);
                if(name == "miniqr")
                {
                    TextTitle.GetComponent<Text>().text = "MINI";
                    TextDescription.GetComponent<Text>().text = "MINI is a British automotive marque, owned by BMW since 2000, and used by them for a range of small cars. The word Mini has been used in car model names since 1959, and in 1969 it became a marque in its own right when the name Mini replaced the separate Austin Mini and Morris Mini car model names. BMW acquired the marque in 1994 when it bought Rover Group (formerly British Leyland), which owned Mini, among other brands.";
                }

                if(name == "target_bmw")
                {
                    TextTitle.GetComponent<Text>().text = "BMW";
                    TextDescription.GetComponent<Text>().text = "BMW is a German multinational company which currently produces automobiles and motorcycles, and also produced aircraft engines until 1945. The company was founded in 1916 and has its headquarters in Munich, Bavaria. BMW produces motor vehicles in Germany, Brazil, China, India, South Africa, the United Kingdom and the United States. In 2015, BMW was the world's twelfth largest producer of motor vehicles, with 2,279,503 vehicles produced. The Quandt family are long-term shareholders of the company, with the remaining stocks owned by public float.";
                }

            }
        }
    }
}

