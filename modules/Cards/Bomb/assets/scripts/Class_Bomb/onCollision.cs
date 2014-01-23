function Class_Bomb::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

%this.playAnimation("Module_Card_Bomb:Animation_Bomb");

}
