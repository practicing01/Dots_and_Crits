function Class_NPC_Wyvern_Fire_Ball::onCollision(%this,%Colliding_Object,%Collision_Details)
{

if (%Colliding_Object.getCollisionShapeIsSensor(getWord(%Collision_Details,1))){return;}

%Bool_Delete_Me=false;

if (%Colliding_Object.class$="Class_Sprite_Player")
{

//if (%Colliding_Object.Script_Object_Parent.Game_Connection_Handle!=%this.Game_Connection_Handle)
//{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(%Colliding_Object.Script_Object_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,1,10);

%Bool_Delete_Me=true;

//}

}
else if (%Colliding_Object.class$="Class_NPC_Wyvern"&&%Colliding_Object.Game_Connection_Handle!=%this.Game_Connection_Handle)
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,10);

%Bool_Delete_Me=true;

}
else if (%Colliding_Object.class!$="Class_NPC_Wyvern")
{

%Colliding_Object.Module_ID_Parent.Action_Update_Health(-1,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,1,10);

%Bool_Delete_Me=true;

}

if (%Bool_Delete_Me)
{

%this.Module_ID_Parent.NPC_Wyvern_Explosion_Spawn(%this.Position);

%this.Module_ID_Parent.Simset_Objects.remove(%this);

%this.safeDelete();

}

/*if ($Bool_A_I_Token_Bearer)
{

if (%Colliding_Object.SceneGroup!=30)//Walls
{

if (%Colliding_Object.class$="Class_Sprite_Player")
{

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Attack",
%Colliding_Object.Module_ID_Parent,%Colliding_Object.Script_Object_Parent.Game_Connection_Handle,-1,%this.Object_Index,0);

}
else
{

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Attack",
%Colliding_Object.Module_ID_Parent,%Colliding_Object.Game_Connection_Handle,%Colliding_Object.Object_Index,%this.Object_Index,0);

}

}

}*/

}
