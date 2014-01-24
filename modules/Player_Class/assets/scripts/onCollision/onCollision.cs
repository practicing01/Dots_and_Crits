function Class_Sprite_Player::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

%this.Module_ID_Parent.onCollision(%this,%Colliding_Object,%Collision_Details);

}
