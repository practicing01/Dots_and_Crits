function Class_Deathball::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.class$="Class_Composite_Sprite_Player")
{

if (%Colliding_Object.Script_Object_Parent.Game_Connection_Handle==$GameConnection_Serverside_Connection)
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,-10);

}

}
else
{

%Colliding_Object.Update_Health(-10);

}

}
