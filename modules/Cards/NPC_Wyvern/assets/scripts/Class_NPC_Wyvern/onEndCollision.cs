function Class_NPC_Wyvern::onEndCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%this.getCollisionShapeIsSensor(getWord(%Collision_Details,1)))
{

for (%x=0;%x<%this.Simset_Colliding_Objects.getCount();%x++)
{

%Collided_Object=%this.Simset_Colliding_Objects.getObject(%x);

if (%Collided_Object==%Colliding_Object)
{

%this.Simset_Colliding_Objects.remove(%Colliding_Object);

break;

}

}

}

}
