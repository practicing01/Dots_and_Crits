function Class_Deathball::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

if (%Colliding_Object.class$="Class_Sprite_Player")
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,10);

}
else
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,10);

}

}
