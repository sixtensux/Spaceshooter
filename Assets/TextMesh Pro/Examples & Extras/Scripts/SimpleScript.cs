using UnityEngine;
using System.Collections;


namespace TMPro.Examples
{
    
    public class SimpleScript : MonoBehaviour
    {
        private TextMeshPro Text;
        
        public string label = "The text";
        private float m_frame;

        void Start()
        {
            Text = gameObject.AddComponent<TextMeshPro>();
        }


        void Update()
        {
            Text.SetText(label, m_frame % 1000);
            m_frame += 1 * Time.deltaTime;
        }

    }
}
