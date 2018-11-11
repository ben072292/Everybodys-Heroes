using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TBTK;

public class TileCollider : MonoBehaviour {

	private List<DataUnit> selectedUnitList=new List<DataUnit>();

	void OnTriggerEnter(Collider other){
		if (Data.EndDataExist ()) {
			selectedUnitList = Data.GetEndData (0);
		}
		StartCoroutine(wait(2.0f));
	}

	IEnumerator wait(float waitTime){
		yield return new WaitForSeconds(waitTime);
		Data.SetLoadData(0, selectedUnitList);
		Application.LoadLevel("Lane1");
	}


}
