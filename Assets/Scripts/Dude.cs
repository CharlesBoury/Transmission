using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class Dude : MonoBehaviour {

	public List< List<RDV> > allParcours = new List< List<RDV> >();
	List<RDV> monParcours;
	public int id = 0;

	public Slider mainSlider;

	void Start() {

		List<RDV> parcours1 = new List<RDV>();
		parcours1.Add(new RDV(0, 0, 0));
		parcours1.Add(new RDV(0.01F, 1, 1));
		parcours1.Add(new RDV(0.02F, -1, 1));
		parcours1.Add(new RDV(0.03F, -1, -1));
		parcours1.Add(new RDV(0.04F, 1, 2));
		parcours1.Add(new RDV(0.05F, 4, -1));
		allParcours.Add(parcours1);

		List<RDV> parcours2 = new List<RDV>();
		parcours2.Add(new RDV(0, 1, 1));
		parcours2.Add(new RDV(0.005F, 2, 3));
		parcours2.Add(new RDV(0.025F, 1, 2));
		parcours2.Add(new RDV(0.04F, -3, 2));
		allParcours.Add(parcours2);

		monParcours = allParcours[id];
	}

	void Update() {
		float currentTime = mainSlider.value;

		// get position from monParcours & currentTime
		RDV previous = getPreviousRDV(monParcours, currentTime);
		RDV next = getNextRDV(monParcours, currentTime);
		if(next.time > previous.time) {
			float timeCursor = (currentTime - previous.time) / (next.time - previous.time);
			transform.position = previous.position + (next.position - previous.position) * timeCursor;	
		} else transform.position = next.position;
		
	}

	RDV getPreviousRDV(List<RDV> parcours, float t) {
		RDV result = new RDV();
		foreach (RDV rdv in parcours) {
			if (t >= rdv.time) result = rdv;
		}
		return result;
	}

	RDV getNextRDV(List<RDV> parcours, float t) {
		foreach (RDV rdv in parcours) {
			if (t <= rdv.time) return rdv;
		}
		return parcours[parcours.Count - 1];
	}
}
