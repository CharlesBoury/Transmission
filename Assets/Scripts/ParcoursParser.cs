// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using System.Text;
// using System.IO;

// [ExecuteInEditMode]
// public class ParcoursParser : MonoBehaviour {

// 	public string fileName;
// 	public List<List <RDV> > allParcours;

// 	void OnEnable() {
// 		Debug.Log("pouet");
// 	}


// 	public float ConvertStrTimeToFloat(string strTime)
// 	{
// 		string[] nums = strTime.Split('h');
// 		int hours = int.Parse(nums[0]);
// 		int minutes = int.Parse(nums[1]);
// 		int totalMinutes = hours * 60 + minutes;
// 		return totalMinutes / (60.0F * 24);
// 	}



// 	private void Load(string fileName)
// 	{
// 		 allParcours = new List<List<RDV> >();
// 		 string line;
// 		 StreamReader theReader = new StreamReader(fileName, Encoding.Default);
// 		 using (theReader)
// 		 {
// 			do
// 			{
// 			   line = theReader.ReadLine();
// 			   if (line != null)
// 			   {
// 				   string[] entries = line.Split(',');
// 				   if (entries.Length > 0) {
// 					  int id = int.Parse(entries[0]);
// 					  string action = entries[2];
// 					  if(action == "position") {
// 						 for(int i=3; i<entries.Length; i++) {
// 						   RDV rdv = parseRDVs(entries[i]);
// 						   allParcours[id].Add(rdv);
// 						 }
// 					  }
// 				   }
// 			   }
// 			}
// 			while (line != null);
// 			theReader.Close();
// 		 }
// 	}

// 	private RDV parseRDVs(string RDVStr)
// 	{
// 	  string[] parts = RDVStr.Split('-');
// 	  float time = ConvertStrTimeToFloat(parts[0]);
// 	  Vector2 vec;
// 	  if(parts.Length == 2) {
// 		 vec = PlacesDic[parts[1]];
// 	  } else {
// 		 x = float.Parse(parts[1]);
// 		 y = float.Parse(parts[2]);
// 		 vec = new Vector2(x,y);
// 	  }
// 	  return new RDV(time, vec);
// 	}




// }