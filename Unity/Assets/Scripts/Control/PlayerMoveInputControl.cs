using UnityEngine;
using System.Collections;

/*
 * Input controls for player pawn movement
 */
public class PlayerMoveInputController : InputControl
{
	public PlayerPawn m_PlayerPawn;

	protected override void OnPress (Vector3 pos)
	{
		base.OnPress (pos);
	}

	protected override void OnUp (Vector3 pos)
	{
		base.OnUp (pos);
	}

	protected override void OnPressing (Vector3 pos)
	{
		base.OnPressing (pos);
	}
}
