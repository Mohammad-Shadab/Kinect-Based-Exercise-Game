using UnityEngine;
//using Windows.Kinect;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System.Text; 



// Avatar controller is the component that transfers the captured user motion to a humanoid model (avatar). Avatar controller classic allows manual assignment of model's rigged bones to the Kinect's tracked joints.

public class AvatarControllerClassic : AvatarController
{	
	// Public variables that will get matched to bones. If empty, the Kinect will simply not track it.
	
	 public Transform ClavicleLeft;
	 public Transform ShoulderLeft;
	public Transform ElbowLeft; 
	 public Transform HandLeft;
	public Transform FingersLeft;

	public Transform ThumbLeft;

	 public Transform ClavicleRight;
	public Transform ShoulderRight;
	public Transform ElbowRight;
	public Transform HandRight;
	public Transform FingersRight;


	 public Transform ThumbRight;
	public Transform HipCenter;
	 public Transform Spine;
	public Transform ShoulderCenter;
	public Transform Neck;
	


	public Transform HipLeft;
	 public Transform KneeLeft;
	public Transform FootLeft;

	
	public Transform HipRight;
	 public Transform KneeRight;
	public Transform FootRight;


	
	public Transform BodyRoot;

	
	
// map the bones to the model.
	protected override void MapBones()
	{ 
		 bones[0] = HipCenter;
		bones[1] = Spine;
		bones[2] = ShoulderCenter;
		bones[3] = Neck;

	
		bones[5] = ShoulderLeft;
		bones[6] = ElbowLeft;
		bones[7] = HandLeft;

	
		bones[11] = ShoulderRight;
		bones[12] = ElbowRight;
		  bones[13] = HandRight;
	
		bones[17] = HipLeft;
		 bones[18] = KneeLeft;
		 bones[19] = FootLeft;
	
	
		bones[21] = HipRight;
		 bones[22] = KneeRight;
		bones[23] = FootRight;

		bones[25] = ClavicleLeft;
		 bones[26] = ClavicleRight;

		bones[27] = FingersLeft;
		bones[28] = FingersRight;
		 bones[29] = ThumbLeft;
		bones[30] = ThumbRight;
		
		
		bodyRoot = BodyRoot;
		
	}
	
}

