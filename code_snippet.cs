using System.Text;
using System.io;

public float ConvertStrTimeToFloat(String strTime)
{
  string[] nums = strTime.Split('h');
  hours = Int32.Parse(nums[0]);
  minutes = Int32.Parse(nums[1]);
  totalMinutes = hours * 60 + minutes;
  return totalMinutes / (60.0F * 24);
}

public float smoothStep(float x) {
  return x * x * x * (6 * x * x - 15 * x + 10);
}

private void Load(string fileName)
{
     List<List RDV> > allParcours = new List<List<RDV> >();
     string line;
     StreamReader theReader = new StreamReader(fileName, Encoding.Default);
     using (theReader)
     {
        do
        {
           line = theReader.ReadLine();
           if (line != null)
           {
               string[] entries = line.Split(',');
               if (entries.Length > 0) {
                  Int32 id = Int32.Parse(entries[0]);
                  String action = entries[2];
                  if(action == "position") {
                     for(int i=3; i<entries.Length; i++) {
                       RDV rdv = parseRDVs(entries[i]);
                       allParcours[id].Add(rdv);
                     }
                  }
               }
           }
        }
        while (line != null);
        theReader.Close();
     }
}

private RDV parseRDVs(String RDVStr)
{
  string[] parts = RDVStr.Split('-');
  float time = ConvertStrTimeToFloat(parts[0]);
  Vector2 vec = null;
  if(parts.Length == 2) {
     vec = PlacesDic[parts[1]];
  } else {
     x = float.Parse(parts[1]);
     y = float.Parse(parts[2]);
     vec = new Vector2(x,y);
  }
  return new RDV(time, vec);
}
