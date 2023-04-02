#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion

using System.Threading;
using Cysharp.Threading.Tasks;
using Slots.Models;
using TMPro;
using UnityEngine;

namespace Gameplay
{
	public class SlotMachineController : MonoBehaviour
	{
		#region Editor

		[SerializeField]
		private TMP_Text _spinPrice;

		[SerializeField]
		[Range(1f, 100f)]
		private float _reelsRotationSpeedMin;
		
		[SerializeField]
		[Range(1f, 100f)]
		private float _reelsRotationSpeedMax;

		[SerializeField]
		private SlotMachineModel _slotMachineModel;

		[SerializeField]
		private PlayerModel _playerModel;

		#endregion
		
		#region Fields

		#endregion
		
		#region Methods

		private void Start()
		{
		}

		public async void OnSpinButtonClick()
		{
		}

		public async void OnPaytableButtonClick()
		{
		}

		public async void OnExitButtonClick()
		{
		}

		#endregion
	}
}