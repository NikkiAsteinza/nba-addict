using System.Collections.Generic;
using UnityEngine;
using GoogleSheetsToUnity;

namespace Core
{
    public class Quiz : MonoBehaviour
    {
        public enum SheetStatus
        {
            PUBLIC,
            PRIVATE
        }
        public SheetStatus sheetStatus;

        [HideInInspector]
        public string associatedSheet = "1UI7J9POExuzknoPJN-rMmWN9pvXcgdOARSs9v6ipdn8";
        [HideInInspector]
        public string associatedWorksheet = "QUIZ";

        public List<Question> questionObject = new List<Question>();
    

        public bool updateOnPlay;

        void Awake()
        {
            if(updateOnPlay)
            {
                UpdateStats();
            }
        }

        void UpdateStats()
        {
            if (sheetStatus == SheetStatus.PRIVATE)
            {
                SpreadsheetManager.Read(new GSTU_Search(associatedSheet, associatedWorksheet), OnDataRecovered);
            }
        }

        void OnDataRecovered(GstuSpreadSheet ss)
        {
            Debug.Log(ss.ToString());
        }
    }
}
