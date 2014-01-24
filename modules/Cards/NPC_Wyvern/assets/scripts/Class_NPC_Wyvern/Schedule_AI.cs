function Class_NPC_Wyvern::Schedule_AI(%this)
{

if ($Bool_A_I_Token_Bearer)
{

if (%this.Simset_Colliding_Objects.getCount())
{

%Collided_Object=%this.Simset_Colliding_Objects.getObject(0);//First in, first to die :D.

//0=Breath, 1=Move to.
%Random_Decision=getRandom(0,1);

if (%Random_Decision==0&&%this.isMoveToComplete())
{

if (%Collided_Object.class$="Class_Sprite_Player")
{

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Attack",
%Collided_Object.Module_ID_Parent,%Collided_Object.Script_Object_Parent.Game_Connection_Handle,-1,%this.Object_Index,1);

}
else
{

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Attack",
%Collided_Object.Module_ID_Parent,%Collided_Object.Game_Connection_Handle,%Collided_Object.Object_Index,%this.Object_Index,1);

}

}
else if (!%this.Bool_Is_Mobile)
{

commandToServer('Relay_Module_Function',Module_Card_NPC_Wyvern,"Action_Move",%Collided_Object.Position,%this.Object_Index);

}

}

}

%this.Schedule_AI=schedule(2000,0,"Class_NPC_Wyvern::Schedule_AI",%this);

}
