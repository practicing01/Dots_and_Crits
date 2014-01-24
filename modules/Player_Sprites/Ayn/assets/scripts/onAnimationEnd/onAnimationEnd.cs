function Module_Player_Sprite_Ayn::onAnimationEnd(%this,%Sprite_Player)
{

%Player_Information=%Sprite_Player.Script_Object_Parent;

%this.Animation_Reset(%Player_Information);

}
