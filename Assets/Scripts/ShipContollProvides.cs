using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ShipContollProvides {

	void UpdateControlls();
	void Initialize(ShipControllRequires _ship);
}
