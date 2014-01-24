function Module_Player_Sprite_Lelur::onAnimationEnd(%this,%Sprite_Player)
{

%Player_Information=%Sprite_Player.Script_Object_Parent;

%this.Animation_Reset(%Player_Information);

}
