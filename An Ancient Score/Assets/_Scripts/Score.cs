<<<<<<< HEAD

// Franco Chong
=======
<<<<<<< HEAD
﻿// Franco Chong
=======
<<<<<<< HEAD
// Franco Chong
=======
<<<<<<< HEAD
﻿// Franco Chong
=======
<<<<<<< HEAD
// Franco Chong
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
﻿// Franco Chong
>>>>>>> origin/master
>>>>>>> origin/master
>>>>>>> d397798e513350b84bced5b9af6b47888af27cd5
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
>>>>>>> origin/master
// File: Life.cs
// Controls the score for the player

using UnityEngine;
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
﻿using UnityEngine;
>>>>>>> origin/master
>>>>>>> origin/master
>>>>>>> origin/master
>>>>>>> origin/master
>>>>>>> d397798e513350b84bced5b9af6b47888af27cd5
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
>>>>>>> origin/master
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreLabel;
	public int Scorecount = 0;
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
>>>>>>> origin/master

	public GameObject portal;
	
	// Use this for initialization
	void Start () {

		portal.gameObject.SetActive (false);
		//calls the setScore method to set the score counter
		this.setScore ();
	}



<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
=======
>>>>>>> origin/master
	
	
	// Use this for initialization
	//void Start () {
		
		//calls the setScore method to set the score counter
	//	this.setScore ();
		
<<<<<<< HEAD

	//}
=======
>>>>>>> origin/master
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
	}
>>>>>>> origin/master
	
	// Update is called once per frame
	void Update () {
		
	}
	
	//set the score for the player
	private void setScore(){
		this.scoreLabel.text = "Score: " + this.Scorecount;
	}

			
<<<<<<< HEAD

=======
=======
<<<<<<< HEAD
			
=======
	
>>>>>>> origin/master
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
>>>>>>> origin/master
	//Score will be added
	void OnTriggerEnter(Collider otherObjects){
		if (otherObjects.CompareTag("Gold")) {
			this.Scorecount += 50;
		}
		if (otherObjects.CompareTag ("ArrowShaft")) {
			this.Scorecount +=50;
		}
		if (otherObjects.CompareTag ("Wood")) {
			this.Scorecount +=50;
		}
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
>>>>>>> origin/master
		if (this.Scorecount == 300) {
			portal.gameObject.SetActive (true);
			if (otherObjects.CompareTag ("PortalCollider")) {
				Application.LoadLevel ("Menu");
			}
		}
<<<<<<< HEAD

=======
<<<<<<< HEAD
=======
=======
>>>>>>> origin/master
>>>>>>> 9c880de14240b836ff8139319b2b63f399b95c15
>>>>>>> origin/master
		this.setScore ();		
	}
}
