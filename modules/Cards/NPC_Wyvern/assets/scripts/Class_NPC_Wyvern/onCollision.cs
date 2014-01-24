function Class_NPC_Wyvern::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

if (%Colliding_Object.SceneGroup==0){return;}

if (%this.getCollisionShapeIsSensor(getWord(%Collision_Details,1)))
{

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
else
{

if (%Colliding_Object.class$="Class_Sprite_Player")
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,20);

}
else
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,20);

}

}

}
