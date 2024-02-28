using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputSystem : MonoBehaviour
{
	public static PlayerInputSystem Instance { get; private set; }

	[Header("MovementValues")]
	[Range(4f, 32f)] public float walkSpeed = 24f;
	[Range(8f, 48f)] public float runSpeed = 32f;

	[Header("ScriptsReference")]
	[SerializeField] private PlayerInput playerInputMap;

	[Header("MovementInternalValues")]
	public Vector2 normalizedMovement;
	public Vector2 movement;
	public float movementWeight;

	
}
