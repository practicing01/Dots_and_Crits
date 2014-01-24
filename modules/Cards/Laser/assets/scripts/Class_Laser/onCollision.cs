function Class_Laser::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,0))){return;}

if (%Colliding_Object.class$="Class_Sprite_Player")
{

if (%Colliding_Object.Script_Object_Parent.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,1);

}

}
else
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,1);

}

}
