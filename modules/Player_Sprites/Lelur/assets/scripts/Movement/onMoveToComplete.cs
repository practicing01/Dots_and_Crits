function Module_Player_Sprite_Lelur::onMoveToComplete(%this,%Sprite_Player)
{

%Player_Information=%Sprite_Player.Script_Object_Parent;

%Player_Information.Bool_Is_Mobile=false;

%Player_Information.Sprite.setLinearDamping(%Player_Information.Linear_Damping);

if (%Player_Information.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

commandToServer('Relay_Module_Function',%Player_Information.Sprite.Module_ID_Parent,"Action_Position",%Player_Information.Game_Connection_Handle,%Player_Information.Sprite.Position);

}

%this.Animation_Reset(%Player_Information);

}
