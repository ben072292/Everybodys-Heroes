using UnityEngine;
using UnityEngine.UI;

using System.Collections;

using TBTK;

namespace TBTK{

	public class UICampaign : MonoBehaviour {

		public Campaign campaign;
		public Text lbPoints;
		private enum _Tab{Unit, Perk}
		private _Tab tab=_Tab.Unit;
		public GameObject unitMenuObj;
		public GameObject mainObj;

		
		void Update(){
			lbPoints.text="$"+PerkManager.GetPerkCurrency().ToString("f0");
		}
		
		public void OnPlayButton(){
			campaign.OnPlayButton("Map");
		}
		
		public void BackFromLevel(){
			mainObj.SetActive(true);
			if(tab==_Tab.Unit) tab=_Tab.Perk;
			else if(tab==_Tab.Perk) tab=_Tab.Unit;
		}
		
		public void OnMenuButton(){
			Application.LoadLevel("Menu");
		}
		
	}

}