function Module_Player_Sprite_Gill_Balentine::onCollision(%this,%Composite_Sprite_Player,%Colliding_Object,%Collision_Details)
{

%Player_Information=%Composite_Sprite_Player.Script_Object_Parent;

%Player_Information.Composite_Sprite.setLinearDamping(%Player_Information.Linear_Damping);

}
