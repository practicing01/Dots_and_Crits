function Module_Player_Sprite_Gill_Balentine::onAnimationEnd(%this,%Sprite_Player)
{

%Player_Information=%Sprite_Player.Script_Object_Parent;

%this.Animation_Reset(%Player_Information);

}
