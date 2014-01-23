function Class_NPC_Wyvern::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

if (%Colliding_Object.SceneGroup==0){return;}

for (%x=0;%x<%this.Simset_Colliding_Objects.getCount();%x++)
{

%Collided_Object=%this.Simset_Colliding_Objects.getObject(%x);

if (%Collided_Object==%Colliding_Object)
{

return;

}

}

%this.Simset_Colliding_Objects.add(%Colliding_Object);

}
