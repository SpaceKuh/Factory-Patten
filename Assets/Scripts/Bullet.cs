using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Bullet {
	
	void OnHit();
	void SetPosition(Vector3 _position);
}
