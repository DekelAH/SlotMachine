#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion

using System;
using TMPro;
using UnityEngine;

namespace Slots.Popups.Paytable
{
	public class PaytablePopupView : MonoBehaviour
	{
		#region Editor

		[SerializeField]
		private TMP_Text[] _paytablePriceTexts;

		[SerializeField]
		private GameObject _paytableContent;

		[SerializeField]
		private GameObject _loadingContent;
		
		#endregion
		
		#region Methods

		public void SetInLoadingState()
		{
			_paytableContent.SetActive(false);
			_loadingContent.SetActive(true);
		}

		public void SetInPaytableState()
		{
			_paytableContent.SetActive(true);
			_loadingContent.SetActive(false);
		}

		public void OnOkButtonClicked()
		{
		}

		#endregion
	}
}