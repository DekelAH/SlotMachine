#region Copy
// This file is © 2022 Rumyancev Pavel <paulrumyancev@gmail.com>
// Vector. School of Game development
#endregion

using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Gameplay
{
	public class SlotMachineReel : MonoBehaviour
	{
		#region Fields

		private Transform _selfTransform;
		
		#endregion
		
		#region Methods

		private void Awake()
		{
			_selfTransform = GetComponent<Transform>();
		}
		
		#endregion
	}
}